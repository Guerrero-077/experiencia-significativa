using Entity.Dtos;
using Entity.Models;
using Entity.Requests;

namespace Service.Interfaces
{
   
    public interface IModuleService : IBaseModelService<Module, ModuleDTO, ModuleRequest>
    {
    }
}
