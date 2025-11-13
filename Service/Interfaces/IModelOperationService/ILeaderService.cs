
using Entity.Dtos.ModuleOperation;
using Entity.Models.ModuleOperation;
using Entity.Requests.ModuleOperation;

namespace Service.Interfaces.ModelOperationService
{
    public interface ILeaderService : IBaseModelService<Leader, LeaderDTO, LeaderRequest>
    {
    }
}
