using Microsoft.AspNetCore.Mvc;
using WebShopS.Core.Contracts;
namespace WebShopS.Controllers
{

    /// <summary>
    /// Web Shop Products
    /// </summary>
    public class ProductController : Controller
    {
       private readonly IProductService productService;
                         
        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        /// <summary>
        /// list all products
        /// </summary>
        /// <returns></returns>
        public async  Task<IActionResult> Index()
        {
            
            var products = await productService.GetAll();
            ViewData["Title"] = "Products";

            return View(products);
        }
    }
}
