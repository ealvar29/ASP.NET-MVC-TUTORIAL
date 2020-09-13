using Microsoft.AspNetCore.Mvc;

namespace CoreMvcTutorial
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}