using GraTrojmiejska.API.Dtos;
using GraTrojmiejska.API.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace GraTrojmiejska.API.Data
{
    class DataContext: IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) { }

        public DbSet<ToDoTask> ToDoTasks => Set<ToDoTask>();


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AppUser>().Property(u => u.Name).IsRequired();
            builder.HasDefaultSchema("identity");
        }
    }
}
