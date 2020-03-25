using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LAB_11._2_CoffeeShop.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View("RegistrationIndex");
        }

        [HttpPost]
        public IActionResult RegistrationConfirmation(string fname, string email)
        {
            ViewData["name"] = fname;
            ViewData["email"] = email;
            return View();
        }
    }
}