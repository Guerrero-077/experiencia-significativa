using AutoMapper;
using Entity.Dtos.ModelosParametro;
using Entity.Models.ModelosParametros;
using Entity.Requests.ModulesParamer;
using Service.Interfaces.ModuleParamer;
using Service.Interfaces;

namespace API.Controllers.ModuleParamer
{
    public class LineThematicController : BaseModelController<LineThematic, LineThematicDTO, LineThematicRequest>
    {
        private readonly ILineThematicService _lineThematicService;
        private readonly IMapper _mapper;

        public LineThematicController(IBaseModelService<LineThematic, LineThematicDTO, LineThematicRequest> baseService, ILineThematicService service, IMapper mapper) : base(baseService, mapper)
        {
            _lineThematicService = service;
            _mapper = mapper;

        }
    }
    }

