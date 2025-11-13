using Entity.Dtos;
using Entity.Models;
using Entity.Requests;
using Repository.Interfaces;
using Service.Interfaces;

namespace Service.Implementations
{
   
    public class UserRoleService : BaseModelService<UserRole, UserRoleDTO, UserRoleRequest>, IUserRoleService
    {
        private readonly IUserRoleRepository _userRolRepository;

     
        public UserRoleService(IUserRoleRepository userRolRepository) : base(userRolRepository)
        {
            _userRolRepository = userRolRepository;
        }
    }
}
