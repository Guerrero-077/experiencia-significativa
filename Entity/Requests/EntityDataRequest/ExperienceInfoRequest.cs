using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Requests.EntityUpdateRequest;
using Entity.Requests.ModuleOperation;

namespace Entity.Requests.EntityDataRequest
{
    public  class ExperienceInfoRequest
    {
        public string NameExperiences { get; set; } = string.Empty;
        public DateTime Developmenttime { get; set; }
        public int StateExperienceId { get; set; }
        public string EvaluationResult { get; set; }
        public List<LeaderUpdateRequest> Leaders { get; set; }
       
    }
}
