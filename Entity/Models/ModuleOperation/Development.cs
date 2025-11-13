

namespace Entity.Models.ModuleOperation
{
    public class Development : BaseModel
    {
        public string CrossCuttingProject { get; set; } = string.Empty;
        public string Population { get; set; } = string.Empty;
        public string PedagogicalStrategies { get; set; } = string.Empty;
        public string Coverage {  get; set; } = string.Empty;
        public string CovidPandemic {  get; set; } = string.Empty;
        public int ExperienceId { get; set; }
        public virtual Experience Experience { get; set; } = null!;

    }
}
