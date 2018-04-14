using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using WebController.Entities;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebController.Controllers
{
    
    public class AccountController : Controller
    {
        private UserManager<AppUser> userManager;
        private SignInManager<AppUser> signInManager;
        private RoleManager<IdentityRole> roleManager;

        public AccountController(UserManager<AppUser> user, RoleManager<IdentityRole> _roleManager
            ,SignInManager<AppUser> _signIn)
        {
            userManager = user;
            signInManager = _signIn;
            roleManager = _roleManager;
        }


        [Authorize(Roles = "Admin")]
        public IActionResult Index() => View(userManager.Users);

        public IActionResult Register() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Error");
            }

            var user = new AppUser
            {
                UserName = model.UserName,
                Email = model.Email,
                BirthDate = model.BirthDate
            };
                var result = await userManager.CreateAsync(user, model.Password);


            // adding claims

            if (!await roleManager.RoleExistsAsync("Artist"))
                await roleManager.CreateAsync(new IdentityRole { Name = "Artist" });
            if (!await roleManager.RoleExistsAsync("User"))
                await roleManager.CreateAsync(new IdentityRole { Name = "User" });
            if (!await roleManager.RoleExistsAsync("Admin"))
                await roleManager.CreateAsync(new IdentityRole { Name = "Admin" });
            await userManager.AddToRoleAsync(user, model.Role);

            await userManager.AddClaimAsync(user, new System.Security.Claims.Claim("technology", model.Technology));



            if (result.Succeeded)
            {
                return RedirectToAction("Login");
            }

            foreach (var error in result.Errors)
                ModelState.AddModelError("error", error.Description);

            return View(model);
            
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.Email);
                if(user != null)
                {
                    await signInManager.SignOutAsync();
                    var result = await signInManager.PasswordSignInAsync(
                        user, model.Password, false, false);

                    if (result.Succeeded)
                    {
                        return Redirect(returnUrl ?? "/");
                    }
                }

                ModelState.AddModelError(nameof(LoginViewModel.Email), "Invalid user or password");
            }

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public IActionResult Details() => View();

        public IActionResult AccessDenied() => View();
    }
}
