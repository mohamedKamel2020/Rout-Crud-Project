using Demo.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.PL.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public UserController(UserManager<ApplicationUser> userManager) 
        { 
            _userManager = userManager;
        }
        //User/Index
        public async Task<IActionResult> Index(string SearchValue)
        {
            var users=Enumerable.Empty<ApplicationUser>().ToList();
            if (string.IsNullOrEmpty(SearchValue)) 
            {
                users.AddRange(_userManager.Users);
            }
            else
            {
                users.Add(await _userManager.FindByEmailAsync(SearchValue));
            }
            return View(users);
        }

        //Users/Details/id
        public async Task<IActionResult> Details(string id,string viewName="Details")
        {
            if (id == null)
                return NotFound();
            var User=await _userManager.FindByIdAsync(id);
            if (User == null)
                return NotFound();

            return View(viewName, User);
        }
        
        //User/Edit/id
        public async Task<IActionResult> Edit(string id)
        {
            return await Details(id,"Edit");
        }

        [HttpPost]
        public async Task<IActionResult> Edit([FromRoute] string id,ApplicationUser updateUser)
        {
            if(id != updateUser.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    var user = await _userManager.FindByIdAsync(id);
                    user.UserName = updateUser.UserName;
                    user.PhoneNumber=updateUser.PhoneNumber;
                    //user.Email=updateUser.Email;
                    //user.SecurityStamp=updateUser.SecurityStamp;
                    await _userManager.UpdateAsync(user);
                    return RedirectToAction(nameof(Index));
                }catch(Exception ex)
                {
                    ModelState.AddModelError("",ex.Message);
                    return View(updateUser);
                }
            }
            return View(updateUser);
        }
        
        //User/Delete

        public async Task<IActionResult> Delete(string id)
        {
            return await Details(id, "Delete");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string id,ApplicationUser deleteUser)
        {
            if(id != deleteUser.Id)
                return BadRequest();
            try
            {
				var user = await _userManager.FindByIdAsync(id);
				await _userManager.DeleteAsync(user);
                return RedirectToAction(nameof(Index));
            }catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(deleteUser);
            }
        }


    }
}
