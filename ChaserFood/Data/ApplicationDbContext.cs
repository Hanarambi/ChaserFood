using ChaserFood.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChaserFood.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<Available> Availables { get; set; }
        public DbSet<Brand> Brands { get; set; }
        // public DbSet<Category> Categories { get; set; }
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
        public DbSet<NewClientModel> NewClients { get; set; }
        public DbSet<StudentModel> StudentModels { get; set; }
        public DbSet<ProductRequest> ProductRequests { get; set; }
        public DbSet<ProductSelection> ProductSelections { get; set; }
        public DbSet<DonkeyDonor> DonkeyDonors { get; set; }

        public DbSet<NewClientModel> NewClients { get; set; }
        public DbSet<StudentModel> StudentModels { get; set; }
        public object Items { get; internal set; }
        public DbSet<ProductRequest> ProductRequests { get; set; }
        public DbSet<ProductSelection> ProductSelections { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Map the Donor entity to a specific table and schema
            modelBuilder.Entity<Donor>().ToTable("individuals", "donor");

            // Configure Identity tables if needed
            modelBuilder.Entity<IdentityUser>(entity =>
            {
                entity.ToTable(name: "AspNetUsers");
            });

            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "AspNetRoles");
            });

            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("AspNetUserRoles");
            });

            modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("AspNetUserClaims");
            });

            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("AspNetUserLogins");
            });

            modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("AspNetRoleClaims");
            });

            modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("AspNetUserTokens");
            });

            // Configure the DonkeyDonor and InventoryItem relationship
            modelBuilder.Entity<InventoryItem>()
                .HasOne(i => i.Donor)
                .WithMany(d => d.Donations)
                .HasForeignKey(i => i.DonorId);
        }
    }
}
  