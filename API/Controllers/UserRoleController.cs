using AutoMapper;
using Entity.Dtos;
using Entity.Models;
using Entity.Requests;
using Service.Interfaces;

namespace API.Controllers
{
    public class UserRoleController : BaseModelController<UserRole, UserRoleDTO, UserRoleRequest>
    {
        private readonly IUserRoleService _userRolService;
        private readonly IMapper _mapper;

        public UserRoleController(IBaseModelService<UserRole, UserRoleDTO, UserRoleRequest> baseService, IUserRoleService service, IMapper mapper) : base(baseService, mapper)
        {
            _userRolService = service;
            _mapper = mapper;
        }
    }
}
