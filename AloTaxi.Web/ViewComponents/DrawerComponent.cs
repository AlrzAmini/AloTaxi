using Microsoft.AspNetCore.Mvc;

namespace AloTaxi.Web.ViewComponents
{
    public class DrawerComponent : ViewComponent
    {
       
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("Drawer");
        }
    }
}
