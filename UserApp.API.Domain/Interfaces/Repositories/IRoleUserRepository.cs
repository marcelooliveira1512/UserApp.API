using UserApp.API.Domain.Entities;

namespace UserApp.API.Domain.Interfaces.Repositories
{
    public interface IRoleUserRepository : IBaseRepository<RoleUser>
    {
        List<RoleUser> GetByRoleId(Guid roleId);
        List<RoleUser> GetByUserId(Guid userId);
    }
}
