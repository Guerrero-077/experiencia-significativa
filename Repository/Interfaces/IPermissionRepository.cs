using Entity.Dtos;
using Entity.Models;
using Entity.Requests;

namespace Repository.Interfaces
{
    
    public interface IPermissionRepository : IBaseModelRepository<Permission, PermissionDTO, PermissionRequest>
    {
    }
}
