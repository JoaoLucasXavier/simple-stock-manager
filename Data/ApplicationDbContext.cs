using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using simple_stock_manager.Models;

namespace simple_stock_manager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<CustomerAddress> CustomersAddress { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SupplierAddress> SuppliersAddress { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Shopping> Shopping { get; set; }
    }
}
