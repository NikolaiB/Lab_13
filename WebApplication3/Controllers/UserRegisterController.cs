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


        public IActionResult Register([FromForm] string name, [FromForm] int age, [FromForm] string email, [FromForm] string pass, [FromForm] string confPass)
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
