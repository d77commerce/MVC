
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
            dbCategoryContext.Categories.Add(newObject);
            dbCategoryContext.SaveChanges();
            return new ContentResult()
            {
                Content = "<script language='javascript' type='text/javascript'>alert('Thanks for Feedback!');</script>"
            };

        }
    }
}
