using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCtest.Core.Models.Administration;
using MVCtest.Infrastructure.Common;
using MVCtest.Infrastructure.Common.Identity;
using MVCtest.Infrastructure.Models;

namespace MVCtest.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdministrationController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;



        public AdministrationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;


        }
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

        [HttpGet]
        public async Task<IActionResult> AddDepartment()
        {
            var departments = _unitOfWork.Department.GetAll(includeProperties: "Managers,Workers").Select(d => new DepartmentViewModel()
            {
                Name = d.Name,
                Address = d.Address,
                Workers = d.Workers,
                Managers = d.Managers
            }).ToList();
            return View(departments);
        }
    }
}
