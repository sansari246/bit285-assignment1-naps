using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bit285_assignment1_naps.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bit285_assignment1_naps.Controllers
{
    public class NapsController : Controller
    {
        // GET: /<controller>/

                //[HttpGet]
        //public string AccountInfo()
        //{
        //    return "Hello World";
        //}

        /// Accounts the info page 

        [HttpGet]
        public IActionResult AccountInfo()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AccountInfo(User user) 
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("PasswordInfo",user);
            }
            else
            {
                return View();
            }
        }


        //password info 
        [HttpGet]
        public IActionResult PasswordInfo(User user)
        {
            return View(user);
        }

        [HttpPost]
        public IActionResult PasswordInfo(User user, string ss)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("SelectPassword", User);
            }
            else
            {
                return View(user);
            }
        }

        /// do we need select password get and post?

        /// <returns>The suggestion.</returns>
        /// <param name="info">Info.</param>
        //[HttpGet]
        //public IActionResult SelectPassword()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult SelectPassword(User user)
        //{
        //    user.Password = user.Password;
        //    return RedirectToAction("ConfirmAccount", user);
        //}

        //password Sugegestion
        [HttpGet]
        public IActionResult PasswordSuggestion(User info)
        {
            return View();
        }

        [HttpPost]
        public IActionResult PasswordSuggestion(User user, User info )
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("ConfirmAccount", User);
            }
            else
            {
                return View();
            }
        }

        // account confirmation

        [HttpGet]
        public IActionResult ConfirmAccount(User user)
        {
            return View(user);
        }

        [HttpPost]
        public IActionResult ConfirmAccount(User user, string ss)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("login", User);
            }
            else
            {
                return View();
            }
        }

        //Login

        [HttpGet]
        public IActionResult login(User user)
        {
            return View(user);
        }

        //[HttpPost]
        //public IActionResult login(User user, string info)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        return RedirectToAction("login", User);
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}


    }
}
