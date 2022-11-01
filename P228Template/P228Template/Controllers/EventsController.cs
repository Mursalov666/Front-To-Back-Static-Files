using Microsoft.AspNetCore.Mvc;

namespace P228Template.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
