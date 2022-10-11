
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

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
       
        public bool isDelete = false;
        public DateTime CreatedTime { get; set; } = DateTime.Now;
    }
}
