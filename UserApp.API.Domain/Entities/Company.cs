namespace UserApp.API.Domain.Entities
{
    public class Company
    {
        public Guid Id { get; set; }
        public string? CompanyName { get; set;}
        public Guid? ParentCompanyId { get; set;}
        public string? FantasyName { get; set; }
        public Guid? ImgLogo { get; set; }
        public string? Cnpj { get; set; }
        public string? InscMunicipal { get; set; }
        public string? InscEstadual { get; set; }
        public string? Cnae { get; set; }
        public byte? Crt { get; set; }
        public string? Email { get; set; }
        public string? Url { get; set; }
        public string? FoneNumber1 { get; set; }
        public string? FoneNumber2 { get; set; }
        public string? Zipcode { get; set; }
        public string? Address { get; set;}
        public string? Number { get; set; }
        public string? Complement { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }


        //Cada Company tem TEM MUITOS Users
        public List<User>? Users { get; set; }
    }
}
