using Microsoft.AspNetCore.Mvc;

namespace NeoGym.Controllers
{
    public class TrainerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
