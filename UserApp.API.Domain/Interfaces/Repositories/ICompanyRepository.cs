using UserApp.API.Domain.Entities;

namespace UserApp.API.Domain.Interfaces.Repositories
{
    public interface ICompanyRepository : IBaseRepository<Company, Guid>
    {
        Company Get(string companyName);
    }
}
