namespace UserApp.API.Domain.Entities
{
    public class RolePermission
    {
        public Guid Id { get; set; }
        public Guid? RoleId { get; set; }
        public Guid? PermissionId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }


        //Cada RolePermission TEM 1 Role
        public Role? Role { get; set; }

        //Cada RolePermission TEM 1 Permission
        public Permission? Permission { get; set; }

    }

}
