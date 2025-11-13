using System.ComponentModel.DataAnnotations;
using Entity.Requests.EntityCreateRequest;
using Entity.Requests.EntityDataRequest;
using Entity.Requests.EntityUpdateRequest;

namespace Entity.Requests.EntityDetailRequest
{
    public class ExperienceDetailRequest
    {
        [Required(ErrorMessage = "El ExperienceId es obligatorio")]
        public int ExperienceId { get; set; }

        public ExperienceInfoRequest ExperienceInfo { get; set; }
        
        public InstitutionInfoRequest InstitutionInfo { get; set; }
        public List<DocumentDetailRequest> DocumentInfo { get; set; } = new();

        public List<CriteriaDetailRequest> CriteriasDetail { get; set; } = new();



    }
}
