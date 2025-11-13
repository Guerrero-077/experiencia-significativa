using Entity.Dtos;
using Entity.Models;
using Entity.Requests;
using Repository.Interfaces;
using Service.Interfaces;

namespace Service.Implementations
{
   
    public class PermissionService : BaseModelService<Permission, PermissionDTO, PermissionRequest>, IPermissionService
    {
        private readonly IPermissionRepository _permissionRepository;

    
        public PermissionService(IPermissionRepository permissionRepository) : base(permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }
    }
}
