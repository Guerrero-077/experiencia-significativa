using AutoMapper;
using Entity.Dtos;
using Entity.Models;
using Entity.Requests;

namespace Utilities.Mappers
{
   
    public class ModuleProfiles : Profile
    {

        public ModuleProfiles() : base()
        {

          
            CreateMap<ModuleDTO, Module>().ReverseMap();

           
            CreateMap<ModuleRequest, Module>().ReverseMap();
        }
    }
}