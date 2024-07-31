using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class HeaderAdminComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}