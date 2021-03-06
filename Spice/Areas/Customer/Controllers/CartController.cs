﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using Spice.Models;
using Spice.Models.ViewModels;
using Spice.Utilities;
using Stripe;

namespace Spice.Areas.Customer.Controllers
{
	[Area("Customer")]
	public class CartController : Controller
	{
		private readonly ApplicationDbContext _db;
		private readonly IEmailSender _emailSender;

		[BindProperty]
		public OrderDetailsCart detailsCart { get; set; }

		private UserClaim userClaim;

		public CartController(ApplicationDbContext db, IEmailSender emailSender)
		{
			_db = db;
			_emailSender = emailSender;
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

				if (list.MenuItem.Description.Length > 100)
				{
					list.MenuItem.Description = list.MenuItem.Description.Substring(0, 99) + ".....";
				}
			}

			detailsCart.OrderHeader.OrderTotalOrignal = detailsCart.OrderHeader.OrderTotal;

			if (HttpContext.Session.GetString(SessionDetails.SS_COUPON_CODE) != null)
			{
				detailsCart.OrderHeader.CouponCode = HttpContext.Session.GetString(SessionDetails.SS_COUPON_CODE);
				var couponFromDb = await _db.Coupon.Where(k => k.Name.ToLower() == detailsCart.OrderHeader.CouponCode.ToLower()).FirstOrDefaultAsync();

				if (couponFromDb != null)
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

		[HttpPost, ActionName("Summary")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> SummaryPost(string stripeEmail, string stripeToken)
		{
			var claim = userClaim.GetClaim(User.Identity);

			detailsCart.ListCart = await _db.ShoppingCarts.Where(k => k.ApplicationUserId == claim.Value).ToListAsync();

			detailsCart.OrderHeader.PaymentStatus = StaticDetails.PaymentStatusPending;
			detailsCart.OrderHeader.OrderDate = DateTime.Now;
			detailsCart.OrderHeader.UserId = claim.Value;
			detailsCart.OrderHeader.Status = StaticDetails.PaymentStatusPending;
			detailsCart.OrderHeader.PickUpTime = Convert.ToDateTime(detailsCart.OrderHeader.PickUpDate.ToShortDateString() + " " + detailsCart.OrderHeader.PickUpTime.ToShortTimeString());

			var orderDetailsList = new List<OrderDetails>();
			_db.OrderHeaders.Add(detailsCart.OrderHeader);
			await _db.SaveChangesAsync();

			detailsCart.OrderHeader.OrderTotalOrignal = 0;

			foreach (var item in detailsCart.ListCart)
			{
				item.MenuItem = await _db.MenuItem.FirstOrDefaultAsync(k => k.Id == item.MenuItemId);
				OrderDetails orderDetails = new OrderDetails
				{
					MenuItemId = item.MenuItemId,
					OrderId = detailsCart.OrderHeader.Id,
					Description = item.MenuItem.Description,
					Name = item.MenuItem.Name,
					Price = item.MenuItem.Price,
					Count = item.Count
				};

				detailsCart.OrderHeader.OrderTotalOrignal += orderDetails.Count * orderDetails.Price;
				_db.OrderDetails.Add(orderDetails);
			}

			if (HttpContext.Session.GetString(SessionDetails.SS_COUPON_CODE) != null)
			{
				detailsCart.OrderHeader.CouponCode = HttpContext.Session.GetString(SessionDetails.SS_COUPON_CODE);
				var couponFromDb = await _db.Coupon.Where(k => k.Name.ToLower() == detailsCart.OrderHeader.CouponCode.ToLower()).FirstOrDefaultAsync();
				detailsCart.OrderHeader.OrderTotal = StaticDetails.DiscountedPrice(couponFromDb, detailsCart.OrderHeader.OrderTotalOrignal);
			}
			else
			{
				detailsCart.OrderHeader.OrderTotal = detailsCart.OrderHeader.OrderTotalOrignal;
			}

			detailsCart.OrderHeader.CouponCodeDiscount = detailsCart.OrderHeader.OrderTotalOrignal - detailsCart.OrderHeader.OrderTotal;

			_db.ShoppingCarts.RemoveRange(detailsCart.ListCart);
			HttpContext.Session.SetInt32(SessionDetails.SS_SHOPPING_CART_COUNT, 0);
			await _db.SaveChangesAsync();

			// Stripe Logic
			if (stripeToken != null)
			{
				var customers = new CustomerService();
				var charges = new ChargeService();

				var customer = customers.Create(new CustomerCreateOptions
				{
					Email = stripeEmail,
					Source = stripeToken
				});

				var charge = charges.Create(new ChargeCreateOptions
				{
					Amount = Convert.ToInt32(detailsCart.OrderHeader.OrderTotal * 100),
					Description = "Order ID : " + detailsCart.OrderHeader.Id,
					Currency = "nzd",
					Customer = customer.Id
				});

				detailsCart.OrderHeader.TransactionId = charge.BalanceTransactionId;

				if (charge.Status.ToLower() == "succeeded")
				{
					string subject = String.Format("Spice - Order Created {0}", detailsCart.OrderHeader.Id.ToString());
					string successMessage = "Order has been submitted successfully.";
					//email for successful order
					await _emailSender.SendEmailAsync(
						_db.Users.Where(k => k.Id == claim.Value).FirstOrDefault().Email,
						subject, successMessage);
						
					detailsCart.OrderHeader.PaymentStatus = StaticDetails.PaymentStatusApproved;
					detailsCart.OrderHeader.Status = StaticDetails.StatusSubmitted;
				}
				else
				{
					detailsCart.OrderHeader.PaymentStatus = StaticDetails.PaymentStatusDeclined;
				}

			}
			else
			{
				detailsCart.OrderHeader.PaymentStatus = StaticDetails.PaymentStatusDeclined;
			}


			await _db.SaveChangesAsync();
			//return RedirectToAction("Index", "Home");
			return RedirectToAction("Confirm", "Order", new { id = detailsCart.OrderHeader.Id });
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

			if (cart.Count == 1)
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