namespace UserApp.API.Domain.Interfaces.Repositories
{
    public interface IUnityOfWork : IDisposable
    {
        IChildModuleRepository ChildModuleRepository { get; }
        IModuleRepository ModuleRepository { get; }
        IPermissionRepository PermissionRepository { get; }
        IRolePermissionRepository RolePermissionRepository { get; }
        IRoleRepository RoleRepository { get; }
        IRoleUserRepository RoleUserRepository {  get; }
        IUserRepository UserRepository { get; }

        void SaveChanges();
    }
}
