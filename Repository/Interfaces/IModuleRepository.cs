using Entity.Dtos;
using Entity.Models;
using Entity.Requests;

namespace Repository.Interfaces
{
   
   
    public interface IBaseModuleRepository : IBaseModelRepository<Module, ModuleDTO, ModuleRequest>
    {

    }
}
