using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopS.Core.Models;

namespace WebShopS.Core.Contracts
{
    /// <summary>
    /// manipulate data
    /// </summary>
    public interface IProductService
    {
        /// <summary>
        /// get all prroducts
        /// </summary>
        /// <returns>list of products</returns>
        Task<IEnumerable<ProductDto>> GetAll();
    }
}
