using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCtest.Infrastructure.Models
{
    public class Cover
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        [Comment("Marks record as deleted")]
        public bool isDeleted { get; set; } = false;
    }
}
