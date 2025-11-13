using AutoMapper;
using Entity.Dtos;
using Entity.Models;
using Entity.Requests;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace API.Controllers
{
    public class PersonController : BaseModelController<Person, PersonDTO, PersonRequest>
    {
        private readonly IPersonService _personService;
        private readonly IMapper _mapper;

        public PersonController(IBaseModelService<Person, PersonDTO, PersonRequest> baseService, IPersonService service, IMapper mapper)
            : base(baseService, mapper)
        {
            _personService = service;
            _mapper = mapper;
        }


        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] UserRegisterRequest request)
        {
            try
            {
                var result = await _personService.CreatePersonAsync(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}








    