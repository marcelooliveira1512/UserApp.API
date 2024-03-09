namespace UserApp.API.Domain.Entities
{
    public class ChildModule
    {
        public Guid Id { get; set; }
        public Guid? ModuleId { get; set; }
        public string? ChildModuleName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }

        //Child Module TEM MUITAS Permissions
        public List<Permission>? Permissions { get; set; }

        //Cada Child Module TEM 1 Module
        public Module? Module { get; set; }
    }
}
