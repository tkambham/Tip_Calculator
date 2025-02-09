using Microsoft.AspNetCore.Mvc;
using Calculator_Project.Models;

namespace Calculator_Project.Conrollers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Tip15 = 0;
            ViewBag.Tip20 = 0;
            ViewBag.Tip25 = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(TipCalculatorModel model)
        {
            ViewBag.Tip15 = model.CalculatePercent15();
            ViewBag.Tip20 = model.CalculatePercent20();
            ViewBag.Tip25 = model.CalculatePercent25();

            return View(model);
        }
    }
}