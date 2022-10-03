using Microsoft.AspNetCore.Mvc;
using MVCtest.Data;
using MVCtest.Models;

namespace MVCtest.Controllers
{
    public class CategoryController : Controller
    {
            private  readonly  ApplicationDbContext dbCategoryContext;

            public CategoryController(ApplicationDbContext _dbCategoryContext)
            {
                dbCategoryContext = _dbCategoryContext;
            }
        public IActionResult Index()
        {
            IEnumerable<Category> category  =dbCategoryContext.Categories;
            return View(category);
        }
    }
}
