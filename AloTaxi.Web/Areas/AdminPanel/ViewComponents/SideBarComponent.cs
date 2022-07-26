using Microsoft.AspNetCore.Mvc;

namespace AloTaxi.Web.Areas.AdminPanel.ViewComponents
{
    public class SideBarComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("SideBar");
        }
    }
}
