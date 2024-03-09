using UserApp.API.Domain.Entities;

namespace UserApp.API.Domain.Interfaces.Repositories
{
    public interface IPermissionRepository : IBaseRepository<Permission>
    {
        Permission Get(string permissionName);
    }
}
