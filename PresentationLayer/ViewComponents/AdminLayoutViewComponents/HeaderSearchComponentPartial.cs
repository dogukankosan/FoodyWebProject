using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class HeaderSearchComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}