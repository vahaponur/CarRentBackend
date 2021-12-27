using Entitites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Core.Utilities.FileSystem;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarRentContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = @"Server = (localdb)\MSSQLLocalDB;
            Database = CarRent;Trusted_Connection=true";
            optionsBuilder.UseSqlServer(connection);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Photo>().ToTable("CarImages");
            modelBuilder.Entity<Photo>().Property(p => p.ImagePath).HasColumnName("ImagePath");
            modelBuilder.Entity<Photo>().Property(p => p.ImagePath).HasDefaultValue(FileCRUD.savingPath + @"\def.jpg");
      
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Photo> CarImages { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
