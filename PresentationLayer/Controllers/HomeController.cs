using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}