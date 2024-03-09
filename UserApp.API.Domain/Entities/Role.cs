namespace UserApp.API.Domain.Entities
{
    public class Role
    {
        public Guid Id { get; set; }
        public string? RoleName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }

        //Role Permission TEM MUITAS Roles
        public List<RolePermission>? RolePermissions { get; set; }

        //Role User TEM MUITAS Roles
        public List<RoleUser>? RoleUsers { get; set; }

    }

}
