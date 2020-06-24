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
        [Route("/user/add")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (newUser.Password == verify)
            {
                UserData.Add(newUser);
                ViewBag.username = newUser.Username;
                return View("index");
            }
            ViewBag.user = newUser;
            return Redirect("/user/error");
        }

        [HttpGet]
        [Route("/user/error")]
        public IActionResult Error()
        {
            return View();
        }

    }
}
