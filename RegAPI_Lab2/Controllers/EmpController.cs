using Microsoft.AspNetCore.Mvc;

namespace RegAPI_Lab2.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
