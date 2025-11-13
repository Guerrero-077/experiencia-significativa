using Entity.Dtos.ModuleOperational;
using Entity.Models.ModuleOperation;
using Entity.Requests.ModuleOperation;

namespace Service.Interfaces.ModelOperationService
{
    public interface IInstitutionService : IBaseModelService<Institution, InstitutionDTO, InstitutionRequest>
    {
    }
}
