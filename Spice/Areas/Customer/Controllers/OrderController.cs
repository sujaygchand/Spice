﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using Spice.Models.ViewModels;
using Spice.Utilities;

namespace Spice.Areas.Customer.Controllers
{
	[Area("Customer")]
	public class OrderController : Controller
	{
		private readonly ApplicationDbContext _db;
		private UserClaim userClaim;

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

		public IActionResult Index()
		{
			return View();
		}
	}
}