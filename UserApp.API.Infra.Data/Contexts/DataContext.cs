using Microsoft.EntityFrameworkCore;
using UserApp.API.Domain.Entities;

namespace UserApp.API.Infra.Data.Contexts
{
    public class DataContext :DbContext
    {
        // mapeando os modelos de domínio
        public DbSet<ChildModule> ChildModules { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<RoleUser> RoleUsers { get; set; }
        public DbSet<User> Users { get; set; }

        //Sobrescrever o método OnConfiguring para definir o tipo de banco de dados do projeto
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "bd_bululukos");
        }
    }
}
