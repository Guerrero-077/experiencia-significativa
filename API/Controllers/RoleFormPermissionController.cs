using AutoMapper;
using Entity.Dtos;
using Entity.Models;
using Entity.Requests;
using Service.Interfaces;

namespace API.Controllers
{
    public class RoleFormPermissionController : BaseModelController<RoleFormPermission, RoleFormPermissionDTO, RoleFormPermissionRequest>
    {
        private readonly IRoleFormPermissionService _roleFormPermissionService;
        private readonly IMapper _mapper;

        public RoleFormPermissionController(IBaseModelService<RoleFormPermission, RoleFormPermissionDTO, RoleFormPermissionRequest> baseService, IRoleFormPermissionService service, IMapper mapper) : base(baseService, mapper)
        {
            _roleFormPermissionService = service;
            _mapper = mapper;
        }
    }
}
