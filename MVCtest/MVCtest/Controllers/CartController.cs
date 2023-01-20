using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCtest.Core.Models;
using MVCtest.Infrastructure.Common;
using System.Security.Claims;
using MVCtest.Core.Contracts;
using MVCtest.Core.Servises;

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
		public async Task<IActionResult> Index()
		{
			var claimsIdentity = (ClaimsIdentity)User.Identity;
			var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
			double sum = 0;
			ShoppingCartVM shoppingCart = new ShoppingCartVM()
			{
				ShoppingCarts = _unitOfWork.CartDb.GetAll(includeProperties: "Product,ApplicationUser")
					.Where(u => u.ApplicationUserId.ToString() == claim.Value)
			};
			foreach (var cart in shoppingCart.ShoppingCarts)
			{
				cart.TotalPrice = ShoppingCartService.TotalPricePerQuantity(cart.Count, cart.Product.Price, cart.Product.Price50,
					cart.Product.Price100);
				cart.Price = ShoppingCartService.PricePerQuantity(cart.Count, cart.Product.Price, cart.Product.Price50,
					cart.Product.Price100);
				sum += cart.TotalPrice;
			}
			shoppingCart.TotalSum = sum;
			return View(shoppingCart);
		}
		public async Task<IActionResult> Summary()
		{
			/*var claimsIdentity = (ClaimsIdentity)User.Identity;
			var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
			double sum = 0;
			ShoppingCartVM shoppingCart = new ShoppingCartVM()
			{
				ShoppingCarts = _unitOfWork.CartDb.GetAll(includeProperties: "Product,ApplicationUser")
					.Where(u => u.ApplicationUserId.ToString() == claim.Value)
			};
			foreach (var cart in shoppingCart.ShoppingCarts)
			{
				cart.TotalPrice = ShoppingCartService.TotalPricePerQuantity(cart.Count, cart.Product.Price, cart.Product.Price50,
					cart.Product.Price100);
				cart.Price = ShoppingCartService.PricePerQuantity(cart.Count, cart.Product.Price, cart.Product.Price50,
					cart.Product.Price100);
				sum += cart.TotalPrice;
			}
			shoppingCart.TotalSum = sum;
			return View(shoppingCart);*/
			return View();
		}
		public async Task<IActionResult> PlusCountTask(int cartId)
		{
			var cart = _unitOfWork.CartDb.GetFirstOrDefault(c => c.Id == cartId);
			_unitOfWork.CartDb.PlusCount(cart, 1);
			_unitOfWork.Save();
			return RedirectToAction(nameof(Index));
		}
		public async Task<IActionResult> MinusCountTask(int cartId)
		{
			var cart = _unitOfWork.CartDb.GetFirstOrDefault(c => c.Id == cartId);
			if (cart.Count <= 1)
			{
				_unitOfWork.CartDb.Remove(cart);
				_unitOfWork.Save();
			}
			_unitOfWork.CartDb.MinusCount(cart, 1);
			_unitOfWork.Save();
			return RedirectToAction(nameof(Index));
		}
		public async Task<IActionResult> Remove(int cartId)
		{
			var cart = _unitOfWork.CartDb.GetFirstOrDefault(c => c.Id == cartId);
			_unitOfWork.CartDb.Remove(cart);
			_unitOfWork.Save();
			return RedirectToAction(nameof(Index));
		}
	}
}
