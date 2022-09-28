using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShopS.Core.Contracts;

namespace WebShopS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await productService.GetAll());
        }
    }

}
