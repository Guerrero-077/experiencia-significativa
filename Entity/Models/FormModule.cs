namespace Entity.Models
{

    public class FormModule : BaseModel
    {
        public int FormId { get; set; }

  
        public int ModuleId { get; set; }
 
        public virtual Form Form { get; set; } = null!;

      
        public virtual Module Module { get; set; } = null!;
    }
}
