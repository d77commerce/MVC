using MVCtest.Infrastructure.Models.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCtest.Infrastructure.Models
{
    public class Worker 
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(15)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public Guid UserId { get; set; } 
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;
    }
}
