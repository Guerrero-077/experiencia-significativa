using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.ModelosParametro
{
    public class CriteriaDTO : BaseDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string DescriptionContribution { get; set; } = string.Empty;
        public string DescruotionType { get; set; } = string.Empty;
        public string? EvaluationValue { get; set; }
    }
}
