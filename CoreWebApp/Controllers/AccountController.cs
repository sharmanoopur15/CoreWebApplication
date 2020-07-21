using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreWebApp.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CoreWebApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            RegisterViewModel registerViewModel = new RegisterViewModel();
            return View(registerViewModel);
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel registe)
        {
            if (ModelState.IsValid)
            {
                return View(new RegisterViewModel());
            }

            RegisterViewModel registerViewModel = new RegisterViewModel();
            return View(registerViewModel);
        }
    }
}
