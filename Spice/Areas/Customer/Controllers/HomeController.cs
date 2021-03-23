using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Spice.Data;
using Spice.Models;
using Spice.Models.ViewModels;

namespace Spice.Controllers
{
	[Area("Customer")]
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ApplicationDbContext _db;

		public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
		{
			_logger = logger;
			_db = db;
		}

		public async Task<IActionResult> Index()
		{
			var IndexVM = new IndexViewModel()
			{
				Coupons = await _db.Coupon.Where(k => k.IsActive).ToListAsync(),
				Categories = await _db.Category.ToListAsync(),
				MenuItems = await _db.MenuItem.Include(k => k.Category).Include(k => k.SubCategory).ToListAsync()
			};

			return View(IndexVM);
		}

		[Authorize]
		public async Task<IActionResult> Details(int id)
		{
			var menuItemFromDb = await _db.MenuItem.Include(k => k.Category).Include(k => k.SubCategory).Where(k => k.Id == id).FirstOrDefaultAsync();

			ShoppingCart cart = new ShoppingCart
			{
				MenuItem = menuItemFromDb,
				MenuItemId = menuItemFromDb.Id
			};

			return View(cart);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
