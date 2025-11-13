using AutoMapper;
using Entity.Context;
using Entity.Dtos;
using Entity.Models;
using Entity.Requests;
using Microsoft.Extensions.Configuration;
using Repository.Interfaces;
using Utilities.Helper;

namespace Repository.Implementations
{
   
    public class PermissionRepository : BaseModelRepository<Permission, PermissionDTO, PermissionRequest>, IPermissionRepository
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly IHelper<Permission, PermissionDTO> _helperRepository;

        public PermissionRepository(ApplicationContext context, IMapper mapper, IConfiguration configuration, IHelper<Permission, PermissionDTO> helperRepository) : base(context, mapper, configuration, helperRepository)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
            _helperRepository = helperRepository;
        }
    }
}
