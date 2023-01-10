using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCtest.Configuration;
using MVCtest.Infrastructure.Configuration;
using MVCtest.Infrastructure.Models;

namespace MVCtest.Data
{
    public class ApplicationDbContext : IdentityDbContext
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
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new WorkerConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new CoverConfiguration());
            base.OnModelCreating(builder);
        }
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Worker> Workers { get; set; } = null!;
        public DbSet<Cover> Covers { get; set; }=null!;
        public DbSet<Product> Products { get; set; } = null!;

    }
}