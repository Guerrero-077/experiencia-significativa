using Entity.Dtos;
using Entity.Models;
using Entity.Requests;

namespace Repository.Interfaces
{

    public interface IRoleRepository : IBaseModelRepository<Role, RoleDTO, RoleRequest>
    {
        Task<Role> GetByNameRol(string roleName);

    }
}
