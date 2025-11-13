using AutoMapper;
using Entity.Context;
using Entity.Dtos;
using Entity.Models;
using Entity.Requests;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repository.Interfaces;
using Utilities.Helper;

namespace Repository.Implementations
{
  
    public class RoleRepository : BaseModelRepository<Role, RoleDTO, RoleRequest>,IRoleRepository
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly IHelper<Role, RoleDTO> _helperRepository;

        public RoleRepository(ApplicationContext context, IMapper mapper, IConfiguration configuration, IHelper<Role, RoleDTO> helperRepository) : base(context, mapper, configuration, helperRepository)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
            _helperRepository = helperRepository;
        }

        public async Task<Role> GetByNameRol(string roleName)
        {
            return await _context.Roles.FirstOrDefaultAsync(r => r.Name == roleName);
        }







    }
}
