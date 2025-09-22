using ChatApp.Entities;
using ChatApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers
{
    public class LoginController(UserManager<AppUser> _userManager,
                                 SignInManager<AppUser> _signInManager           ) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult>Index(LoginViewModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if(user is null)
            {
                ModelState.AddModelError("", "Bu Email Sistemde Kayıtlı Değil!");
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "E-Mail veya Şifre Hatalı");
                return View(model);
            }
            return RedirectToAction("Index","Message");
        }
    }
}
