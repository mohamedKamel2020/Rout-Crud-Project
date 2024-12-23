using Demo.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace Demo.PL.Controllers
{
	public class RoleController : Controller
	{
		private readonly RoleManager<IdentityRole> _roleManager;

		public RoleController(RoleManager<IdentityRole> roleManager)
		{
			_roleManager = roleManager;
		}
		//Role/Index
		public async Task<IActionResult> Index(string SearchValue)
		{
			var roles = Enumerable.Empty<IdentityRole>().ToList();
			if (string.IsNullOrEmpty(SearchValue))
			{
				roles.AddRange(_roleManager.Roles);
			}
			else
			{
				roles.Add(await _roleManager.FindByNameAsync(SearchValue));
			}
			return View(roles);
		}

		//Role/Create
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create(IdentityRole role)
		{
			if (ModelState.IsValid)
			{
				await _roleManager.CreateAsync(role);
				return RedirectToAction(nameof(Index));
			}
			return View(role);
		}
		//Roles/Details/id
		public async Task<IActionResult> Details(string id, string viewName = "Details")
		{
			if (id == null)
				return NotFound();
			var User = await _roleManager.FindByIdAsync(id);
			if (User == null)
				return NotFound();

			return View(viewName, User);
		}

		//Role/Edit/id
		public async Task<IActionResult> Edit(string id)
		{
			return await Details(id, "Edit");
		}

		[HttpPost]
		public async Task<IActionResult> Edit([FromRoute] string id, IdentityRole updateRole)
		{
			if (id != updateRole.Id)
				return BadRequest();
			if (ModelState.IsValid)
			{
				try
				{
					var role = await _roleManager.FindByIdAsync(id);
					role.Name = updateRole.Name;
					
					await _roleManager.UpdateAsync(role);
					return RedirectToAction(nameof(Index));
				}
				catch (Exception ex)
				{
					ModelState.AddModelError("", ex.Message);
					return View(updateRole);
				}
			}
			return View(updateRole);
		}

		//Role/Delete

		public async Task<IActionResult> Delete(string id)
		{
			return await Details(id, "Delete");
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Delete(string id, IdentityRole deleteRole)
		{
			if (id != deleteRole.Id)
				return BadRequest();
			try
			{
				var role = await _roleManager.FindByIdAsync(id);
				await _roleManager.DeleteAsync(role);
				return RedirectToAction(nameof(Index));
			}
			catch (Exception ex)
			{
				ModelState.AddModelError("", ex.Message);
				return View(deleteRole);
			}
		}

	}
}
