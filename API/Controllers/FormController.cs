using AutoMapper;
using Entity.Dtos;
using Entity.Models;
using Entity.Requests;
using Service.Interfaces;

namespace API.Controllers
{
    public class FormController : BaseModelController<Form, FormDTO, FormRequest>
    {
        private readonly IFormService _formService;
        private readonly IMapper _mapper;

        public FormController(IBaseModelService<Form, FormDTO, FormRequest> baseService, IFormService formService, IMapper mapper) : base(baseService, mapper)
        {
            _formService = formService;
            _mapper = mapper;
        }
    }
}