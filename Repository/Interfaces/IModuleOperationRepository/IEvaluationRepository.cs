using Entity.Dtos.ModuleOperational;
using Entity.Models.ModelosParametros;
using Entity.Models.ModuleOperation;
using Entity.Requests.EntityDetailRequest;
using Entity.Requests.ModuleOperation;

namespace Repository.Interfaces.IModuleOperationRepository
{
    public interface IEvaluationRepository : IBaseModelRepository<Evaluation, EvaluationDTO, EvaluationRequest>
    {
        Task<Evaluation> AddEvaluationAsync(Evaluation evaluation);
        Task AddEvaluationCriteriaAsync(EvaluationCriteria criterEval);
        Task<Experience?> GetExperienceWithInstitutionAsync(int experienceId);
        Task UpdateCriteriaAsync(Criteria criteria);
        Task SaveChangesAsync();
        Task<Criteria?> GetCriteriaByIdAsync(int id);
        Task<EvaluationDetailRequest> GetEvaluationDetailAsync(int id);
        Task UpdateEvaluationPdfUrlAsync(int evaluationId, string pdfUrl);
    }
}
