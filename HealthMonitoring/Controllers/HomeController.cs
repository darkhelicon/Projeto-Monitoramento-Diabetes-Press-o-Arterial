using HealthMonitoring.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HealthMonitoring.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home()
        {
            return View("Home");
        }
        public IActionResult Medicamentos()
        {
            return View("Medicamentos");
        }
        public IActionResult Usuario()
        {
            return View("Usuario");
        }
        public IActionResult Extras()
        {
            return View("Extras");
        }
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    string query = "SELECT Categoria FROM Hiper WHERE personID = {id} && ";
        //    var department = await _context.Departments
        //        .FromSql(query, id)
        //        .Include(d => d.Administrator)
        //        .AsNoTracking()
        //        .FirstOrDefaultAsync();

        //    if (department == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(department);
        //}
    }
}