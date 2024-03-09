namespace UserApp.API.Domain.Entities
{
    public class Module
    {
        public Guid Id { get; set; }
        public string? ModuleName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }

        //Module TEM MUITAS Child Module
        public List<ChildModule>? ChildModules { get; set; }
    }

}
