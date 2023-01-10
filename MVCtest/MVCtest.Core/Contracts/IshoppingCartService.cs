using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCtest.Core.Models;

namespace MVCtest.Core.Contracts
{
    public interface IshoppingCartService
    {
        Task<ShoppingCart> GetShoppingCartAsyncById(int id);
    }
}
