
using Entity.Dtos.ModuleOperational;
using Entity.Models.ModuleOperation;
using Entity.Requests.EntityCreateRequest;
using Entity.Requests.EntityDataRequest;
using Entity.Requests.EntityDetailRequest;
using Entity.Requests.EntityUpdateRequest;
using Entity.Requests.ModuleOperation;

namespace Service.Interfaces.ModelOperationService
{
    public interface IExperienceService : IBaseModelService<Experience, ExperienceDTO,ExperienceRequest>
    {

        Task<bool> PatchAsync(ExperienceUpdateRequest Request);
        Task<ExperienceDetailRequest?> GetDetailByIdAsync(int id);
        Task<Experience> RegisterExperienceAsync(ExperienceCreateRequest Request);

        Task<IEnumerable<Experience>> GetExperiencesAsync(string role, int userId);
    }
}
