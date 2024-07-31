using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class HeaderNotificationComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}