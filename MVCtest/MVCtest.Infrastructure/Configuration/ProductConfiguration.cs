using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCtest.Infrastructure.Models;

namespace MVCtest.Infrastructure.Configuration
{
    public class ProductConfiguration :IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(Products());
        }

        private List<Product> Products()
        {
            var products = new List<Product>()
            {
                new Product
                {
                    Id = 100,
                    Title = "Lelia Petranka",
                    Description = "SInio Liato",
                    ISBN = "23110009090",
                    Author = "Stefan Deshev",
                    ListPrice = 10,
                    Price = 8,
                    Price50 = 7,
                    Price100 = 5,
                    ImgURL = "https://www.luxury-architecture.net/wp-content/uploads/2017/12/1513217889-7597-FAIRWAYS-010.jpg",
                    CategoryId = 1,
                    CoverId = 1
                },
                new Product
                {
                    Id = 101,
                    Title = "Kaka Kremena",
                    Description = "Koziak",
                    ISBN = "23110009090",
                    Author = "Stefan Deshev",
                    ListPrice = 22,
                    Price = 8,
                    Price50 = 7,
                    Price100 = 5,
                    ImgURL = "https://www.luxury-architecture.net/wp-content/uploads/2017/12/1513217889-7597-FAIRWAYS-010.jpg",
                    CategoryId = 2,
                    CoverId = 2
                }
            };
            return products;
        }
    }
}
/*
[Key]
public int Id { get; set; }
[Required]
public string Title { get; set; } = null!;
[Required]
public string Description { get; set; } = null!;
[Required]
public string ISBN { get; set; } = null!;
[Required]
public string Author { get; set; } = null!;
[Required]
[Range(1, 10000)]
public double ListPrice { get; set; }
[Required]
[Range(1, 10000)]
public double Price { get; set; }

[Required]
[Range(1, 10000)]
public double Price50 { get; set; }
[Required]
[Range(1, 10000)]
public double Price100 { get; set; }
[ValidateNever]
public string ImgURL { get; set; } = null!;

[ForeignKey(nameof(Category))]
public int CategoryId { get; set; }
[ValidateNever]
public Category Category { get; set; }

[ForeignKey(nameof(Cover))]
public int CoverId { get; set; }
[ValidateNever]
public Cover Cover { get; set; }
[Required]
[Comment("Marks record as deleted")]
public bool isDeleted { get; set; } = false;
*/
