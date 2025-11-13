using AutoMapper;
using Entity.Dtos.ModuleOperational;
using Entity.Models.ModuleOperation;
using Entity.Requests.EntityCreateRequest;
using Entity.Requests.ModuleOperation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Service.Interfaces.ModelOperationService;

namespace API.Controllers.ModuleOperationController
{
    public class EvaluationController : BaseModelController<Evaluation, EvaluationDTO, EvaluationRequest>
    {
        private readonly IEvaluationService _evaluationService;
        private readonly IMapper _mapper;
        public EvaluationController(IBaseModelService<Evaluation, EvaluationDTO, EvaluationRequest> baseService, IEvaluationService evaluationService, IMapper mapper) : base(baseService, mapper)
        {
            _evaluationService = evaluationService;
            _mapper = mapper;
        }


        [Authorize(Roles = "SUPERADMIN")] // Solo admin crea evaluaciones
        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] EvaluationCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _evaluationService.CreateEvaluationAsync(request);
            return Ok(result);
        }




    }
}
