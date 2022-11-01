using Microsoft.AspNetCore.Mvc;

namespace P228Template.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
