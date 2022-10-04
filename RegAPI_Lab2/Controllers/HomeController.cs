using Microsoft.AspNetCore.Mvc;

namespace RegAPI_Lab2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
