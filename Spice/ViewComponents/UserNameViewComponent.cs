using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Spice.ViewComponents
{
	public class UserNameViewComponent : ViewComponent
	{
		private readonly ApplicationDbContext _db;

		public UserNameViewComponent(ApplicationDbContext db)
		{
			_db = db;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var claimsIdentity = (ClaimsIdentity) User.Identity;
			var claims = claimsIdentity?.FindFirst(ClaimTypes.NameIdentifier);

			if (claims == null)
			{
				System.Diagnostics.Debug.WriteLine("User not found");
				return View();
			}

			var userFromDb = await _db.ApplicationUser.FirstOrDefaultAsync(k => k.Id == claims.Value);

			if (userFromDb == null)
				return View();

			return View(userFromDb);
		}

	}
}