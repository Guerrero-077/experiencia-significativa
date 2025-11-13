using Entity.Dtos.ModuleOperational;
using Entity.Models.ModuleOperation;
using Entity.Requests.ModuleOperation;

namespace Repository.Interfaces.IModuleOperationRepository
{
    public interface IEvaluationCriteriaRepository : IBaseModelRepository<EvaluationCriteria, EvaluationCriteriaDTO, EvaluationCriteriaRequest>
    {
    }
}
