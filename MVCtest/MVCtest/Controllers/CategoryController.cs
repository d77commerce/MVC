using Microsoft.AspNetCore.Mvc;

namespace MVCtest.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
