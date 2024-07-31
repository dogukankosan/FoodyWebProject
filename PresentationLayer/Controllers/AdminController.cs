using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Panel()
        {
            return View();
        }
    }
}