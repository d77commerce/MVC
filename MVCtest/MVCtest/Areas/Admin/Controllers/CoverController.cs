using Microsoft.AspNetCore.Mvc;
using MVCtest.Infrastructure.Common;
using MVCtest.Infrastructure.Models;

namespace MVCtest.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoverController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CoverController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index()
        {
            var cover = _unitOfWork.Cover.GetAll()
                .Where(c => c.isDeleted == false)
                .Select(c => new Cover()
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToList();
            return View(cover);
        }
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Cover newObject)
        {


            if (ModelState.IsValid)
            {
                _unitOfWork.Cover.Add(newObject);
                _unitOfWork.Save();
                TempData["success"] = " Successfully create Cover Type";
                return RedirectToAction(nameof(Index));
            }

            return View(newObject);

        }

        public async Task<IActionResult> Edit(int? id)
        {

            var CoverId = _unitOfWork.Cover.GetFirstOrDefault(c => c.Id == id);
            if (CoverId == null)
            {
                return NotFound();
            }
            return View(CoverId);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Cover cover)
        {


            if (ModelState.IsValid)
            {
                _unitOfWork.Cover.Update(cover);
                _unitOfWork.Save();
                TempData["success"] = "Category update successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(cover);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var coverId = _unitOfWork.Cover.GetFirstOrDefault(u => u.Id == id);
            if (coverId != null)
            {
                coverId.isDeleted = true;
                _unitOfWork.Save();
            }

            return RedirectToAction(nameof(Index));


        }
    }
}
