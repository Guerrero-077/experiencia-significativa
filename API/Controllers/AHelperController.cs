using Entity.Dtos;
using Entity.Models;
using Entity.Requests;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public abstract class AHelperController : ControllerBase
    {
        public abstract Task<ActionResult<IEnumerable<DataSelectRequest>>> GetEnum(string enumName);
    }
}