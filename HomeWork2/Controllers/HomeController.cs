using Microsoft.AspNetCore.Mvc;

namespace HomeWork2.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
