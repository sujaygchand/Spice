using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using Spice.Models;
using Spice.Models.ViewModels;
using Spice.Utilities;

namespace Spice.Areas.Customer.Controllers
{
	[Area("Customer")]
	public class CartController : Controller
	{
		private readonly ApplicationDbContext _db;
		
		[BindProperty]
		public OrderDetailsCart detailsCart { get; set; }

		private UserClaim userClaim;

		public CartController(ApplicationDbContext db)
		{
			_db = db;
			userClaim = userClaim ?? new UserClaim();
		}

		public async Task<IActionResult> Index()
		{
			detailsCart = new OrderDetailsCart()
			{
				OrderHeader = new Models.OrderHeader()
			};

			detailsCart.OrderHeader.OrderTotal = 0;

			var claim = userClaim.GetClaim(User.Identity);

			var cart = _db.ShoppingCarts.Where(k => k.ApplicationUserId == claim.Value);

			if (cart != null)
				detailsCart.ListCart = cart.ToList();

			foreach (var list in detailsCart.ListCart)
			{
				list.MenuItem = await _db.MenuItem.FirstOrDefaultAsync(k => k.Id == list.MenuItemId);
				detailsCart.OrderHeader.OrderTotal = detailsCart.OrderHeader.OrderTotal + (list.MenuItem.Price * list.Count);

				list.MenuItem.Description = StaticDetails.ConvertToRawHtml(list.MenuItem.Description);

				if(list.MenuItem.Description.Length > 100)
				{
					list.MenuItem.Description = list.MenuItem.Description.Substring(0, 99) + ".....";
				}
			}

			detailsCart.OrderHeader.OrderTotalOrignal = detailsCart.OrderHeader.OrderTotal;

			if(HttpContext.Session.GetString(SessionDetails.SS_COUPON_CODE) != null)
			{
				detailsCart.OrderHeader.CouponCode = HttpContext.Session.GetString(SessionDetails.SS_COUPON_CODE);
				var couponFromDb = await _db.Coupon.Where(k => k.Name.ToLower() == detailsCart.OrderHeader.CouponCode.ToLower()).FirstOrDefaultAsync();

				if(couponFromDb != null)
					detailsCart.OrderHeader.OrderTotal = StaticDetails.DiscountedPrice(couponFromDb, detailsCart.OrderHeader.OrderTotalOrignal);
			}

			return View(detailsCart);
		}


		public async Task<IActionResult> Summary()
		{
			detailsCart = new OrderDetailsCart()
			{
				OrderHeader = new Models.OrderHeader()
			};

			detailsCart.OrderHeader.OrderTotal = 0;

			var claim = userClaim.GetClaim(User.Identity);

			var cart = _db.ShoppingCarts.Where(k => k.ApplicationUserId == claim.Value);

			ApplicationUser applicationUser = await _db.ApplicationUser.Where(k => k.Id == claim.Value).FirstOrDefaultAsync();

			if (cart != null)
				detailsCart.ListCart = cart.ToList();

			foreach (var list in detailsCart.ListCart)
			{
				list.MenuItem = await _db.MenuItem.FirstOrDefaultAsync(k => k.Id == list.MenuItemId);
				detailsCart.OrderHeader.OrderTotal = detailsCart.OrderHeader.OrderTotal + (list.MenuItem.Price * list.Count);
			}

			detailsCart.OrderHeader.OrderTotalOrignal = detailsCart.OrderHeader.OrderTotal;
			detailsCart.OrderHeader.PickupName = applicationUser.Name;
			detailsCart.OrderHeader.PhoneNumber = applicationUser.PhoneNumber;
			detailsCart.OrderHeader.PickUpTime = DateTime.Now;

			if (HttpContext.Session.GetString(SessionDetails.SS_COUPON_CODE) != null)
			{
				detailsCart.OrderHeader.CouponCode = HttpContext.Session.GetString(SessionDetails.SS_COUPON_CODE);
				var couponFromDb = await _db.Coupon.Where(k => k.Name.ToLower() == detailsCart.OrderHeader.CouponCode.ToLower()).FirstOrDefaultAsync();
				detailsCart.OrderHeader.OrderTotal = StaticDetails.DiscountedPrice(couponFromDb, detailsCart.OrderHeader.OrderTotalOrignal);
			}

			return View(detailsCart);
		}

		public IActionResult AddCoupon()
		{
			if (detailsCart.OrderHeader.CouponCode == null)
				detailsCart.OrderHeader.CouponCode = "";

			HttpContext.Session.SetString(SessionDetails.SS_COUPON_CODE, detailsCart.OrderHeader.CouponCode);

			return RedirectToAction(nameof(Index));
		}

		public IActionResult RemoveCoupon()
		{
			HttpContext.Session.SetString(SessionDetails.SS_COUPON_CODE, string.Empty);
			return RedirectToAction(nameof(Index));
		}

		public async Task<IActionResult> Plus(int cartId)
		{
			var cart = await _db.ShoppingCarts.FirstOrDefaultAsync(k => k.Id == cartId);

			if (cart == null)
				NotFound();

			cart.Count++;
			await _db.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		public async Task<IActionResult> Minus(int cartId)
		{
			var cart = await _db.ShoppingCarts.FirstOrDefaultAsync(k => k.Id == cartId);

			if(cart.Count == 1)
			{
				await Remove(cartId);
			}
			else
			{
				cart.Count--;
				await _db.SaveChangesAsync();
			}

			return RedirectToAction(nameof(Index));
		}

		public async Task<IActionResult> Remove(int cartId)
		{
			var cart = await _db.ShoppingCarts.FirstOrDefaultAsync(k => k.Id == cartId);

			if (cart == null)
				NotFound();

			_db.ShoppingCarts.Remove(cart);
			await _db.SaveChangesAsync();

			var count = _db.ShoppingCarts.Where(k => k.ApplicationUserId == cart.ApplicationUserId).ToList().Count;
			HttpContext.Session.SetInt32(SessionDetails.SS_SHOPPING_CART_COUNT, count);

			return RedirectToAction(nameof(Index));
		}
	}
}