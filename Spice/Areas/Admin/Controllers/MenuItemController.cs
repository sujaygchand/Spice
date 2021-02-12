using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using Spice.Models;
using Spice.Models.ViewModels;
using Spice.Utilities;

namespace Spice.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class MenuItemController : Controller
	{
		private readonly ApplicationDbContext _db;
		private readonly IWebHostEnvironment _webHostEnvironment;

		[BindProperty]
		public MenuItemViewModel MenuItemVM { get; set; }

		public MenuItemController(ApplicationDbContext db, IWebHostEnvironment webHostEnvironment)
		{
			_db = db;
			_webHostEnvironment = webHostEnvironment;
			MenuItemVM = new MenuItemViewModel()
			{
				Category = _db.Category,
				MenuItem = new Models.MenuItem()
			};
		}

		// GET: Menu
		public async Task<ActionResult> Index()
		{
			var menuItem = await _db.MenuItem.Include(k => k.Category).Include(k => k.SubCategory).ToListAsync();
			return View(menuItem);
		}

		// GET: Menu/Create
		public ActionResult Create()
		{
			return View(MenuItemVM);
		}

		// POST: Menu/Create
		[HttpPost, ActionName("Create")]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> CreatePost()
		{
			MenuItemVM.MenuItem.SubCategoryId = Convert.ToInt32(Request.Form["SubCategoryId"].ToString());

			if (ModelState.IsValid == false)
				return View(MenuItemVM);

			_db.MenuItem.Add(MenuItemVM.MenuItem);
			await _db.SaveChangesAsync();

			// Work on saving image

			string webRootPath = _webHostEnvironment.WebRootPath;
			var files = HttpContext.Request.Form.Files;

			var menuItemFromDb = await _db.MenuItem.FindAsync(MenuItemVM.MenuItem.Id);

			if (files.Count > 0)
			{
				var uploads = Path.Combine(webRootPath, "images");
				var extension = Path.GetExtension(files[0].FileName);

				using (var fileStream = new FileStream(Path.Combine(uploads, MenuItemVM.MenuItem.Id + extension), FileMode.Create))
				{
					files[0].CopyTo(fileStream);
				}
				menuItemFromDb.Image = @"\images\" + MenuItemVM.MenuItem.Id + extension;
			}
			else
			{
				// no file was uploaded
				var uploads = Path.Combine(webRootPath, @"images\" + StaticDetails.DefaultFoodImage);
				System.IO.File.Copy(uploads, webRootPath + @"\images\" + MenuItemVM.MenuItem.Id + ".png");
				menuItemFromDb.Image = @"\images\" + MenuItemVM.MenuItem.Id + ".png";
			}

			await _db.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		// GET: Menu/Edit
		public async Task<ActionResult> Edit(int? id)
		{
			if (id == null)
				return NotFound();

			MenuItemVM.MenuItem = await _db.MenuItem.Include(k => k.Category).Include(k => k.SubCategory).SingleOrDefaultAsync(k => k.Id == id);
			MenuItemVM.subCategory = await _db.SubCategory.Where(k => k.CategoryId == MenuItemVM.MenuItem.CategoryId).ToListAsync();

			if (MenuItemVM.MenuItem == null)
				return NotFound();

			return View(MenuItemVM);
		}

		// POST: Menu/Create
		[HttpPost, ActionName("Edit")]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> EditPost(int? id)
		{
			MenuItemVM.MenuItem.SubCategoryId = Convert.ToInt32(Request.Form["SubCategoryId"].ToString());

			if (ModelState.IsValid == false)
			{
				MenuItemVM.subCategory = await _db.SubCategory.Where(k => k.CategoryId == MenuItemVM.MenuItem.CategoryId).ToListAsync();
				return View(MenuItemVM);
			}

			string webRootPath = _webHostEnvironment.WebRootPath;
			var files = HttpContext.Request.Form.Files;

			var menuItemFromDb = await _db.MenuItem.FindAsync(MenuItemVM.MenuItem.Id);

			if (files.Count > 0)
			{
				var uploads = Path.Combine(webRootPath, "images");
				var uploadExtension = Path.GetExtension(files[0].FileName);

				// Delete original file
				var imagePath = menuItemFromDb.Image != null ? Path.Combine(webRootPath, menuItemFromDb.Image.Trim('\\')) : uploads;

				if (System.IO.File.Exists(imagePath))
				{
					System.IO.File.Delete(imagePath);
				}

				using (var fileStream = new FileStream(Path.Combine(uploads, MenuItemVM.MenuItem.Id + uploadExtension), FileMode.Create))
				{
					files[0].CopyTo(fileStream);
				}
				menuItemFromDb.Image = @"\images\" + MenuItemVM.MenuItem.Id + uploadExtension;
			}

			menuItemFromDb.Name = MenuItemVM.MenuItem.Name;
			menuItemFromDb.Description = MenuItemVM.MenuItem.Description;
			menuItemFromDb.Price = MenuItemVM.MenuItem.Price;
			menuItemFromDb.Spicyness = MenuItemVM.MenuItem.Spicyness;
			menuItemFromDb.CategoryId = MenuItemVM.MenuItem.CategoryId;
			menuItemFromDb.SubCategoryId = MenuItemVM.MenuItem.SubCategoryId;

			await _db.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		// Get - Details
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
				return NotFound();

			MenuItemVM.MenuItem = await _db.MenuItem.Include(k => k.Category).Include(k => k.SubCategory).SingleOrDefaultAsync(k => k.Id == id);
			MenuItemVM.subCategory = await _db.SubCategory.Where(k => k.CategoryId == MenuItemVM.MenuItem.CategoryId).ToListAsync();

			if (MenuItemVM.MenuItem == null)
				return NotFound();

			return View(MenuItemVM);
		}

		// GET: Menu/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
				return NotFound();

			MenuItemVM.MenuItem = await _db.MenuItem.Include(k => k.Category).Include(k => k.SubCategory).SingleOrDefaultAsync(k => k.Id == id);
			MenuItemVM.subCategory = await _db.SubCategory.Where(k => k.CategoryId == MenuItemVM.MenuItem.CategoryId).ToListAsync();

			if (MenuItemVM.MenuItem == null)
				return NotFound();

			return View(MenuItemVM);
		}

		// POST: Menu/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> DeletePost(int? id)
		{
			string webRootPath = _webHostEnvironment.WebRootPath;
			MenuItem menuItem = await _db.MenuItem.FindAsync(id);

			if (menuItem == null)
			{
				return RedirectToAction(nameof(Index));
			}

			if (menuItem.Image != null)
			{
				var imagePath = Path.Combine(webRootPath, menuItem.Image.Trim('\\'));

				if (System.IO.File.Exists(imagePath))
				{
					System.IO.File.Delete(imagePath);
				}
			}
			_db.MenuItem.Remove(menuItem);
			await _db.SaveChangesAsync();

			return RedirectToAction(nameof(Index));

		}
	}
}