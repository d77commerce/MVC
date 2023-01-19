using MVCtest.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCtest.Core.Contracts
{
    public interface IShoppingCartVM
    {
        public IEnumerable<CartDb>? ShoppingCarts { get; set; }
        public double TotalSum { get; set; }
    }
}
