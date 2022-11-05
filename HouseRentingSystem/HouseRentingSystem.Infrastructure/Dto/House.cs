using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HouseRentingSystem.Infrastructure.Dto
{
    public class House
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(150)]
        public string Address { get; set; }

        [Required, MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [Column(TypeName = "money")]
        [Precision(18, 2)]
        public decimal PricePerMonth { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        public int AgentId { get; set; }

        [ForeignKey(nameof(AgentId))]
        public Agent Agent { get; set; }

        public string? RenterId { get; set; }

        [ForeignKey(nameof(RenterId))]
        public IdentityUser? Renter { get; set; }

    }
    //    •	Id – a unique integer, Primary Key
    //•	Title – a string with min length 10 and max length 50 (required)
    //•	Address – a string with min length 30 and max length 150 (required)
    //•	Description – a string with min length 50 and max length 500 (required)
    //•	ImageUrl – a string (required)
    //•	PricePerMonth – a decimal with min value 0 and max value 2000 (required)
    //•	CategoryId – an integer(required)
    //•	Category – a Category object
    //•	AgentId – an integer(required)
    //•	Agent – an Agent object
    //•	RenterId – a string

}
