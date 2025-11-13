using AutoMapper;
using Entity.Dtos;
using Entity.Models;
using Entity.Requests;
using Service.Interfaces;

namespace API.Controllers
{
    public class PermissionController : BaseModelController<Permission, PermissionDTO, PermissionRequest>
    {
        private readonly IPermissionService _permissionService;
        private readonly IMapper _mapper;

        public PermissionController(IBaseModelService<Permission, PermissionDTO, PermissionRequest> baseService, IPermissionService service, IMapper mapper) : base(baseService, mapper)
        {
            _permissionService = service;
            _mapper = mapper;
        }
    }
}
