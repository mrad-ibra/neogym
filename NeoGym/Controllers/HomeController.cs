using Microsoft.AspNetCore.Mvc;

namespace NeoGym.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
