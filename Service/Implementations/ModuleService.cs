using Entity.Dtos;
using Entity.Models;
using Entity.Requests;
using Repository.Interfaces;
using Service.Interfaces;

namespace Service.Implementations
{
    
    public class ModuleService : BaseModelService<Module, ModuleDTO, ModuleRequest>, IModuleService
    {
        private readonly IBaseModuleRepository _moduleRepository;

     
        public ModuleService(IBaseModuleRepository moduleRepository) : base(moduleRepository)
        {
            _moduleRepository = moduleRepository;
        }
    }
}
