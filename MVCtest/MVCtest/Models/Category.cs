        
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace MVCtest.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength (100)]
        public string Name { get; set; } = null!;

        public string DisplayOrder { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
    }
}
