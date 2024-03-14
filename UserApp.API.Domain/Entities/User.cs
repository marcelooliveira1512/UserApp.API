namespace UserApp.API.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool Active { get; set; }
        public bool EmailConfirmed { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }

        //Role User TEM MUITOS Users
        public List<RoleUser>? RoleUsers { get; set; }

    }

}
