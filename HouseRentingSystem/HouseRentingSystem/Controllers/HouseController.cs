using Microsoft.AspNetCore.Mvc;
using HouseRentingSystem.Core.Models.House;
using Microsoft.AspNetCore.Authorization;

namespace HouseRentingSystem.Controllers
{
    public class HouseController : Controller
    {
        public async Task<IActionResult> All()
        {
            var model = new HousesQueryModel();

            return View(model);

        }
        [Authorize]
        public async Task<IActionResult> Mine()
        {
            var model = new HousesQueryModel();

            return View(model);
        }
        public async Task<IActionResult> Details(int Id)
        {
            var model = new HouseDetailsModel();
            return View(model);
        }
        [Authorize]
        [HttpGet]
        public IActionResult Add() => View();
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(HouseModel model)
        {
            int id = 1;
            return RedirectToAction(nameof(Details), new { id });
        }
        [Authorize]
        [HttpGet]
        public async Task< IActionResult> Edit(int id)
            {
            var model = new HouseModel();
            return View(model);
            }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult>Edit(int id,HouseModel model)
        {
            return RedirectToAction(nameof(Details), new { id });
        }
   
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            return RedirectToAction(nameof(All));
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Rent(int id)
        {
            return RedirectToAction(nameof(Mine));
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Leave(int id)
        {
            return RedirectToAction(nameof(Mine));
        }
    }
}
