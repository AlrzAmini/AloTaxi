using Microsoft.AspNetCore.Mvc;

namespace AloTaxi.Web.ViewComponents
{
    public class HeaderComponent : ViewComponent
    {
       
        public async Task<IViewComponentResult> InvokeAsync()
        {
          
            return View("Header");
        }
    }
}
