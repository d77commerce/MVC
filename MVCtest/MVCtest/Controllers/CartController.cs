using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCtest.Core.Models;
using MVCtest.Infrastructure.Common;
using System.Security.Claims;
using System.Text;
using MVCtest.Core.Constants;
using MVCtest.Core.Contracts;
using MVCtest.Core.Servises;
using MVCtest.Infrastructure.Models;

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
				ShoppingCarts = _unitOfWork.CartDb.GetAll(includeProperties: "Product")
					.Where(u => u.ApplicationUserId.ToString() == claim.Value)
					,
				OrderHeader = new()
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
		[HttpGet]
		public async Task<IActionResult> Summary()
		{
			var claimsIdentity = (ClaimsIdentity)User.Identity;
			var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
			double sum = 0;
			ShoppingCartVM shoppingCart = new ShoppingCartVM()
			{
				ShoppingCarts = _unitOfWork.CartDb.GetAll(includeProperties: "Product")
					.Where(u => u.ApplicationUserId.ToString() == claim.Value),
				OrderHeader = new()
			};

			shoppingCart.OrderHeader.ApplicationUser =
				_unitOfWork.ApplicationUser
					.GetFirstOrDefault(u => u.Id.ToString() == claim.Value);
			
			shoppingCart.OrderHeader.Name = $"{shoppingCart.OrderHeader.ApplicationUser.FirstName} {shoppingCart.OrderHeader.ApplicationUser.LastName}";
			shoppingCart.OrderHeader.PhoneNumber = shoppingCart.OrderHeader.ApplicationUser.PhoneNumber;
			shoppingCart.OrderHeader.StreetAddress =shoppingCart.OrderHeader.ApplicationUser.Street;
			shoppingCart.OrderHeader.AddressLine1 = shoppingCart.OrderHeader.ApplicationUser.AddressLine1;
			shoppingCart.OrderHeader.AddressLine2 = shoppingCart.OrderHeader.ApplicationUser.AddressLine2;
			shoppingCart.OrderHeader.City = shoppingCart.OrderHeader.ApplicationUser.City;
			shoppingCart.OrderHeader.State = shoppingCart.OrderHeader.ApplicationUser.Country;
			shoppingCart.OrderHeader.PostalCode = shoppingCart.OrderHeader.ApplicationUser.Postcode;

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
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Summary(ShoppingCartVM shoppingCart)
		{
			var claimsIdentity = (ClaimsIdentity)User.Identity; 
			var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
			double sum = 0;

			shoppingCart.ShoppingCarts = _unitOfWork.CartDb.GetAll(includeProperties: "Product")
				.Where(u => u.ApplicationUserId.ToString() == claim.Value);

			shoppingCart.OrderHeader.PaymentStatus = CartConstants.PaymentStatusPending;
			shoppingCart.OrderHeader.OrderStatus = ShippingConstants.StatusPending;
			shoppingCart.OrderHeader.OrderDate = DateTime.Now;
			shoppingCart.OrderHeader.AppUserId= Guid.Parse(claim.Value);

			foreach (var cart in shoppingCart.ShoppingCarts)
			{
				cart.TotalPrice = ShoppingCartService.TotalPricePerQuantity(cart.Count, cart.Product.Price, cart.Product.Price50,
					cart.Product.Price100);
				cart.Price = ShoppingCartService.PricePerQuantity(cart.Count, cart.Product.Price, cart.Product.Price50,
					cart.Product.Price100);
				sum += cart.TotalPrice;
			}
			shoppingCart.OrderHeader.OrderTotal=sum;
			//shoppingCart.TotalSum = sum;
			_unitOfWork.OrderHeader.Add(shoppingCart.OrderHeader);
			_unitOfWork.Save();
			foreach (var cart in shoppingCart.ShoppingCarts)
			{
				OrderDetail orderDetail = new OrderDetail()
				{
					ProductId = cart.Product.Id,
					OrderId = shoppingCart.OrderHeader.Id,
					Price = cart.Price,
					Count = cart.Count
				};
				_unitOfWork.OrderDetail.Add(orderDetail);
				_unitOfWork.Save();
			}
			//_unitOfWork.CartDb.RemoveRange(shoppingCart.ShoppingCarts);
			foreach (var Shopcart in shoppingCart.ShoppingCarts)
			{
				var cart = _unitOfWork.CartDb.GetFirstOrDefault(c => c.Id == Shopcart.Id);
				_unitOfWork.CartDb.Remove(cart);
				_unitOfWork.Save();
			}
			return RedirectToAction(nameof(Index),"Home");

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
