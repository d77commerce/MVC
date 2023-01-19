using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using MVCtest.Core.Contracts;
using MVCtest.Infrastructure.Models;

namespace MVCtest.Core.Models
{
    [Authorize]
    public class ShoppingCartVM :IShoppingCartVM
    {
        public IEnumerable<CartDb>? ShoppingCarts { get; set; }
        public double TotalSum { get; set; }
    }
}
