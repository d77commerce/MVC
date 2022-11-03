using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.VisualBasic;
using WebShopS.Models;

namespace WebShopS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            this.HttpContext.Session.SetString("name","Pesho");

            if (TempData.ContainsKey("LastAccessTime"))
            {
                return Ok(TempData["LastAccessTime"]);
            }
            TempData["LastAccessTime"] = DateTime.Now;

            return View();
        }

        public IActionResult Privacy()
        {
            this.HttpContext.Session.GetString("name");

            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}