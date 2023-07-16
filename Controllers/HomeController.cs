using Microsoft.AspNetCore.Mvc;
using MVCForSpeed.Models;
using System.Diagnostics;

namespace MVCForSpeed.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculate(double speedInMetersPerSecond)
        {
            // Convert m/s to km/h
            double speedInKilometersPerHour = speedInMetersPerSecond * 3.6;

            ViewBag.SpeedInKilometersPerHour = speedInKilometersPerHour;

            return View("Result");
        }
    }
}