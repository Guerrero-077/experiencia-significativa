
using Entity.Models.ModelosParametros;

namespace Entity.Models.ModuleOperation
{
    public class EvaluationCriteria : BaseModel
    {
        public int Score { get; set; }
        public int EvaluationId { get; set; }
        public int CriteriaId { get; set; }
        public virtual Evaluation Evaluation { get; set; } 
        public virtual Criteria Criteria { get; set; } 
    }
}
