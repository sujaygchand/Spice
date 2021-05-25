﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using Spice.Models;
using Spice.Models.ViewModels;
using Spice.Utilities;

namespace Spice.Areas.Customer.Controllers
{
	[Area("Customer")]
	public class OrderController : Controller
	{
		private readonly ApplicationDbContext _db;
		private UserClaim userClaim;

		private int pageSize = 2;
		public OrderController(ApplicationDbContext db)
		{
			_db = db;
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
	}
}