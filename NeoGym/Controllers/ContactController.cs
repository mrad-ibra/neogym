using Microsoft.AspNetCore.Mvc;

namespace NeoGym.Controllers
{
    public class ContactController : Controller
    {
        [Route("salam/bu/trainer/sehifesidir")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}
