using AutoMapper;
using Entity.Dtos;
using Entity.Models;
using Entity.Requests;
using Service.Interfaces;

namespace API.Controllers
{
    public class RoleController : BaseModelController<Role, RoleDTO, RoleRequest>
    {
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;

        public RoleController(IBaseModelService<Role, RoleDTO, RoleRequest> baseService, IRoleService service, IMapper mapper) : base(baseService, mapper)
        {
            _roleService = service;
            _mapper = mapper;
        }
    }
}
