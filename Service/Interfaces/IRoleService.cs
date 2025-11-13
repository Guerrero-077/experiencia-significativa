using Entity.Dtos;
using Entity.Models;
using Entity.Requests;

namespace Service.Interfaces
{
  
    public interface IRoleService : IBaseModelService<Role, RoleDTO, RoleRequest>
    {
    }
}
