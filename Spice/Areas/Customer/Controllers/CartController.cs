using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
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
	}
}