using AloTaxi.Web.Areas.AdminPanel.Controllers.AdminBase;
using Microsoft.AspNetCore.Mvc;

namespace AloTaxi.Web.Areas.AdminPanel.Controllers.User
{
    [Route("admin/drivers")]
    public class AdminDriversController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
