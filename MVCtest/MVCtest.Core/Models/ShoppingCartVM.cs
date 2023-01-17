using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCtest.Infrastructure.Models;

namespace MVCtest.Core.Models
{
    public class ShoppingCartVM
    {
        public IEnumerable<CartDb> ShoppingCarts { get; set; }
    }
}
