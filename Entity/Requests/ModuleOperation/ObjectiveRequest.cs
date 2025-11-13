

using Entity.Models.ModuleOperation;

namespace Entity.Requests.ModuleOperation
{
    public class ObjectiveRequest : BaseRequest
    {
        public string DescriptionProblem { get; set; } = string.Empty;
        public string ObjectiveExperience { get; set; } = string.Empty;
        public string EnfoqueExperience { get; set; } = string.Empty;
        public string Methodologias { get; set; } = string.Empty;
        public string InnovationExperience { get; set; } = string.Empty;
     

        public List<SupportInformationRequest> SupportInformations { get; set; }
        public List<MonitoringRequest> Monitorings { get; set; } 




    }
}
