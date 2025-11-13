using AutoMapper;
using Entity.Dtos;
using Entity.Models;
using Entity.Requests;

namespace Utilities.Mappers
{
   
    public class FormModuleProfiles : Profile
    {
        public FormModuleProfiles() : base()
        {
          
            CreateMap<FormModuleDTO, FormModule>().ReverseMap();

           
            CreateMap<FormModuleRequest, FormModule>().ReverseMap();
        }
    }
}