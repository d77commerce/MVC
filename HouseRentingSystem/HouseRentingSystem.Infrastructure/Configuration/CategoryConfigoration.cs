using HouseRentingSystem.Infrastructure.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Infrastructure.Configuration
{
    internal class CategoryConfigoration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CreateCategory());
        }
        private List<Category> CreateCategory()
        {
            var categories = new List<Category>();
            var category = new Category()
             {
                 Id = 1,
                 Name = "Cottage"
             };
            categories.Add(category);
            category = new Category()
            {
                Id = 2,
                Name = "Single-Family"
            };
            categories.Add(category);
            category = new Category()
            {
                Id = 3,
                Name = "Duplex"
            };
            categories.Add(category);

            return categories;

        }
    }
}
