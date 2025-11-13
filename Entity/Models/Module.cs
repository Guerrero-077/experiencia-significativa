namespace Entity.Models
{
   
    public class Module : BaseModel
    {
      
        public string Name { get; set; } = string.Empty;
      
        public string Description { get; set; } = string.Empty;
     
        public virtual ICollection<FormModule> FormModules { get; set; } = new List<FormModule>();
    }
}