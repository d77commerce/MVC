
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCtest.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(100)]
        public string DisplayOrder { get; set; } = null!;
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        [Required]
        public int WorkerId { get; set; }

        [ForeignKey(nameof(WorkerId))]
        public Worker Worker { get; set; } = null!;
        [Required]
        [Comment("Marks record as delated")]
        public bool isDeleted { get; set; } = false;
    }
}
