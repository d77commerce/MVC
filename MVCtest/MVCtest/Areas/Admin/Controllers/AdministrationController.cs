using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCtest.Core.Models;

namespace MVCtest.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdministrationController : Controller
    {
        
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> AddManager()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddManager(ManagerModel managerModel)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
