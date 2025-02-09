using Microsoft.AspNetCore.Mvc;

namespace Calculator_Project.Conrollers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }
    }
}