using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using Spice.Models;
using Spice.Utilities;

namespace Spice.Areas.Admin.Controllers
{
	[Authorize(Roles = StaticDetails.ManagerUser)]
	[Area("Admin")]
	public class CouponController : Controller
	{
		private readonly ApplicationDbContext _db;

		public CouponController(ApplicationDbContext db)
		{
			_db = db;
		}

		public async Task<IActionResult> Index()
		{
			return View(await _db.Coupon.ToListAsync());
		}

		// Get - Create
		public IActionResult Create()
		{
			return View();
		}

		// Post - Create
		[HttpPost, ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(Coupon coupon)
		{
			if (ModelState.IsValid == false)
				return View(coupon);

			var files = HttpContext.Request.Form.Files;

			if (files.Count > 0)
			{
				byte[] pictureData = null;

				using (var fileStream = files[0].OpenReadStream())
				{
					using (var memoryStream = new MemoryStream())
					{
						fileStream.CopyTo(memoryStream);
						pictureData = memoryStream.ToArray();
					}
				}
				coupon.Picture = pictureData;
			}

			_db.Coupon.Add(coupon);
			await _db.SaveChangesAsync();

			return RedirectToAction(nameof(Index));
		}

		// Get - Edit
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
				return NotFound();

			var coupon = await _db.Coupon.FindAsync(id);

			if (coupon == null)
				return NotFound();

			return View(coupon);
		}

		// Post - Edit
		[HttpPost, ActionName("Edit"), ValidateAntiForgeryToken]
		public async Task<IActionResult> EditPost (Coupon coupon)
		{

			var couponFromDb = await _db.Coupon.Where( k => k.Id == coupon.Id).FirstOrDefaultAsync();

			if (couponFromDb == null)
				return NotFound();

			if(ModelState.IsValid == false)
				return View(couponFromDb);

			var files = HttpContext.Request.Form.Files;

			if(files.Count > 0)
			{
				byte[] pictureData = null;

				using (var fileStream = files[0].OpenReadStream())
				{
					using(var memoryStream = new MemoryStream())
					{
						fileStream.CopyTo(memoryStream);
						pictureData = memoryStream.ToArray();
					}
				}

				couponFromDb.Picture = pictureData;
			}

			couponFromDb.MinimumAmount = coupon.MinimumAmount;
			couponFromDb.Name = coupon.Name;
			couponFromDb.IsActive = coupon.IsActive;
			couponFromDb.CouponType = coupon.CouponType;
			couponFromDb.Discount = coupon.Discount;

			await _db.SaveChangesAsync();

			return RedirectToAction(nameof(Index));
		}

		// Get - Details
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
				return NotFound();

			var coupon = await _db.Coupon.FindAsync(id);

			if (coupon == null)
				return NotFound();

			return View(coupon);
		}

		// Get - Delete
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
				return NotFound();

			var coupon = await _db.Coupon.FindAsync(id);

			if (coupon == null)
				return NotFound();

			return View(coupon);
		}

		// Post - Delete
		[HttpPost, ValidateAntiForgeryToken, ActionName("Delete")]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var coupon = await _db.Coupon.FindAsync(id);

			if (coupon == null)
				return View();

			_db.Coupon.Remove(coupon);
			await _db.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}
	}
}