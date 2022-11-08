using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MVCtest.Models;

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
                    WorkerId = 1,
                    isDeleted = false
                },
                new Category()
                {
                    Id = 2,
                    Name = "Two",
                    DisplayOrder = "Onicks",
                    CreatedTime = DateTime.Now,
                    WorkerId = 1,
                    isDeleted = false
                }
            };

            return categories;
        }
    }
}
