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
        public DbSet<Student> Students { get; set; }
        public DbSet<Donor> Donors { get; set; } // Add this line

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Donor>().ToTable("individuals", "donor");
        }
    }
}
