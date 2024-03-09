namespace UserApp.API.Domain.Entities
{
    public class Permission
    {
        public Guid Id { get; set; }
        public Guid? ChildModuleId { get; set; }
        public bool? Create { get; set; }
        public bool? Update { get; set; }
        public bool? Delete { get; set; }
        public bool? Read { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }

        //Cada Permission TEM 1 Child Module
        public ChildModule? ChildModule { get; set; }

        //Role Permission TEM MUITAS Permissions
        public List<RolePermission>? RolePermissions { get; set; }

    }
}
