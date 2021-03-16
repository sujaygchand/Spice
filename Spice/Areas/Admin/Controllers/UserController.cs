using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using Spice.Utilities;

namespace Spice.Areas.Admin.Controllers
{
	[Authorize(Roles = StaticDetails.ManagerUser)]
	[Area("Admin")]
	public class UserController : Controller
	{
		private readonly ApplicationDbContext _db;

		public UserController(ApplicationDbContext db)
		{
			_db = db;
		}

		public async Task<IActionResult> Index()
		{
			var claimsIdentity = (ClaimsIdentity)this.User.Identity;
			var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

			var userList = await _db.ApplicationUser.Where(k => k.Id != claim.Value).ToListAsync();

			return View(userList);
		}

		public async Task<IActionResult> SetAccountLockState(string id, bool lockAccount = true)
		{
			if (string.IsNullOrEmpty(id))
				return NotFound();

			var applicationUser = await _db.ApplicationUser.FirstOrDefaultAsync(k => k.Id == id);

			if (applicationUser == null)
				return NotFound();

			applicationUser.LockoutEnd = lockAccount ? DateTime.Now.AddYears(1000) : DateTime.Now;

			await _db.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}
	}
}