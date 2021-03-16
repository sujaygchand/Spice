using System;
using System.Collections.Generic;
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
	public class CategoryController : Controller
	{
		private readonly ApplicationDbContext _db;

		public CategoryController(ApplicationDbContext db)
		{
			_db = db;
		}

		public async Task<IActionResult> Index()
		{
			return View(await _db.Category.ToListAsync());
		}

		public IActionResult Create()
		{
			return View();
		}

		// POST - needs ValidateAntiForgeryToken
		[HttpPost, ValidateAntiForgeryToken]
		public async Task<IActionResult> CreateCategory(Category category)
		{
			if(ModelState.IsValid == false)
				return View(category);

			_db.Category.Add(category);
			await _db.SaveChangesAsync();

			return RedirectToAction(nameof(Index));
		}

		// GET - shared
		public async Task<IActionResult> GetCategory(int? id)
		{
			if (id == null)
				return NotFound();

			var category = await _db.Category.FindAsync(id);

			if (category == null)
				return NotFound();

			return View(category);
		}

		// GET - EDIT
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
				return NotFound();

			var category = await _db.Category.FindAsync(id);

			if (category == null)
				return NotFound();

			return View(category);
		}

		// POST - Edit
		[HttpPost, ActionName("Edit"), ValidateAntiForgeryToken]
		public async Task<IActionResult> EditCategory(Category category)
		{
			if (ModelState.IsValid == false)
				return View(category);

			_db.Update(category);
			await _db.SaveChangesAsync();

			return RedirectToAction(nameof(Index));
		}

		// GET - DELETE
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
				return NotFound();

			var category = await _db.Category.FindAsync(id);

			if (category == null)
				return NotFound();

			return View(category);
		}

		// POST - Delete
		[HttpPost, ValidateAntiForgeryToken, ActionName("Delete")]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var category = await _db.Category.FindAsync(id);

			if (category == null)
				return View();

			_db.Category.Remove(category);
			await _db.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		// GET - Details
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
				return NotFound();

			var category = await _db.Category.FindAsync(id);

			if (category == null)
				return NotFound();

			return View(category);
		}
	}
}