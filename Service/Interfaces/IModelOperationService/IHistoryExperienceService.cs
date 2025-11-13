
using Entity.Dtos.ModuleOperational;
using Entity.Models.ModuleOperation;
using Entity.Requests;
using Entity.Requests.ModuleOperation;

namespace Service.Interfaces.ModelOperationService
{
    public interface IHistoryExperienceService : IBaseModelService<HistoryExperience, HistoryExperienceDTO, HistoryExperienceRequest>
    {

        Task<object> GetTrackingSummaryAsync(QueryFilterRequest filters);



    }
}
