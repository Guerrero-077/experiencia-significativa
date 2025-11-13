using System.Data;
using Entity.Dtos.ModuleOperational;
using Entity.Models.ModuleOperation;
using Entity.Requests;
using Entity.Requests.ModuleOperation;

namespace Repository.Interfaces.IModuleOperationRepository
{
    public interface IHistoryExperienceRepository : IBaseModelRepository<HistoryExperience, HistoryExperienceDTO, HistoryExperienceRequest>
    {
        Task<object> GetTrackingSummaryAsync(QueryFilterRequest filters);
    }
}
