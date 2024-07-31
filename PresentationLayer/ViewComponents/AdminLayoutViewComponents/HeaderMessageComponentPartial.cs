using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class HeaderMessageComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}