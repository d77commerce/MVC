using Microsoft.AspNetCore.Mvc;
using HouseRentingSystem.Core.Models.House;
using Microsoft.AspNetCore.Authorization;
using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Extensions;

namespace HouseRentingSystem.Controllers
{
    public class HouseController : Controller
    {
        private readonly IHouseService houseService;
        private readonly IAgentService agentService;

        public HouseController(IHouseService _houseService, IAgentService _agentService)
        {
            houseService = _houseService;
            agentService = _agentService;
        }

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
        public async Task< IActionResult> Add()
        {
            if((await agentService.ExistsById(User.Id()))==false)
            {
                return RedirectToAction(nameof(AgentController.Become), "Agent");
            }
            var model = new HouseModel()
            {
                HouseCategoryModel = await houseService.AllCategories()
            };
            return View(model);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(HouseModel model)
        {
            if ((await agentService.ExistsById(User.Id())) == false)
            {
                return RedirectToAction(nameof(AgentController.Become), "Agent");
            }

            if((await houseService.CategoryExist(model.CategoryId)) == false)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Category not exists");
            }

            if (!ModelState.IsValid)
            {
                model.HouseCategoryModel = await houseService.AllCategories();

                return View(model);
            }
            int id = await houseService.Create(model);
            return RedirectToAction(nameof(Details), new { id });
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = new HouseHomeModel();
            return View(model);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, HouseHomeModel model)
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
