using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCtest.Infrastructure.Models;

namespace MVCtest.Core.Contracts
{
    public interface IProductVModel
    {
        public Product Product { get; set; }
    }
}
