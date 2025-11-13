using Entity.Dtos.ModuleOperational;
using Entity.Requests.ModuleOperation;
using Entity.Models.ModuleOperation;

namespace Service.Interfaces.ModelOperationService
{
    public interface IDocumentService : IBaseModelService<Document, DocumentDTO, DocumentRequest>
    {
        //Task SaveChangesAsync();
    }
}
