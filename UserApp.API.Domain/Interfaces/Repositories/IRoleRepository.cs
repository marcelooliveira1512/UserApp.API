using UserApp.API.Domain.Entities;

namespace UserApp.API.Domain.Interfaces.Repositories
{
    public interface IRoleRepository : IBaseRepository<Role, Guid>
    {
        Role Get(string roleName);

    }
}
