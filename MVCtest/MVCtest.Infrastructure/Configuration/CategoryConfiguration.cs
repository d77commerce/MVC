using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCtest.Infrastructure.Models;

namespace MVCtest.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CreateCategory());
        }
        private List<Category> CreateCategory()
        {
            var categories = new List<Category>()

            {
                new Category()
                {
                    Id = 1,
                    Name = "One",
                    DisplayOrder = "Retro",
                    CreatedTime = DateTime.Now,
                   
                    isDeleted = false
                },
                new Category()
                {
                    Id = 2,
                    Name = "Two",
                    DisplayOrder = "Onicks",
                    CreatedTime = DateTime.Now,
                   
                    isDeleted = false
                }
            };

            return categories;
        }
    }
}
