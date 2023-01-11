using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MVCtest.Infrastructure.Models.Identity
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        [StringLength(100)]
        public string? FirstName { get; set; }
        [StringLength(100)]
        public string? LastName { get; set; }

        [StringLength(100)]
        public string? Country { get; set; }

        [StringLength(100)]
        public string? City { get; set; }
        [StringLength(100)]
        public string? Street { get; set; }
        [StringLength(100)]
        public string? AddressLine1 { get; set; }
        [StringLength(100)]
        public string? AddressLine2 { get; set; }

        [StringLength(10)]
        public string? Postcode { get; set; }
    }
}
