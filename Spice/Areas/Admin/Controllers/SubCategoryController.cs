using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using Spice.Models;
using Spice.Models.ViewModels;

namespace Spice.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class SubCategoryController : Controller
	{
		private readonly ApplicationDbContext _db;

		[TempData]
		public string StatusMessage { get; set; }

		public SubCategoryController(ApplicationDbContext db)
		{
			_db = db;
		}

		// Get INDEX
		public async Task<IActionResult> Index()
		{
			var subCategories = await _db.SubCategory.Include(k => k.Category).ToListAsync();
			return View(subCategories);
		}

		// Get - Create
		public async Task<IActionResult> Create()
		{
			SubCategoryAndCategoryViewModel model = new SubCategoryAndCategoryViewModel()
			{
				CategoryList = await _db.Category.ToListAsync(),
				SubCategory = new Models.SubCategory(),
				SubCategoryList = await _db.SubCategory.OrderBy(k => k.Name).Select(k => k.Name).Distinct().ToListAsync()

			};

			return View(model);
		}

		// Post - Create
		[HttpPost, ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(SubCategoryAndCategoryViewModel model)
		{
			if (ModelState.IsValid)
			{
				var doesSubCategoryExist = _db.SubCategory.Include(k => k.Category).Where(k => k.Name == model.SubCategory.Name && k.Category.Id == model.SubCategory.CategoryId);

				if (doesSubCategoryExist.Count() > 0)
				{
					// Error
					StatusMessage = "Error: Sub Category exists under " + doesSubCategoryExist.First().Category.Name + " category. Please use another name.";
				}
				else
				{
					_db.SubCategory.Add(model.SubCategory);
					await _db.SaveChangesAsync();
					return RedirectToAction(nameof(Index));
				}
			}

			SubCategoryAndCategoryViewModel modelVM = new SubCategoryAndCategoryViewModel()
			{
				CategoryList = await _db.Category.ToListAsync(),
				SubCategory = model.SubCategory,
				SubCategoryList = await _db.SubCategory.OrderBy(k => k.Name).Select(k => k.Name).ToListAsync(),
				StatusMessage = StatusMessage
			};

			return View(modelVM);
		}

		public async Task<IActionResult> GetSubCategory(int id)
		{
			var subCategories = new List<SubCategory>();

			subCategories = await (from subCategory in _db.SubCategory
								   where subCategory.CategoryId == id
								   select subCategory).ToListAsync();
			return Json(new SelectList(subCategories, "Id", "Name"));
		}

		// Get - Edit
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
				return NotFound();

			var subCategory = await _db.SubCategory.FindAsync(id);

			SubCategoryAndCategoryViewModel model = new SubCategoryAndCategoryViewModel()
			{
				CategoryList = await _db.Category.ToListAsync(),
				SubCategory = subCategory,
				SubCategoryList = await _db.SubCategory.OrderBy(k => k.Name).Select(k => k.Name).Distinct().ToListAsync()
			};

			return View(model);
		}

		// Post - Edit
		[HttpPost, ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, SubCategoryAndCategoryViewModel model)
		{
			if (ModelState.IsValid == false)
				return View();

			var doesSubCategoryExist = _db.SubCategory.Include(k => k.Category).Where(k => k.Name == model.SubCategory.Name && k.Category.Id == model.SubCategory.CategoryId);

			if (doesSubCategoryExist.Count() > 0)
			{
				// Error
				StatusMessage = "Error: Sub Category exists under " + doesSubCategoryExist.First().Category.Name + " category. Please use another name.";
			}
			else
			{
				var subCatFromDb = await _db.SubCategory.FindAsync(id);
				subCatFromDb.Name = model.SubCategory.Name;

				await _db.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}

			SubCategoryAndCategoryViewModel modelVM = new SubCategoryAndCategoryViewModel()
			{
				CategoryList = await _db.Category.ToListAsync(),
				SubCategory = model.SubCategory,
				SubCategoryList = await _db.SubCategory.OrderBy(k => k.Name).Select(k => k.Name).ToListAsync(),
				StatusMessage = StatusMessage
			};

			return View(modelVM);
		}

		// Get - Details
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
				return NotFound();

			var subCategory = await _db.SubCategory.FindAsync(id);

			SubCategoryAndCategoryViewModel model = new SubCategoryAndCategoryViewModel()
			{
				CategoryList = await _db.Category.ToListAsync(),
				SubCategory = subCategory,
				SubCategoryList = await _db.SubCategory.OrderBy(k => k.Name).Select(k => k.Name).Distinct().ToListAsync()
			};

			return View(model);
		}

		// Get - Delete
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
				return NotFound();

			var subCategory = await _db.SubCategory.FindAsync(id);

			SubCategoryAndCategoryViewModel model = new SubCategoryAndCategoryViewModel()
			{
				CategoryList = await _db.Category.ToListAsync(),
				SubCategory = subCategory,
				SubCategoryList = await _db.SubCategory.OrderBy(k => k.Name).Select(k => k.Name).Distinct().ToListAsync()
			};

			return View(model);
		}

		// Post - Delete
		[HttpPost, ValidateAntiForgeryToken]
		public async Task<IActionResult> Delete(int id)
		{
			var subCategory = await _db.SubCategory.FindAsync(id);

			if (subCategory == null)
				return NotFound();

			_db.SubCategory.Remove(subCategory);
			await _db.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

	}
}