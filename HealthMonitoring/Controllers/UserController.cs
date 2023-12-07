using Common;
using FluentValidation.Results;
using HealthMonitoring.Models;
using HealthMonitoring.Validator;
using Microsoft.AspNetCore.Mvc;

namespace HealthMonitoring.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Edit(UserViewModel model) 
        { 
            return View(model ?? new UserViewModel()); //ou "Edit"
        }
    }
}
