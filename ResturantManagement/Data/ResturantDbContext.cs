using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ResturantManagement.Models.Entities;

namespace ResturantManagement.Data
{
    public class ResturantDbContext : DbContext
    {
        public ResturantDbContext(DbContextOptions<ResturantDbContext> options) : base(options)
        {
        }

        public DbSet<MenuItem> menuItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Table> tables { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Category 1-- - *MenuItem
            //Order 1-- - *OrderItem * ---1 MenuItem
            //Customer 1-- - *Order
            //Table 1-- - *Order
            //Order 1-- - 1 Payment

            
        }
    }
}
