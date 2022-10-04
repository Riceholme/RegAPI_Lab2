using Microsoft.AspNetCore.Mvc;

namespace RegAPI_Lab2.Controllers
{
    public class DepController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
