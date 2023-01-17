using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCtest.Core.Models;
using MVCtest.Core.Models.Administration;
using MVCtest.Infrastructure.Common;
using MVCtest.Infrastructure.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Rendering;

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
			var cart = _unitOfWork.CartDb.GetAll(includeProperties: "Product,ApplicationUser")
				.Where(u => u.ApplicationUserId.ToString() == claim.Value)
				.Select(c => new ShoppingCart()
				{
					
					ProductVModel = new()
					{
						Product = new(),
						CategoryList = _unitOfWork.Category.GetAll()
							.Where(c => c.isDeleted == false)
							.Select(c => new SelectListItem
							{
								Text = c.Name,
								Value = c.Id.ToString()

							}),
						CoverTypeList = _unitOfWork.Cover.GetAll()
							.Where(c => c.isDeleted == false)
							.Select(c => new SelectListItem
							{
								Text = c.Name,
								Value = c.Id.ToString()

							})
					},
					Count = count
				});

			return View(cart);
		}
	}
}
