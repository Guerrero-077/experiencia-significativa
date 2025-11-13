namespace Entity.Models
{
 
    public class Permission : GenericModel
    {
     
        public string Description { get; set; } = string.Empty;
       
        public virtual ICollection<RoleFormPermission> RoleFormPermissions { get; set; } = new List<RoleFormPermission>();
    }
}
