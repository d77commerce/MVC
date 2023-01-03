using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MVCtest.Infrastructure.Models
{
    public class Product
    {
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
        [Required]
        public string ImgURL { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [ForeignKey(nameof(Cover))]
        public int CoverId { get; set; }
        public Cover Cover { get; set; }
        [Required]
        [Comment("Marks record as deleted")]
        public bool isDeleted { get; set; } = false;
    }
}
