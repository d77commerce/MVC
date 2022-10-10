
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Create(Category newObject)
        {
            if (newObject.Name == newObject.DisplayOrder)
            {
                ModelState.AddModelError("Name", "Invalid Name");
            }

            if (ModelState.IsValid)
            {
                dbCategoryContext.Categories.Add(newObject);
                dbCategoryContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(newObject);

        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                id = 2;
                return View(id);
            }

            var categoryId = dbCategoryContext.Categories.Find(id);
            var categoryFirst = dbCategoryContext.Categories.FirstOrDefault(u => u.Id == id);
            var categorySingle = dbCategoryContext.Categories.SingleOrDefault(u => u.Id == id);
            return View();

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
                dbCategoryContext.Categories.Add(newObject);
                dbCategoryContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(newObject);
        }
    }
}
