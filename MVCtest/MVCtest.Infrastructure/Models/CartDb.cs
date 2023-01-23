using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using MVCtest.Infrastructure.Models.Identity;

namespace MVCtest.Infrastructure.Models
{
    public class CartDb
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        [ValidateNever]
        public Product Product { get; set; }
        public int  Count { get; set; }
        public Guid  ApplicationUserId  { get; set; }
        [ForeignKey(nameof(ApplicationUserId))]
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }
        [NotMapped]
        public double Price { get; set; }
        [NotMapped]
        public double TotalPrice { get; set; }
        [Required]
        public bool IsActive { get; set; } = false;
    }
}
