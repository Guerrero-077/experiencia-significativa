using Entity.Dtos;
using Entity.Models;
using Entity.Requests;

namespace Repository.Interfaces
{
  
    public interface IFormModuleRepository : IBaseModelRepository<FormModule, FormModuleDTO, FormModuleRequest>
    {
    }
}
