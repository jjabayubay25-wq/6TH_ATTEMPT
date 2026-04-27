using Microsoft.AspNetCore.Mvc;
using ParaboloidApp.Models;

namespace ParaboloidApp.Controllers
{
    public class ParaboloidController : Controller
    {
        [HttpGet]
        public IActionResult Index(double a = 2.0, double b = 3.0, double h = 5.0)
        {
            var model = new ParaboloidViewModel
            {
                A = a,
                B = b,
                H = h
            };
            return View(model);
        }
    }
}