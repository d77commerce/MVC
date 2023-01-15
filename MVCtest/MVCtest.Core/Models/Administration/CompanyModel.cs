using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCtest.Core.Models.Administration
{
    public class CompanyModel
    {
   
        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Between 100 - 5")]
        public string Name { get; set; } = null!;
        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Between 20 - 5")]
        public string CompanyNo { get; set; } = null!;
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Between 20 - 5")]
        public string? VatNo { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Between 20 - 5")]
        public string CompanyPhoneNo { get; set; } = null!;
        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Between 20 - 5")]
        public string Street { get; set; } = null!;
        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Between 100 - 5")]
        public string Town { get; set; } = null!;
        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Between 100 - 5")]
        public string Country { get; set; } = null!;
        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Between 20 - 5")]
        public string Postcode { get; set; } = null!;
    }
}
