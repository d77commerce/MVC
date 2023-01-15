using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCtest.Infrastructure.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(20)]
        public string CompanyNo { get; set; } = null!;
        [MaxLength(20)] 
        public string? VatNo { get; set; }
        [MaxLength(25)]
        public string? CompanyPhoneNo { get; set; }
        [MaxLength(100)]
        public string? Street { get; set; }
        [MaxLength(100)]
        public string? Town { get; set; }
        [Required]
        [MaxLength(50)]
        public string Country { get; set; }=null!;
       [MaxLength(20)]
        public string? Postcode { get; set; }
    }
}
