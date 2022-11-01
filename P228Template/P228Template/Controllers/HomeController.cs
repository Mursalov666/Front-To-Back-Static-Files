using Microsoft.AspNetCore.Mvc;

namespace P228Template.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
