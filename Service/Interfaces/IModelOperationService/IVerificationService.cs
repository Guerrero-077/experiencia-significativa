using Entity.Dtos.ModuleOperation;
using Entity.Dtos.ModuleOperational;
using Entity.Models.ModuleOperation;
using Entity.Requests.ModuleOperation;

namespace Service.Interfaces.ModelOperationService
{
    public interface IDevelopmentService : IBaseModelService<Development, DevelopmentDTO, DevelopmentRequest>
    {
    }
}
