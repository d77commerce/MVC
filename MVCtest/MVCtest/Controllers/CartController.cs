using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCtest.Core.Models;
using MVCtest.Core.Models.Administration;
using MVCtest.Infrastructure.Common;
using MVCtest.Infrastructure.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCtest.Core.Contracts;

namespace MVCtest.Controllers
{
	[Authorize]
	public class CartController : Controller
	{
		private readonly IUnitOfWork _unitOfWork;
       
		public CartController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
			
		}
		public async Task<IActionResult> Index(int count)
		{
			var claimsIdentity = (ClaimsIdentity)User.Identity;
			var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            ShoppingCartVM shoppingCart = new ShoppingCartVM()
            {
                ShoppingCarts = _unitOfWork.CartDb.GetAll(includeProperties: "Product,ApplicationUser")
                    .Where(u=>u.ApplicationUserId.ToString()==claim.Value)
            };
            /*
			var cart = _unitOfWork.CartDb.GetAll(includeProperties: "Product,ApplicationUser")
				.Where(u => u.ApplicationUserId.ToString() == claim.Value);
				*/

			return View(shoppingCart);
		}
	}
}
