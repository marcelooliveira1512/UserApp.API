﻿using UserApp.API.Domain.Entities;

namespace UserApp.API.Domain.Interfaces.Repositories
{
    public interface IRolePermissionRepository : IBaseRepository<RolePermission>
    {
        List<RolePermission> GetByRoleId(Guid roleId);

        List<RolePermission> GetByPermissionId(Guid permissionId);
    }
}
