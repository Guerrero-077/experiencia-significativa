using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Requests.EntityDataRequest;
using Entity.Requests.ModuleGeographic;

namespace Entity.Requests.EntityUpdateRequest
{
    public class ExperienceUpdateRequest
    {
        public int ExperienceId { get; set; }
        public ExperienceInfoRequest ExperienceInfo { get; set; }
        public InstitutionInfoRequest InstitutionInfo { get; set; }
        public List<CriteriaUpdateRequest> CriteriaUpdate { get; set; }

     


    }
}
