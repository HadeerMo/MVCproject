using AutoMapper;
using Demo.BLL.Interfaces;
using Demo.DAL.Entites;
using Demo.PL.Helpers;
using Demo.PL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Identity;

namespace Demo.PL.Controllers
{
    [Authorize(Roles = "Admain")]
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public UserController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(string SearchValue)
        {
            ViewBag.NoUser = null;
            var users = Enumerable.Empty<ApplicationUser>().ToList();
            if (string.IsNullOrEmpty(SearchValue))
                users.AddRange(_userManager.Users);
            else
            {
                var SearchedUser = await _userManager.FindByEmailAsync(SearchValue);
                if(SearchedUser != null)
                    users.Add(SearchedUser);
                else
                    ViewBag.NoUser = "There is no user by that email!";

            }

            return View(users);

        }

       
        public async Task<IActionResult> Details(string id, string viewName = "Details")
        {
            if (id == null)
                return NotFound();
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
                return NotFound();
            return View(viewName, user);
        }

        public async Task<IActionResult> Edit(string id)
        {
            return await Details(id, "Edit");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ApplicationUser updatedUser, [FromRoute] string id)
        {
            if (id != updatedUser.Id)
                return BadRequest();

            if (ModelState.IsValid)
            {
                try
                {
                    var user = await _userManager.FindByIdAsync(id);
                    user.UserName = updatedUser.UserName;
                    user.PhoneNumber = updatedUser.PhoneNumber;
                    await _userManager.UpdateAsync(user);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                    //return View(employee);
                }
            }
            return View(updatedUser);
        }

        public async Task<IActionResult> Delete(string id)
        {
            return await Details(id, "Delete");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromRoute] string id, ApplicationUser deletedUser)
        {
            if (id != deletedUser.Id)
                return BadRequest();
            try
            {
                var user = await _userManager.FindByIdAsync(id);
                await _userManager.DeleteAsync(user);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception )
            {
                return View(deletedUser);
            }
        }
    }
}
