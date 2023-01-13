using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using MVCtest.Infrastructure.Models;

namespace MVCtest.Core.Models
{
    public class ManagerModel
    {
        public string Email { get; set; } = null!;
        [ValidateNever]
        public IEnumerable<Department> Departments  { get; set; }
    }
}
