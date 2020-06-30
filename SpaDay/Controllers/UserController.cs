using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Data;
using SpaDay.Models;
using SpaDay.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);
        }

        [HttpPost]
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                if(addUserViewModel.Password == addUserViewModel.VerifyPassword)
                {
                    User newUser = new User
                    {
                        Username = addUserViewModel.Username,
                        Password = addUserViewModel.Password,
                        Email = addUserViewModel.Email
                    };
                    return View("Index", newUser);
                }
                else
                {
                    return View("Add", addUserViewModel);
                }
            }
            else
            {
                return View("Add", addUserViewModel);
            }
        }
        public IActionResult Delete()
        {
            ViewBag.users = UserData.GetAll();

            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] userIds)
        {
            foreach (int userId in userIds)
            {
                UserData.Remove(userId);
            }

            return Redirect("/User");
        }

    }
}
