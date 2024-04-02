using Microsoft.AspNetCore.Mvc;

namespace st10293982.Controllers
{
    public class ContactUs : Controller
    {
        public IActionResult Index()
        {
            return View("Contact");
        }
    }
}
