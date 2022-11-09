﻿using EntityLayer.Concretes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ReservationOfTravel.Models;
using System.Threading.Tasks;

namespace ReservationOfTravel.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public LoginController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel user)
        {
            /*Şifre "aUmut1*" */
            AppUser appUser = new AppUser()
            {
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Mail,
                UserName = user.Username
            };
            if(user.Password == user.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser,user.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError(" ", item.Description);
                    }
                }
            }
            return View(user);
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
    }
}
