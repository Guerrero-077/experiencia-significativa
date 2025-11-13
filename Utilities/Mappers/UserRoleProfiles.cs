using AutoMapper;
using Entity.Dtos;
using Entity.Models;
using Entity.Requests;

namespace Utilities.Mappers
{
    

    public class UserRoleProfiles : Profile
    {
        public UserRoleProfiles() : base()
        {
         
            CreateMap<UserRoleDTO, UserRole>().ReverseMap();

            CreateMap<UserRoleRequest, UserRole>().ReverseMap();
        }
    }
}