using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Spice.Data;
using Spice.Models;
using Spice.Models.ViewModels;
using Spice.Utilities;
using Stripe;

namespace Spice.Areas.Customer.Controllers
{
	[Area("Customer")]
	public class OrderController : Controller
	{
		private readonly ApplicationDbContext _db;
		private readonly IEmailSender _emailSender;
		private UserClaim userClaim;

		private int pageSize = 3;
		public OrderController(ApplicationDbContext db, IEmailSender emailSender)
		{
			_db = db;
			_emailSender = emailSender;
			userClaim = userClaim ?? new UserClaim();
		}

		[Authorize]
		public async Task<IActionResult> Confirm(int id)
		{
			var claim = userClaim.GetClaim(User.Identity);

			OrderDetailsViewModel orderDetailsViewModel = new OrderDetailsViewModel
			{
				OrderHeader = await _db.OrderHeaders.Include(k => k.ApplicationUser).FirstOrDefaultAsync(k => k.Id == id && claim.Value == k.UserId),
				OrderDetails = await _db.OrderDetails.Where(k => k.OrderId == id).ToListAsync()
			};

			orderDetailsViewModel.OrderHeader.Status = StaticDetails.StatusSubmitted;
			return View(orderDetailsViewModel);
		}

		[Authorize]
		public async Task<IActionResult> OrderHistory(int productPage = 1)
		{
			var claim = userClaim.GetClaim(User.Identity);

			OrderListViewModel orderListVM = new OrderListViewModel()
			{
				Orders = new List<OrderDetailsViewModel>()
			};
			
			List<OrderHeader> orderHeaderList = await _db.OrderHeaders.Include(k => k.ApplicationUser).Where(k => k.UserId == claim.Value).ToListAsync();

			foreach (var item in orderHeaderList)
			{
				var currentOrder = new OrderDetailsViewModel
				{
					OrderHeader = item,
					OrderDetails = await _db.OrderDetails.Where(k => k.OrderId == item.Id).ToListAsync()
				};

				orderListVM.Orders.Add(currentOrder);
			}

			var count = orderListVM.Orders.Count;

			orderListVM.Orders = orderListVM.Orders.OrderByDescending(k => k.OrderHeader)
								.Skip((productPage - 1) * pageSize)
								.Take(pageSize).ToList();

			orderListVM.PagingInfo = new PagingInfo
			{
				CurrentPage = productPage,
				ItemsPerPage = pageSize,
				TotalItems = count,
				UrlParam = "/Customer/Order/OrderHistory?productPage=:"
			};

			return View(orderListVM);
		}

		public async Task<IActionResult> GetOrderDetails(int Id)
		{
			OrderDetailsViewModel orderDetailsViewModel = new OrderDetailsViewModel()
			{
				OrderHeader = await _db.OrderHeaders.FirstOrDefaultAsync(k => k.Id == Id),
				OrderDetails = await _db.OrderDetails.Where(k => k.OrderId == Id).ToListAsync()
			};

			orderDetailsViewModel.OrderHeader.ApplicationUser =
				await _db.ApplicationUser.FirstOrDefaultAsync(k => k.Id == orderDetailsViewModel.OrderHeader.UserId);

			return PartialView("_IndividualOrderDetails", orderDetailsViewModel);
		}

		public IActionResult GetOrderStatus(int id)
		{
			var orderHeader = _db.OrderHeaders.FirstOrDefault( k => k.Id == id);

			if (orderHeader == null)
				return NotFound();
				
			return PartialView("_OrderStatus", orderHeader.Status);
		}

		[Authorize(Roles = StaticDetails.KitchenUser + "," + StaticDetails.ManagerUser)]
		public async Task<IActionResult> ManageOrder(int productPage = 1)
		{
			List<OrderDetailsViewModel> orderDetailsVM = new List<OrderDetailsViewModel>();

			List<OrderHeader> orderHeaderList = await _db.OrderHeaders.Where(k =>
					k.Status == StaticDetails.StatusSubmitted || k.Status == StaticDetails.StatusInProcess)
				.OrderByDescending(k => k.PickUpTime).ToListAsync();

			foreach (var item in orderHeaderList)
			{
				OrderDetailsViewModel currentDetails = new OrderDetailsViewModel
				{
					OrderHeader = item,
					OrderDetails = await _db.OrderDetails.Where(k => k.OrderId == item.Id).ToListAsync()
				};
				
				orderDetailsVM.Add(currentDetails);
			}

			return View(orderDetailsVM.OrderBy(k => k.OrderHeader.PickUpTime).ToList());
		}

		[Authorize(Roles = StaticDetails.KitchenUser + "," + StaticDetails.ManagerUser)]
		public async Task<IActionResult> UpdateOrderStatus(int orderId, string status = StaticDetails.StatusInProcess, string redirectPage = "ManageOrder",
		                                                   bool sendEmailUpdate = true)
		{
			OrderHeader orderHeader = await _db.OrderHeaders.FindAsync(orderId);
			orderHeader.Status = status;
			await _db.SaveChangesAsync();

			// Send email upadte to user
			if (sendEmailUpdate)
			{
				string message = "";
				
				switch (status)
				{
					case StaticDetails.StatusInProcess:
						message = "Cooking for order has started.";
						break;
					case StaticDetails.StatusReady:
						message = "Order is ready for pickup.";
						break;
					case StaticDetails.StatusSubmitted:
						message = "Order has been submitted successfully.";
						break;
					case StaticDetails.StatusCancelled:
						message = "Order has been cancelled successfully.";
						break;
					case StaticDetails.StatusCompleted:
						message = "Order has been completed successfully.";
						break;
				}

				await SendEmailOnStatusChange(orderHeader, status, message);
			}
			
			return RedirectToAction(redirectPage, "Order");
		}

		[Authorize]
		public async Task<IActionResult> OrderPickup(int productPage = 1, string searchName = null, string searchEmail = null, string searchPhone = null)
		{
			OrderListViewModel orderListVM = new OrderListViewModel()
			{
				Orders = new List<OrderDetailsViewModel>()
			};

			StringBuilder param = new StringBuilder();
			param.Append("/Customer/Order/OrderPickup?productPage=:");
			
			param.Append("&searchName=");
			if (!String.IsNullOrWhiteSpace(searchName))
			{
				param.Append(searchName);
			}

			param.Append("&searchEmail=");
			if (!String.IsNullOrWhiteSpace(searchEmail))
			{
				param.Append(searchEmail);
			}

			param.Append("&searchPhone=");
			if (!String.IsNullOrWhiteSpace(searchPhone))
			{
				param.Append(searchPhone);
			}

			List<OrderHeader> orderHeaderList = new List<OrderHeader>();

			if (!String.IsNullOrWhiteSpace(searchName) || !String.IsNullOrWhiteSpace(searchEmail) ||
			    !String.IsNullOrWhiteSpace(searchPhone))
			{
				ApplicationUser user = new ApplicationUser();

				if (!String.IsNullOrWhiteSpace(searchName))
				{
					orderHeaderList = await _db.OrderHeaders.Include(k => k.ApplicationUser)
															.Where(k => k.PickupName.ToLower().Contains(searchName.ToLower()))
															.OrderByDescending(k => k.OrderDate).ToListAsync();
				}
				else if (!String.IsNullOrWhiteSpace(searchEmail))
				{
					user = await _db.ApplicationUser.Where(k => k.Email.ToLower().Contains(searchEmail.ToLower()))
						.FirstOrDefaultAsync();
					orderHeaderList = await _db.OrderHeaders.Include(k => k.ApplicationUser)
															.Where(k => k.UserId == user.Id)
															.OrderByDescending(k => k.OrderDate).ToListAsync();
				}
				else if (!String.IsNullOrWhiteSpace(searchPhone))
				{
					orderHeaderList = await _db.OrderHeaders.Include(k => k.ApplicationUser)
						.Where(k => k.PhoneNumber.Contains(searchPhone))
						.OrderByDescending(k => k.OrderDate).ToListAsync();
				}
			}
			else
			{
				orderHeaderList = await _db.OrderHeaders.Include(k => k.ApplicationUser).Where(k => k.Status == StaticDetails.StatusReady).ToListAsync();
			}
			
			foreach (var item in orderHeaderList)
			{
				var currentOrder = new OrderDetailsViewModel
				{
					OrderHeader = item,
					OrderDetails = await _db.OrderDetails.Where(k => k.OrderId == item.Id).ToListAsync()
				};

				orderListVM.Orders.Add(currentOrder);
			}

			var count = orderListVM.Orders.Count;

			orderListVM.Orders = orderListVM.Orders.OrderByDescending(k => k.OrderHeader)
								.Skip((productPage - 1) * pageSize)
								.Take(pageSize).ToList();

			orderListVM.PagingInfo = new PagingInfo
			{
				CurrentPage = productPage,
				ItemsPerPage = pageSize,
				TotalItems = count,
				UrlParam = param.ToString()
			};

			return View(orderListVM);
		}

		private async Task SendEmailOnStatusChange(OrderHeader orderHeader, string statusSubject, string message)
		{
			string subject = String.Format("Spice - Order {0} {1}", statusSubject, orderHeader.Id.ToString());
			await _emailSender.SendEmailAsync(_db.Users.Where(u => u.Id == orderHeader.UserId).FirstOrDefault().Email, subject, message);
		}

	}
}