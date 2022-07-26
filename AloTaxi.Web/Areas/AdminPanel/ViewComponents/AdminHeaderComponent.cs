using Microsoft.AspNetCore.Mvc;

namespace AloTaxi.Web.Areas.AdminPanel.ViewComponents
{
    public class AdminHeaderComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("AdminHeader");
        }
    }
}
