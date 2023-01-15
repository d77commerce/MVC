using MVCtest.Infrastructure.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCtest.Core.Contracts;
using MVCtest.Infrastructure.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCtest.Core.Models.Administration
{
    public class ApplicationUserModel : IApplicationUserModel
    {
        [StringLength(100,MinimumLength = 5)]
        public string? FirstName { get; set; }

        [StringLength(100,MinimumLength = 5)]
        public string? LastName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Email { get; set; } = null!;

        [StringLength(100, MinimumLength = 5)]
        public string? PhoneNumber { get; set; }

        [StringLength(100, MinimumLength = 5)]
        public string? Country { get; set; }

        [StringLength(100, MinimumLength = 5)]
        public string? City { get; set; }

        [StringLength(100, MinimumLength = 5)]
        public string? Street { get; set; }

        [StringLength(100, MinimumLength = 5)]
        public string? AddressLine1 { get; set; }

        [StringLength(100, MinimumLength = 5)]
        public string? AddressLine2 { get; set; }

        [StringLength(10,MinimumLength = 5)]
        public string? Postcode { get; set; }

        [StringLength(10, MinimumLength = 5)]

        public int? CompanyId { get; set; }
       
        public CompanyModel? CompanyModel { get; set; } = new CompanyModel();
    }
}
