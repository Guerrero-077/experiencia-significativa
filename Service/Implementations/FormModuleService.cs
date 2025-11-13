using Entity.Dtos;
using Entity.Models;
using Entity.Requests;
using Repository.Interfaces;
using Service.Interfaces;

namespace Service.Implementations
{
   
    public class FormModuleService : BaseModelService<FormModule, FormModuleDTO, FormModuleRequest>, IFormModuleService
    {
        private readonly IFormModuleRepository _formModuleRepository;

        public FormModuleService(IFormModuleRepository formModuleRepository) : base(formModuleRepository)
        {
            _formModuleRepository = formModuleRepository;
        }

    }
}
