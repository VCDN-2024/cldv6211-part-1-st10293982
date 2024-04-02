using Microsoft.AspNetCore.Mvc;

namespace st10293982.Controllers
{
    public class MyWork : Controller
    {
        public IActionResult Index()
        {
            return View("Work");
        }
    }
}
