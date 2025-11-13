using AutoMapper;
using Entity.Dtos;
using Entity.Models;
using Entity.Requests;

namespace Utilities.Mappers
{
   
    public class PermissionProfiles : Profile
    {
        public PermissionProfiles() : base()
        {
           
            CreateMap<PermissionDTO, Permission>().ReverseMap();

           
            CreateMap<PermissionRequest, Permission>().ReverseMap();
        }
    }
}