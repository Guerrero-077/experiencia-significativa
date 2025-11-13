using AutoMapper;
using Entity.Dtos;
using Entity.Models;
using Entity.Requests;
using Service.Interfaces;

namespace API.Controllers
{
    public class FormModuleController : BaseModelController<FormModule, FormModuleDTO, FormModuleRequest>
    {
        private readonly IFormModuleService _formModuleService;
        private readonly IMapper _mapper;

        public FormModuleController(IBaseModelService<FormModule, FormModuleDTO, FormModuleRequest> baseService, IFormModuleService formModuleService, IMapper mapper) : base(baseService, mapper)
        {
            _formModuleService = formModuleService;
            _mapper = mapper;
        }
    }
}
