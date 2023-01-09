using System.ComponentModel.DataAnnotations;
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
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            var product = _unitOfWork.Product.GetAll(includeProperties:"Category,Cover")
                .Where(c => c.isDeleted == false)
                .Select(c => new Product()
                {
                    Id = c.Id,
                    Title = c.Title,
                    ISBN = c.ISBN,
                    Price = c.Price,
                    Author = c.Author,
                    CoverId = c.CoverId,
                    Cover = c.Cover,
                    CategoryId = c.CategoryId,
                    Category = c.Category
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
                CoverTypeList = _unitOfWork.Cover.GetAll()
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
               productVModel.Product = _unitOfWork.Product.GetFirstOrDefault(c => c.Id == id,
                   includeProperties:"Category,Cover");
                if (productVModel == null)
                {
                    return NotFound();
                }
                return View(productVModel);
            }


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(ProductVModel productVModel, IFormFile? file)
        {


            if (ModelState.IsValid)
            { 
                //new image upload in folder - images\products
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null)
                {
                    //copy file
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(wwwRootPath, @"images\products");
                    var extension = Path.GetExtension(file.FileName);
                    if (productVModel.Product.ImgURL != null)
                    {
                        var oldImgPhat = Path.Combine(wwwRootPath, productVModel.Product.ImgURL.TrimStart('\\'));
                        if (System.IO.File.Exists(oldImgPhat))
                        {
                            System.IO.File.Delete(oldImgPhat);
                        }
                    }
                    using (var fileStreams = new FileStream(Path.Combine(uploads,fileName+extension),FileMode.Create))
                    {
                        file.CopyTo(fileStreams);
                    }

                    productVModel.Product.ImgURL = @"\images\products\" + fileName + extension;
                }

                if (productVModel.Product.Id == 0)
                {
                    _unitOfWork.Product.Add(productVModel.Product);
                }
                else
                {
                    _unitOfWork.Product.Update(productVModel.Product);
                }
           
                _unitOfWork.Save();
                TempData["success"] = "Product created successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(productVModel);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var productId = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == id);
            if (productId != null)
            {
                productId.isDeleted = true;
                _unitOfWork.Save();
            }

            return RedirectToAction(nameof(Index));


        }
    }
}
