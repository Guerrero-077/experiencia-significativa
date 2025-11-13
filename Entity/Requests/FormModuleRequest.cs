namespace Entity.Requests
{
    public class FormModuleRequest : BaseRequest
    {
          
            public int FormId { get; set; }
            
            public int ModuleId { get; set; }
           
            public string? Form { get; set; } = null!;

          
            public string? Module { get; set; } = null!;
    }
}