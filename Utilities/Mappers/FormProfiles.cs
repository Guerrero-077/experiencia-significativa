using AutoMapper;
using Entity.Dtos;
using Entity.Models;
using Entity.Requests;

namespace Utilities.Mappers
{
    
    public class FormProfiles : Profile
    {
        public FormProfiles() : base()
        {

        
            CreateMap<FormDTO, Form>().ReverseMap();

          
            CreateMap<FormRequest, Form>().ReverseMap();
        }
    }
}