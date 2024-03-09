namespace UserApp.API.Domain.Entities
{
    public class RoleUser
    {
        public Guid Id { get; set; }
        public Guid? RoleId { get; set; }
        public Guid? UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }


        //Cada RoleUser TEM 1 Role
        public Role? Role { get; set; }

        //Cada RoleUser TEM 1 User
        public User? User { get; set; }
    }

}
