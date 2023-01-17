using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCtest.Core.Contracts;
using MVCtest.Infrastructure.Models;

namespace MVCtest.Core.Models
{
    public class ProductVModel : IProductVModel
    {
	   

        public Product Product { get; set; }
        [ValidateNever]

        public IEnumerable<SelectListItem> CategoryList { get; set; }
        [ValidateNever]
 
       public IEnumerable<SelectListItem> CoverTypeList { get; set; }
    }
}
