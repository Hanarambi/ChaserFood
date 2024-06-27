using ChaserFood.Models;
using Microsoft.EntityFrameworkCore;

namespace ChaserFood.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<Available> Availables { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<Purchased> Purchases { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Donor> Donors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Donor>().ToTable("individuals", "donor");
            // Add more mappings here as needed
        }
    }
}
