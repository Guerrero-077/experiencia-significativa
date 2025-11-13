using AutoMapper;
using Entity.Dtos;
using Entity.Models;
using Entity.Requests;

namespace Utilities.Mappers
{
    
    public class PersonProfiles : Profile
    {
        public PersonProfiles() : base()
        {
            
            CreateMap<PersonDTO, Person>().ReverseMap();

            CreateMap<PersonRequest, Person>().ReverseMap();
        }
    }
}