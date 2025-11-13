using Entity.Dtos.ModuleOperational;
using Entity.Models.ModuleOperation;
using Entity.Requests.ModuleOperation;

namespace Repository.Interfaces.IModuleOperationRepository
{
    public interface IExperienceRepository : IBaseModelRepository<Experience, ExperienceDTO, ExperienceRequest>
    {
        Task<Experience> AddAsync(Experience experience);


        Task UpdateAsync(Experience experience);

        Task<Experience?> GetByIdAsync(int id);

        Task<IEnumerable<Experience>> GetAllAsync();
        Task<IEnumerable<Experience>> GetByUserIdAsync(int userId);
        Task<Experience> GetByIdWithDetailsAsync(int experienceId);


    }
}
