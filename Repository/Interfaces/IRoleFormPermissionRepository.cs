using Entity.Dtos;
using Entity.Models;
using Entity.Requests;

namespace Repository.Interfaces
{
   
    public interface IRoleFormPermissionRepository : IBaseModelRepository<RoleFormPermission, RoleFormPermissionDTO, RoleFormPermissionRequest>
    {
    }
}
