using UserApp.API.Domain.Interfaces.Repositories;
using UserApp.API.Infra.Data.Contexts;

namespace UserApp.API.Infra.Data.Repositories
{
    public class UnitOfWork : IUnityOfWork
    {
        private readonly DataContext? _dataContext;

        public UnitOfWork(DataContext? dataContext)
        {
            _dataContext = dataContext;
        }

        public IChildModuleRepository ChildModuleRepository => throw new NotImplementedException();

        public IModuleRepository ModuleRepository => throw new NotImplementedException();

        public IPermissionRepository PermissionRepository => throw new NotImplementedException();

        public IRolePermissionRepository RolePermissionRepository => throw new NotImplementedException();

        public IRoleRepository RoleRepository => throw new NotImplementedException();

        public IRoleUserRepository RoleUserRepository => throw new NotImplementedException();

        public IUserRepository UserRepository => throw new NotImplementedException();

        public void SaveChanges()
        {
            _dataContext?.SaveChanges();
        }

        public void Dispose()
        {
            _dataContext?.Dispose();
        }
    }
}
