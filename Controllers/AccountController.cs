using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using ChatApp.Models;

namespace Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        //método get
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            try 
            {
                var user = await _userManager.FindByNameAsync(username);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, password, false, false);
                    if (result.Succeeded)
                    {
                        TempData["Message"] = "Login efetuado com sucesso!";
                        return RedirectToAction("Index", "Home");
                    }
                }
                return RedirectToAction("Login", "Account");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(string username, string password, string confirmPassword)
        {
            try
            {
                var user = new User { UserName = username, ConfirmPassword = confirmPassword };
                if (password != confirmPassword)
                {
                    return RedirectToAction(nameof(Register), new { message = "As senhas informadas não conferem!"});
                }
                var result = await _userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    TempData["Message"] = "Login efetuado com sucesso!";
                    return RedirectToAction("Login", "Account");
                }
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}