using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCtest.Core.Models;
using MVCtest.Infrastructure.Models;

namespace MVCtest.Core.Contracts
{
    public interface IShoppingCart
    {
        public ProductVModel ProductVModel { get; set; }
        public int Count { get; set; }
    }
}
