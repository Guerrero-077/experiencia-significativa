using Entity.Models;
using Entity.Dtos;
using Entity.Requests;

namespace Service.Interfaces
{
    
    public interface IPermissionService : IBaseModelService<Permission, PermissionDTO, PermissionRequest>
    {
    }
}
