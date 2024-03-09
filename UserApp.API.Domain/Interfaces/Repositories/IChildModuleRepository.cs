using UserApp.API.Domain.Entities;

namespace UserApp.API.Domain.Interfaces.Repositories
{
    public interface IChildModuleRepository : IBaseRepository<ChildModule>
    {
        List<ChildModule> GetByModuleId(Guid moduleId);
        ChildModule Get(string childModuleName);
    }
}
