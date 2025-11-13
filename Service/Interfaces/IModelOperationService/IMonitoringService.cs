using Entity.Dtos.ModuleOperation;
using Entity.Models.ModuleOperation;
using Entity.Requests.ModuleOperation;

namespace Service.Interfaces.ModelOperationService
{
    public interface IMonitoringService : IBaseModelService<Monitoring, MonitoringDTO, MonitoringRequest>
    {
    }
}
