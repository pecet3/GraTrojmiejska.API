using GraTrojmiejska.API.Dtos;
using GraTrojmiejska.API.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace GraTrojmiejska.API.Data
{
    class DataContext: IdentityDbContext<AuthUser>
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) { }
        public DbSet<AppUser> Users => Set<AppUser>();
        public DbSet<ToDoTask> ToDoTasks => Set<ToDoTask>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
