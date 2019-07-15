using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Football4Cash.Models;

namespace Football4Cash.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "DUDE FOOTBALL 4 $$$$$";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact Football4Cash.";

            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        //Should I make this as a new controller(now in home)? The welcome page will pop up after a user logs in showing them options of choosing picks, edit user name maybe, change password, etc
        [HttpPost]
        public IActionResult Welcome(string userName)
        {
            /*     Look more into validation and error messages
            if(ModelState.IsValid)
            {
                View("Register");
            }
            */
            ViewData["Message"] = $"Hello {userName}";
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
