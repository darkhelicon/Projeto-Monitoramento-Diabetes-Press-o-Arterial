using FluentValidation.Results;
using HealthMonitoring.Models;
using HealthMonitoring.Validator;
using Microsoft.AspNetCore.Mvc;

namespace HealthMonitoring.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            UserViewModel user = new UserViewModel();
            UserValidator validator = new UserValidator();

            ValidationResult results = validator.Validate(user);

            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                }
            }
            return View("Index", user);
        }
        public IActionResult SignUp() 
        { 
            return View(); //ou "SignUp"
        }
        public IActionResult Forgot() 
        { 
            return View(); //ou "Forgot"
        }
        public IActionResult Reset() 
        { 
            return View(); //ou "Reset"
        }
        public IActionResult Home() 
        { 
            return View(); //ou "Home"
        }
    }
}
