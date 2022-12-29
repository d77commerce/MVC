﻿
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCtest.Data;
using MVCtest.Infrastructure.Common.Category;
using MVCtest.Infrastructure.Models;
using MVCtest.Models;

namespace MVCtest.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository dbCategoryContext;

        public CategoryController(ICategoryRepository _dbCategoryContext)
        {
            dbCategoryContext = _dbCategoryContext;
        }

        /// <summary>
        /// List of Category
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {

            var category = dbCategoryContext.GetAll().
                Where(p => p.isDeleted == false)
                .Select(p => new Category()
                {
                    Id = p.Id,
                    Name = p.Name,
                    DisplayOrder = p.DisplayOrder,
                    CreatedTime = p.CreatedTime,

                })
                .ToList();
            return View(category);
        }

        public IActionResult Create()
        {
            return View();

        }

        /// <summary>
        /// Create New Category
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category newObject)
        {
            if (newObject.Name == newObject.DisplayOrder)
            {
                ModelState.AddModelError("Name", "Invalid Name");
            }

            if (ModelState.IsValid)
            {
                dbCategoryContext.Add(newObject);
                 dbCategoryContext.Save();
                TempData["success"] = "Category create successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(newObject);

        }

        public async Task<IActionResult> Edit(int? id)
        {


            if (id == null || id == 0)
            {

                return NotFound();
            }

            //var categoryFirst = await dbCategoryContext.Categories.FirstOrDefaultAsync(u => u.Id == id);
            var categoryId =  dbCategoryContext.GetFirstOrDefault(u=>u.Id==id);
            if (categoryId == null)
            {
                return NotFound();
            }
            //  var categorySingle = dbCategoryContext.Categories.SingleOrDefault(u => u.Id == id);
            return View(categoryId);

        }

        /// <summary>
        /// Create New Category
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Category newObject)
        {
            if (newObject.Name == newObject.DisplayOrder)
            {
                ModelState.AddModelError("Name", "Invalid Name");
            }

            if (ModelState.IsValid)
            {
                dbCategoryContext.Update(newObject);
              dbCategoryContext.Save();
                TempData["success"] = "Category update successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(newObject);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var categoryId =  dbCategoryContext.GetFirstOrDefault(u=>u.Id==id);
            if (categoryId != null)
            {
                categoryId.isDeleted = true;
               dbCategoryContext.Save();
            }
            return RedirectToAction(nameof(Index));


        }
    }
}
