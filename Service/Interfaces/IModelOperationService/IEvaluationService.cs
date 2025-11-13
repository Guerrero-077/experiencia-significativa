using Entity.Dtos.ModuleOperational;
using Entity.Models.ModuleOperation;
using Entity.Requests.EntityCreateRequest;
using Entity.Requests.EntityDetailRequest;
using Entity.Requests.ModuleOperation;

namespace Service.Interfaces.ModelOperationService
{
    public interface IEvaluationService : IBaseModelService<Evaluation, EvaluationDTO, EvaluationRequest>
    {
        Task<EvaluationDetailRequest> CreateEvaluationAsync(EvaluationCreateRequest request);
    }
}
