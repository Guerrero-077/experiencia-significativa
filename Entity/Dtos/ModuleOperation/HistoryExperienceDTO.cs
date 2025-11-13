using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Models.ModuleOperation;
using Entity.Models;

namespace Entity.Dtos.ModuleOperational
{
    public class HistoryExperienceDTO : BaseDTO
    {
        public string Action { get; set; } = string.Empty;
        public string TableName { get; set; } = string.Empty;
        public int ExperienceId { get; set; }
        public int UserId { get; set; }
        public int StateId { get; set; }
    }
}
