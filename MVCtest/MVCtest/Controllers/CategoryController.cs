
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCtest.Data;
using MVCtest.Models;

namespace MVCtest.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext dbCategoryContext;

        public CategoryController(ApplicationDbContext _dbCategoryContext)
        {
            dbCategoryContext = _dbCategoryContext;
        }

        /// <summary>
        /// List of Category
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {

            IEnumerable<Category> category = dbCategoryContext.Categories;
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
                dbCategoryContext.Categories.Add(newObject);
                await dbCategoryContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(newObject);

        }

        public async  Task<IActionResult> Edit(int? id)
        {


            if (id == null || id == 0)
            {

                return NotFound();
            }

            //var categoryFirst = await dbCategoryContext.Categories.FirstOrDefaultAsync(u => u.Id == id);
            var categoryId =await dbCategoryContext.Categories.FindAsync(id);
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
        public IActionResult Edit(Category newObject)
        {
            if (newObject.Name == newObject.DisplayOrder)
            {
                ModelState.AddModelError("Name", "Invalid Name");
            }

            if (ModelState.IsValid)
            {
                dbCategoryContext.Categories.Update(newObject);
                dbCategoryContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(newObject);
        }
    }
}
