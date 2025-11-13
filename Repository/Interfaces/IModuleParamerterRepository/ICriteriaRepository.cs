using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Dtos.ModelosParametro;
using Entity.Models.ModelosParametros;
using Entity.Requests.ModulesParamer;

namespace Repository.Interfaces.ModuleParamer
{
    public interface ICriteriaRepository : IBaseModelRepository<Criteria, CriteriaDTO, CriteriaRequest>
    { }
}
