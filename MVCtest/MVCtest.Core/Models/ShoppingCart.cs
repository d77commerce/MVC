using MVCtest.Core.Contracts;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace MVCtest.Core.Models
{
    public class ShoppingCart :IShoppingCart
    {
		
		public ProductVModel ProductVModel { get; set; }
        [Range(1,1000,ErrorMessage = "Please enter a valid value(between 1 and 1000")]
        public int Count { get; set; }

        public int ProductId  { get; set; }
    }
}
