using Entity.Dtos.ModuleOperational;
using Entity.Models.ModuleOperation;
using Entity.Requests.EntityCreateRequest;
using Entity.Requests.EntityDetailRequest;
using Entity.Requests.ModuleOperation;
using Repository.Interfaces.IModuleOperationRepository;
using Service.Interfaces.ModelOperationService;
using Utilities.Pdf;

namespace Service.Implementations.ModelOperationService
{
    public class EvaluationService : BaseModelService<Evaluation, EvaluationDTO, EvaluationRequest>, IEvaluationService
    {
        private readonly IEvaluationRepository _evaluationRepository;
        private readonly SupabaseStorageService _storage;

        public EvaluationService(IEvaluationRepository evaluationRepository, SupabaseStorageService storage) : base(evaluationRepository)
        {
            _evaluationRepository = evaluationRepository;
            _storage = storage;
        }



        public async Task<EvaluationDetailRequest> CreateEvaluationAsync(EvaluationCreateRequest request)
        {
            // 1. Validar que la experiencia exista
            var experience = await _evaluationRepository.GetExperienceWithInstitutionAsync(request.ExperienceId)
                ?? throw new KeyNotFoundException("La experiencia no existe");

            // 2. Construir evaluación con Builder (suma los scores) y obtener criterios sin EvaluationId
            var builder = new EvaluationBuilder(request)
                .AddCriteriaScores(request.EvaluationCriteriaDetail);

            var (evaluation, criteriaList) = builder.Build(); // ahora devuelve evaluación y lista de criterios

            // 3. Guardar evaluación para obtener Id generado
            evaluation = await _evaluationRepository.AddEvaluationAsync(evaluation);

            // 4. Asignar EvaluationId a cada criterio y guardarlos
            foreach (var c in criteriaList)
            {
                c.EvaluationId = evaluation.Id; // asignamos Id recién generado
                await _evaluationRepository.AddEvaluationCriteriaAsync(c);
            }

            // 5. Actualizar campos adicionales de Criteria si es necesario
            foreach (var c in request.EvaluationCriteriaDetail)
            {
                var criteria = await _evaluationRepository.GetCriteriaByIdAsync(c.CriteriaId);
                if (criteria != null)
                {
                    criteria.DescriptionContribution = c.DescriptionContribution;
                    await _evaluationRepository.UpdateCriteriaAsync(criteria);
                }
            }

            // 6. Obtener DTO final usando el mapper del repository
            var evaluationDto = await _evaluationRepository.GetEvaluationDetailAsync(evaluation.Id);

            var pdfBytes = EvaluationPdfGenerator.Generate(
                    TypeEvaluation: evaluationDto.TypeEvaluation,   
                    comments: evaluationDto.Comments              
                );
            // 7. Subir PDF a Supabase
                 string pdfUrl = await _storage.UploadEvaluationPdfToSupabase(pdfBytes, evaluation.Id);

            // 8. Guardar URL en la evaluación y actualizar en BD
            await _evaluationRepository.UpdateEvaluationPdfUrlAsync(evaluation.Id, pdfUrl);

            return evaluationDto;
        }

    }
}

