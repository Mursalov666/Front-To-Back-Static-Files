using Microsoft.AspNetCore.Mvc;

namespace P228Template.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
