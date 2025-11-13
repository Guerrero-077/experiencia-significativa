using AutoMapper;
using Entity.Dtos;
using Entity.Models;
using Entity.Requests;
using Service.Interfaces;

namespace API.Controllers
{
    public class ModuleController : BaseModelController<Module, ModuleDTO, ModuleRequest>
    {
        private readonly IModuleService _moduleService;
        private readonly IMapper _mapper;

        public ModuleController(IBaseModelService<Module, ModuleDTO, ModuleRequest> baseService, IModuleService service, IMapper mapper) : base(baseService, mapper)
        {
            _moduleService = service;
            _mapper = mapper;
        }
    }
}
