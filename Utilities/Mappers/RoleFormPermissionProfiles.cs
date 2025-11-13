using AutoMapper;
using Entity.Dtos;
using Entity.Models;
using Entity.Requests;

namespace Utilities.Mappers
{
  
    public class RoleFormPermissionProfiles : Profile
    {
        public RoleFormPermissionProfiles() : base()
        {

            CreateMap<RoleFormPermissionDTO, RoleFormPermission>().ReverseMap();

            
            CreateMap<RoleFormPermissionRequest, RoleFormPermission>().ReverseMap();
        }
    }
}