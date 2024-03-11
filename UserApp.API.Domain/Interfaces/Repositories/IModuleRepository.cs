using UserApp.API.Domain.Entities;

namespace UserApp.API.Domain.Interfaces.Repositories
{
    public interface IModuleRepository : IBaseRepository<Module, Guid>
    {
        Module Get(string moduleName);

    }
}
