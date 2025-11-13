using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Requests.ModulesParamer
{
    public class CriteriaRequest : BaseRequest
    {
        public string DescriptionContribution { get; set; } = string.Empty;
        public string DescruotionType { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;



    }
}
