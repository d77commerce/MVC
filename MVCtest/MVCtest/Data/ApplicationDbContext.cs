
using Microsoft.EntityFrameworkCore;
using MVCtest.Models;

namespace MVCtest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
      protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>()
                .Property(x => x.isDeleted)
                .HasDefaultValue(false);
            base.OnModelCreating(builder);
        }
        public DbSet<Category> Categories { get; set; }
    }
}