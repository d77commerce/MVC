using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Infrastructure.Dto
{
   public class Agent
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;
    }
}

//•	Id – a unique integer, Primary Key
//•	PhoneNumber – a string with min length 7 and max length 15 (required)
//•	UserId – a string(required)
//•	User – an IdentityUser object

