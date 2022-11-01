using Microsoft.AspNetCore.Mvc;

namespace P228Template.Controllers
{
    public class TrainersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
