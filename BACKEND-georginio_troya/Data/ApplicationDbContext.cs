using BACKEND_georginio_troya.Models;
using Microsoft.EntityFrameworkCore;


namespace BACKEND_georginio_troya.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // RELACIONES
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.OrderHeaders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerId);

            modelBuilder.Entity<OrderHeader>()
                .HasMany(o => o.Deliveries)
                .WithOne(d => d.Order)
                .HasForeignKey(d => d.OrderId);
        }
    }
}