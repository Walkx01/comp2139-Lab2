using lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Fifteen = 0;
            ViewBag.Twenty = 0;
            ViewBag.TwentyFive = 0;

            return View();
        }
        [HttpPost]
        public IActionResult Index(TipCalculator tip)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Fifteen = tip.calculateTip(0.15);
                ViewBag.Twenty = tip.calculateTip(0.20);
                ViewBag.TwentyFive = tip.calculateTip(0.25);
              
            }
            else
            {
                ViewBag.Fifteen = 0;
                ViewBag.Twenty = 0;
                ViewBag.TwentyFive = 0;
            }
            return View(tip);
        }
    }
}
