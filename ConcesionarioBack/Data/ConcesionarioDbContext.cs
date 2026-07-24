using ConcesionarioBack.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConcesionarioBack.Data
{
    public class ConcesionarioDbContext : DbContext
    {
        public ConcesionarioDbContext(DbContextOptions<ConcesionarioDbContext> options)
            : base(options) { }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }
}
