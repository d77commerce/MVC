using Microsoft.AspNetCore.Mvc;

namespace WebShopS.Controllers
{
    public class one : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
