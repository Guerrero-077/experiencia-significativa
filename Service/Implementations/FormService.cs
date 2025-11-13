using Entity.Dtos;
using Entity.Models;
using Entity.Requests;
using Repository.Interfaces;
using Service.Interfaces;

namespace Service.Implementations
{
   
    public class FormService : BaseModelService<Form, FormDTO, FormRequest>,IFormService
    {
        private readonly IFormRepository _formRepository;

      
        public FormService(IFormRepository formRepository) : base(formRepository)
        {
            _formRepository = formRepository;
        }
    }
}
