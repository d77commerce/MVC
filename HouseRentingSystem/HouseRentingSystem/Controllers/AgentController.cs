using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Agent;
using HouseRentingSystem.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Controllers
{
    [Authorize]
    public class AgentController : Controller
    {
        private readonly IAgentService agentService;

        public AgentController(IAgentService _agentService)
        {
           agentService = _agentService;
        }

        public async Task< IActionResult> Become()
        {
            if (await agentService.ExistsById(User.Id()))
            {
               

                return RedirectToAction("Index", "Home");
            }
            var model = new BecomeAgentModel();
         return   View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Become(BecomeAgentModel model)
        {
            
            return RedirectToAction("All","House");
        }
    }
}
