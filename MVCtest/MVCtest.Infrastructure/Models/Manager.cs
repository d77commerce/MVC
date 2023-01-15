using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using MVCtest.Infrastructure.Models.Identity;

namespace MVCtest.Infrastructure.Models
{
    public class Manager 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        [ValidateNever]
        public ApplicationUser User { get; set; } = null!;
        [Required]
        public int DepartmentId { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        [ValidateNever]
        public Department Department { get; set; } = null!;
    }
}
