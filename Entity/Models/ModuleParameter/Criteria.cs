
using Entity.Models.ModuleOperation;

namespace Entity.Models.ModelosParametros
{
    public class Criteria : GenericModel
    {
        public string DescriptionContribution { get; set; } = string.Empty;
        public string DescruotionType { get; set; } = string.Empty;

        public ICollection<EvaluationCriteria> EvaluationCriterias { get; set; } = new List<EvaluationCriteria>();
    }
}
