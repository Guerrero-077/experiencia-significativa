using Entity.Dtos;
using Entity.Models;
using Entity.Requests;
using Repository.Interfaces;
using Service.Interfaces;

namespace Service.Implementations
{
    
    public class RoleFormPermissionService : BaseModelService<RoleFormPermission, RoleFormPermissionDTO, RoleFormPermissionRequest>, IRoleFormPermissionService
    {
        private readonly IRoleFormPermissionRepository _roleFormPermissionRepository;

      
        public RoleFormPermissionService(IRoleFormPermissionRepository roleFormPermissionRepository) : base(roleFormPermissionRepository)
        {
            _roleFormPermissionRepository = roleFormPermissionRepository;
        }
    }
}
