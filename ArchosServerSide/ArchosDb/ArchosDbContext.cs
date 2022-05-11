﻿using ArchosServerSide.Repositories.Entities;
using Microsoft.EntityFrameworkCore;

namespace ArchosServerSide.ArchosDb
{
    public class ArchosDbContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=ArchosDb2;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne(e => e.Employee)
                .WithMany(e => e.Orders)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.Client)
                .WithOne(e => e.Address)
                .OnDelete(DeleteBehavior.Cascade);

         
        }
    }
}
