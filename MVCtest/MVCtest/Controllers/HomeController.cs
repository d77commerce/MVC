using Microsoft.AspNetCore.Mvc;
using MVCtest.Infrastructure.Common;
using MVCtest.Infrastructure.Models;
using MVCtest.Models;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCtest.Core.Models;
using MVCtest.Core.Servises;
using MVCtest.Core.Contracts;

namespace MVCtest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
      
       

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork,
            IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            
        }

        public IActionResult Index()
        {
            IEnumerable<Product> productList = _unitOfWork.Product
                .GetAll(includeProperties: "Category,Cover")
                .Where(p => p.isDeleted == false);
            return View(productList);
        }
        [Authorize(Policy = "ManagerPolicy")]
        public IActionResult Privacy()
        {
            return View();
        }

        /*public async Task<IActionResult> Details(int id)
        {
           var result= _shoppingCartService.GetShoppingCartAsyncById(id);
            
            return View();
        }*/

        public async Task<IActionResult> MoreInfo(int id)
        {
            
            ShoppingCart shoppingCart = new()
            {
                ProductVModel = new()
                {
                    Product = new(),
                    CategoryList = _unitOfWork.Category.GetAll()
                        .Where(c => c.isDeleted == false)
                        .Select(c => new SelectListItem
                        {
                            Text = c.Name,
                            Value = c.Id.ToString()

                        }),
                    CoverTypeList = _unitOfWork.Cover.GetAll()
                        .Where(c => c.isDeleted == false)
                        .Select(c => new SelectListItem
                        {
                            Text = c.Name,
                            Value = c.Id.ToString()

                        })
                },
                Count = 1
            };
            shoppingCart.ProductVModel.Product = _unitOfWork.Product.GetFirstOrDefault(c => c.Id == id,
                includeProperties: "Category,Cover");
            if (shoppingCart == null)
            {
                return NotFound();
            }
            return View(shoppingCart);
            

            /*
            ProductVModel productVModel = new()
            {
                Product = new(),
                CategoryList = _unitOfWork.Category.GetAll()
                    .Where(c => c.isDeleted == false)
                    .Select(c => new SelectListItem
                    {
                        Text = c.Name,
                        Value = c.Id.ToString()

                    }),
                CoverTypeList = _unitOfWork.Cover.GetAll()
                    .Where(c => c.isDeleted == false)
                    .Select(c => new SelectListItem
                    {
                        Text = c.Name,
                        Value = c.Id.ToString()

                    })
            };
         
            
                productVModel.Product = _unitOfWork.Product.GetFirstOrDefault(c => c.Id == id,
                    includeProperties: "Category,Cover");
                if (productVModel == null)
                {
                    return NotFound();
                }
                return View(productVModel);
                */



        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
