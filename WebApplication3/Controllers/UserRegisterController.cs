using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class UserRegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RegUser()
        {
            return View();
        }
        

        public IActionResult Register(string name, int age, string email, string pass, string confPass)
        {
            if (pass != confPass)
            {
                ViewBag.result = "Error";

                return View();
            }

            UserCollection model = new UserCollection();

            var user = new UserRegister()
            {
                Name = name,
                Email = email,
                Age = age,
                Password = pass,
                ConfirmPassword = confPass,

            };
            
            model.collection.Add(user);

            return View();
        }
    }
}
