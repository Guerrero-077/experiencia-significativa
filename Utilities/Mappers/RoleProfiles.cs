using AutoMapper;
using Entity.Dtos;
using Entity.Models;
using Entity.Requests;

namespace Utilities.Mappers
{
   
    public class RoleProfiles : Profile
    {
        public RoleProfiles() : base()
        {
       
            CreateMap<RoleDTO, Role>().ReverseMap();

          
            CreateMap<RoleRequest, Role>().ReverseMap();
        }
    }
}