using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Spice.Models;
using Spice.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Data
{
	public class DbInitialiser : IDbInitialiser
	{
		public readonly ApplicationDbContext _db; 
		public readonly UserManager<IdentityUser> _userManager;
		public readonly RoleManager<IdentityRole> _roleManager;

		public DbInitialiser(ApplicationDbContext db, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
		{
			_db = db;
			_roleManager = roleManager;
			_userManager = userManager;
		}

		public async void Initialise()
		{
			try
			{
				if (_db.Database.GetPendingMigrations().Count() > 0)
					_db.Database.Migrate();
			}
			catch(Exception ex)
			{
				Debug.Print("DbInitialiser error: " + ex);
			}

			// Return if manager role exists in database
			if (_db.Roles.Any(k => k.Name == StaticDetails.ManagerUser))
				return;

			_roleManager.CreateAsync(new IdentityRole(StaticDetails.ManagerUser)).GetAwaiter().GetResult();
			_roleManager.CreateAsync(new IdentityRole(StaticDetails.FrontDeskUser)).GetAwaiter().GetResult();
			_roleManager.CreateAsync(new IdentityRole(StaticDetails.KitchenUser)).GetAwaiter().GetResult();
			_roleManager.CreateAsync(new IdentityRole(StaticDetails.CustomerEndUser)).GetAwaiter().GetResult();

			const string ADMIN_EMAIL = "thesujaygchand@gmail.com";
			
			_userManager.CreateAsync(new ApplicationUser
			{
				UserName = ADMIN_EMAIL,
				Email = ADMIN_EMAIL,
				Name = "Spice Admin",
				EmailConfirmed = true,
				PhoneNumber = "1223334444"
			}, "Admin123!").GetAwaiter().GetResult();

			IdentityUser user = await _db.Users.FirstOrDefaultAsync(k => k.Email == ADMIN_EMAIL);
			
			await _userManager.AddToRoleAsync(user, StaticDetails.ManagerUser);
		}
	}
}
