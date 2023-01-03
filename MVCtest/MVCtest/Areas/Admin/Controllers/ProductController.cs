using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCtest.Core.Models;
using MVCtest.Infrastructure.Common;
using MVCtest.Infrastructure.Models;

namespace MVCtest.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index()
        {
            var product = _unitOfWork.Product.GetAll()
                .Where(c => c.isDeleted == false)
                .Select(c => new Product()
                {
                    Id = c.Id,
                    Title = c.Title
                }).ToList();
            return View(product);
        }
        /*public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Cover newObject)
        {


            if (ModelState.IsValid)
            {
                _unitOfWork.Cover.Add(newObject);
                _unitOfWork.Save();
                TempData["success"] = " Successfully create Cover Type";
                return RedirectToAction(nameof(Index));
            }

            return View(newObject);

        }*/

        public async Task<IActionResult> Upsert(int? id)
        {
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
                CoverTypeList= _unitOfWork.Cover.GetAll()
                    .Where(c => c.isDeleted == false)
                    .Select(c => new SelectListItem
                    {
                        Text = c.Name,
                        Value = c.Id.ToString()

                    })
            };
            if (id == null)
            {
                /*ViewBag.CategoryList = CategoryList;
                ViewBag.CoverTypeList = CoverTypeList;*/
                return View(productVModel);

            }
            else
            {
                var ProductId = _unitOfWork.Product.GetFirstOrDefault(c => c.Id == id);
                if (ProductId == null)
                {
                    return NotFound();
                }
                return View(productVModel);
            }


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(ProductVModel productVModel,IFormFile file)
        {


            if (ModelState.IsValid)
            {
               // _unitOfWork.Product.Update(productVModel);
                _unitOfWork.Save();
                TempData["success"] = "Product update successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(productVModel);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var coverId = _unitOfWork.Cover.GetFirstOrDefault(u => u.Id == id);
            if (coverId != null)
            {
                coverId.isDeleted = true;
                _unitOfWork.Save();
            }

            return RedirectToAction(nameof(Index));


        }
    }
}
