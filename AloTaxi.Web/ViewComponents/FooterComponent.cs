using Microsoft.AspNetCore.Mvc;

namespace AloTaxi.Web.ViewComponents
{
    public class FooterComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("Footer");
        }
    }
}
