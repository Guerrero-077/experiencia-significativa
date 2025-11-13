using Entity.Dtos.ModuleOperation;
using Entity.Models.ModuleOperation;
using Entity.Requests.ModuleOperation;

namespace Repository.Interfaces.IModuleOperationRepository
{
    public interface IMonitoringRepository : IBaseModelRepository<Monitoring, MonitoringDTO, MonitoringRequest>
    {
    }
}
