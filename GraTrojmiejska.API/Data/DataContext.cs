﻿using GraTrojmiejska.API.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace GraTrojmiejska.API.Data
{
    class DataContext: IdentityDbContext<MyUser>
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) { }

        public DbSet<User> MyUsers => Set<User>();

        public DbSet<Coordinate> Coordiantes => Set<Coordinate>();
        public DbSet<MapPoint> MapPoints => Set<MapPoint>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coordinate>()
                     .ToTable("Coordinates");

            modelBuilder.Entity<Coordinate>()
                .Property(c => c.Type)
                .HasConversion<int>();

            /*  modelBuilder.Entity<Customer>()
                  .Property(c => c.SubscriptionLevel)
                  .HasConversion<string>();

              modelBuilder.Entity<SubscriptionLevel>()
                  .Property(s => s.Quality)
                  .HasConversion<string>();
  */
            base.OnModelCreating(modelBuilder);
        }
    }
}
