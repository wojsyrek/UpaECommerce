using ArchosServerSide.Repositories.Entities;
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
                @"Server=(localdb)\mssqllocaldb;Database=ArchosDbMain3;Integrated Security=True");
        }

    }
}
