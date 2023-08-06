using Microsoft.EntityFrameworkCore;
using ResourceAggregator.Models;

namespace ResourceAggregator.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Resource> Resources { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the relationships between entities (if any) here

            // Example: One-to-Many relationship between Resource and Category
            modelBuilder.Entity<Resource>()
                .HasOne(r => r.Category)
                .WithMany(c => c.Resources)
                .HasForeignKey(r => r.CategoryId)
                .OnDelete(DeleteBehavior.Cascade); // Adjust the delete behavior as per your requirement
        }
    }
}
