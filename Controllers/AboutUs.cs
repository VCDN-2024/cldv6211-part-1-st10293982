using Microsoft.AspNetCore.Mvc;

namespace st10293982.Controllers
{
    public class AboutUs : Controller
    {
        public IActionResult Index()
        {
            return View("About");
        }
    }
}
