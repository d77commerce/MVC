using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShopS.Core.Contracts;
using WebShopS.Core.Models;

namespace WebShopS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_productService"></param>
        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }
        /// <summary>
        /// Get All Products one
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("Application/JSON")]
        [ProducesResponseType(statusCode:200,type:typeof(IEnumerable<ProductDto>))]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await productService.GetAll());
        }
    }

}
