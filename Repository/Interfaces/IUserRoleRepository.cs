using Entity.Dtos;
using Entity.Models;
using Entity.Requests;

namespace Repository.Interfaces
{
    
    public interface IUserRoleRepository : IBaseModelRepository<UserRole, UserRoleDTO, UserRoleRequest>
    {
    }
}
