using Builders;
using Entity.Dtos.ModuleOperational;
using Entity.Models.ModuleOperation;
using Entity.Requests.EntityCreateRequest;
using Entity.Requests.EntityDetailRequest;
using Entity.Requests.EntityUpdateRequest;
using Entity.Requests.ModuleOperation;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces.IModuleOperationRepository;
using Service.Extensions;
using Service.Interfaces.ModelOperationService;


namespace Service.Implementations.ModelOperationService
{
    public class ExperienceService : BaseModelService<Experience, ExperienceDTO, ExperienceRequest>, IExperienceService
    {
        private readonly IExperienceRepository _experienceRepository;
      
        public ExperienceService(IExperienceRepository experienceRepository) : base(experienceRepository)
        {
            _experienceRepository = experienceRepository;
        
        }

 

        public async Task<Experience> RegisterExperienceAsync(ExperienceCreateRequest request)
        {
            try
            {
                var experience = new ExperienceBuilder()
                    .WithBasicInfo(request)
                    .WithInstitution(request.Institution)
                   .WithDocuments(request.Documents)
                   .WithDevelopment(request.Developments)
                   .WithLeader(request.Leaders)
                  .WithObjective(request.Objectives)
                    .WithThematics(request.ThematicLineIds)
                    .WithGrades(request.Grades)
                    .WithPopulations(request.PopulationGradeIds)
                    .WithHistory(request.HistoryExperiences, request.UserId)
                    .Build();

                await _experienceRepository.AddAsync(experience);
                return experience;
            }
            catch (DbUpdateException dbEx)
            {
                var innerMessage = dbEx.InnerException?.Message ?? dbEx.Message;
                throw new Exception($"Error al registrar la experiencia (DB): {innerMessage}", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error general al registrar la experiencia: {ex.Message}", ex);
            }
        }


        public async Task<ExperienceDetailRequest?> GetDetailByIdAsync(int id)
        {
            var experience = await _experienceRepository.GetByIdWithDetailsAsync(id);
            return experience?.ToDetailRequest();
        }



        public async Task<bool> PatchAsync(ExperienceUpdateRequest Request)
        {
            var experience = await _experienceRepository.GetByIdWithDetailsAsync(Request.ExperienceId);
            if (experience == null) return false;

            
            experience.ApplyPatch(Request);

            await _experienceRepository.UpdateAsync(experience);
            return true;
        }


        public async Task<IEnumerable<Experience>> GetExperiencesAsync(string role, int userId)
        {
            if (role == "Profesor")
                return await _experienceRepository.GetByUserIdAsync(userId);

            
            return await _experienceRepository.GetAllAsync();
        }


    }


}
