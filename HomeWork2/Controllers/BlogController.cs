using Microsoft.AspNetCore.Mvc;

namespace HomeWork2.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
