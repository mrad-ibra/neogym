using Microsoft.AspNetCore.Mvc;

namespace NeoGym.Controllers
{
    public class WhyUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
