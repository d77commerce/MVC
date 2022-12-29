
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
        [Comment("Marks record as deleted")]
        public bool isDeleted { get; set; } = false;
    }
}
