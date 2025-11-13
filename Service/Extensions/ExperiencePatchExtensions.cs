using Entity.Models.ModuleGeographic;
using Entity.Models.ModuleOperation;
using Entity.Requests.EntityUpdateRequest;

namespace Service.Extensions 
{
    /// <summary>
    /// Clase estática que contiene métodos de extensión para aplicar cambios parciales (PATCH) 
    /// a la entidad <see cref="Experience"/> a partir de un objeto <see cref="ExperiencePatchDTO"/>.
    /// </summary>
    public static class ExperiencePatchExtensions
    {
        /// <summary>
        /// Aplica los cambios enviados en un <see cref="ExperiencePatchDTO"/> sobre la entidad <see cref="Experience"/>.
        /// Solo actualiza los valores que no son nulos o vacíos.
        /// </summary>
        /// <param name="experience">Entidad <see cref="Experience"/> existente en la base de datos.</param>
        /// <param name="dto">Objeto con los nuevos valores a actualizar parcialmente.</param>
        public static void ApplyPatch(this Experience experience, ExperienceUpdateRequest request)
        {
            if (experience == null || request == null) return;

       
            if (request.ExperienceInfo != null)
            {
                // Nombre de la experiencia
                if (!string.IsNullOrWhiteSpace(request.ExperienceInfo.NameExperiences))
                    experience.NameExperiences = request.ExperienceInfo.NameExperiences;


                if (request.ExperienceInfo.Leaders != null && request.ExperienceInfo.Leaders.Any())
                {
                    experience.Leaders = request.ExperienceInfo.Leaders
                        .Select(l => new Leader
                        {
                           
                            NameLeaders = l.NameLeaders,
                            
                        })
                        .ToList();
                }

                // Estado de la experiencia (si no es 0)
                if (request.ExperienceInfo.StateExperienceId is int stateExperience)
                    experience.StateExperienceId = stateExperience;
            }

           
            if (request.InstitutionInfo != null && experience.Institution != null)
            {
                // Nombre de la institución
                if (!string.IsNullOrWhiteSpace(request.InstitutionInfo.Name))
                    experience.Institution.Name = request.InstitutionInfo.Name;

                // Departamentos 
                if (request.InstitutionInfo.Departamentes != null && request.InstitutionInfo.Departamentes.Any())
                    experience.Institution.Departaments = request.InstitutionInfo.Departamentes
                        .Select(d => new Departament { Name = d.Name })
                        .ToList();

                // Municipios 
                if (request.InstitutionInfo.Municipalities != null && request.InstitutionInfo.Municipalities.Any())
                    experience.Institution.Municipalitis = request.InstitutionInfo.Municipalities
                        .Select(m => new Municipality { Name = m.Name })
                        .ToList();

                // Código DANE
                if (!string.IsNullOrWhiteSpace(request.InstitutionInfo.CodeDane))
                    experience.Institution.CodeDane = request.InstitutionInfo.CodeDane;
            }

          
            if (request.CriteriaUpdate != null && experience.Evaluations != null)
            {
                foreach (var criteriaRequest in request.CriteriaUpdate)
                {
                    // Busca un criterio de evaluación que coincida en ID y que esté activo
                    var evaluationCriteria = experience.Evaluations
                        .SelectMany(ev => ev.EvaluationCriterias ?? new List<EvaluationCriteria>())
                        .FirstOrDefault(ec => ec.Criteria != null
                                              && ec.Criteria.Id == criteriaRequest.Id
                                              && ec.Evaluation.State == true);

                    // Si encuentra el criterio y tiene un valor válido, actualiza el comentario
                    if (evaluationCriteria != null && !string.IsNullOrWhiteSpace(criteriaRequest.EvaluationValue))
                    {
                        evaluationCriteria.Evaluation.Comments = criteriaRequest.EvaluationValue;
                    }
                }
            }
        }
    }
}


