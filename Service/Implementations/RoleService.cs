using Entity.Dtos;
using Entity.Models;
using Entity.Requests;
using Repository.Interfaces;
using Service.Interfaces;

namespace Service.Implementations
{
   
    public class RoleService : BaseModelService<Role, RoleDTO, RoleRequest>, IRoleService
    {
        private readonly IRoleRepository _roleRepository;

       
        public RoleService(IRoleRepository roleRepository) : base(roleRepository)
        {
            _roleRepository = roleRepository;
        }
    }
}
