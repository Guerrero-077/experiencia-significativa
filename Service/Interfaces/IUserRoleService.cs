using Entity.Dtos;
using Entity.Models;
using Entity.Requests;

namespace Service.Interfaces
{
    
    public interface IUserRoleService : IBaseModelService<UserRole, UserRoleDTO, UserRoleRequest>
    {
    }
}
