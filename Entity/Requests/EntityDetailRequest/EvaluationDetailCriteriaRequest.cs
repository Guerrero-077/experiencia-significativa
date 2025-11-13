using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Requests.EntityDetailRequest
{
    public class EvaluationDetailCriteriaRequest
    {
        public int Score { get; set; }
        public int EvaluationId { get; set; }
        public int CriteriaId { get; set; }

       

        public string DescriptionContribution { get; set; } = string.Empty;
    }
}
