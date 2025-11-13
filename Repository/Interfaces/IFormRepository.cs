using Entity.Dtos;
using Entity.Models;
using Entity.Requests;

namespace Repository.Interfaces
{
  
    public interface IFormRepository : IBaseModelRepository<Form, FormDTO, FormRequest>
    {
    }
}
