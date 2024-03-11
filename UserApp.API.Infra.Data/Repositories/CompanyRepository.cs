using UserApp.API.Domain.Entities;
using UserApp.API.Domain.Interfaces.Repositories;
using UserApp.API.Infra.Data.Contexts;

namespace UserApp.API.Infra.Data.Repositories
{
    public class CompanyRepository : BaseRepository<Company, Guid>, ICompanyRepository
    {
        private readonly DataContext? _dataContext;

        public CompanyRepository(DataContext? dataContext) : base(dataContext) 
        {
            _dataContext = dataContext;
        }

        public Company Get(string companyName)
        {
            throw new NotImplementedException();
        }
    }
}
