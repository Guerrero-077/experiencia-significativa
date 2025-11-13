using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Dtos.ModuleOperation;
using Entity.Models.ModuleOperation;
using Entity.Requests.ModuleOperation;
using Service.Implementations;

namespace Service.Interfaces.ModelOperationService
{
    public interface ISupportInformationService : IBaseModelService<SupportInformation, SupportInformationDTO, SupportInformationRequest>
    {
    }
}
