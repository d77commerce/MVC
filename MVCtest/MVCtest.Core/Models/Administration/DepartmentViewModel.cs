using MVCtest.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCtest.Core.Models.Administration
{
  public class DepartmentViewModel
    {
       
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(200)]
        public string Address { get; set; } = null!;

        public IEnumerable<Worker>? Workers { get; set; } = new List<Worker>();
        public IEnumerable<Manager>? Managers { get; set; } = new List<Manager>();
    }
}
