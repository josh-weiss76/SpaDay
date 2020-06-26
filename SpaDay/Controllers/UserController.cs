using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Data;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Users = UserData.GetAll();
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/User")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (newUser.Password == verify)
            {
                ViewBag.user = newUser;
                return View("Index");
            }
            ViewBag.error = "Passwords do not match! Try again";
            ViewBag.userName = newUser.Username;
            ViewBag.eMail = newUser.Email;
            return View("Add");
        }

        [HttpGet]
        [Route("/user/error")]
        public IActionResult Error()
        {
            return View();
        }

    }
}
