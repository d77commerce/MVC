using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebShopS.Core.Contracts;
using WebShopS.Core.Models;

namespace WebShopS.Core.Services
{
    /// <summary>
    /// manipulate data
    /// </summary>
    public class ProductService : IProductService
    {
       /// <summary>
       /// Ioc
       /// </summary>
        private readonly IConfiguration configuration;

        public ProductService(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        /// <summary>
        /// get all products
        /// </summary>
        /// <returns>list of products</returns>
        public async Task<IEnumerable<ProductDto>> GetAll()
        {
            string dataPath = configuration.GetSection("DataFiles:Products").Value;
            string data = await File.ReadAllTextAsync(dataPath);
            return JsonConvert.DeserializeObject<IEnumerable<ProductDto>>(data);
        }
    }
}
