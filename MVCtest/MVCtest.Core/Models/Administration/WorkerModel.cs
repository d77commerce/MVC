using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCtest.Core.Contracts;
using MVCtest.Infrastructure.Models;

namespace MVCtest.Core.Models.Administration
{
    public class WorkerModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; } = null!;
        [Required]
        [StringLength(100)]
        public string LastName { get; set; } = null!;
        [Required]
        [StringLength(100)]
        public string Country { get; set; } = null!;
        [Required]
        [StringLength(100)]
        public string City { get; set; } = null!;
        [Required]
        [StringLength(100)]
        public string Street { get; set; } = null!;
        [Required]
        [StringLength(100)]
        public string AddressLine1 { get; set; } = null!;
        [Required]
        [StringLength(100)]
        public string AddressLine2 { get; set; } = null!;
        [Required]
        [StringLength(10)]
        public string Postcode { get; set; } = null!;


    }
}
