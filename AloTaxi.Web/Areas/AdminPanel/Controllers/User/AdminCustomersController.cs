using AloTaxi.Web.Areas.AdminPanel.Controllers.AdminBase;
using Microsoft.AspNetCore.Mvc;

namespace AloTaxi.Web.Areas.AdminPanel.Controllers.User
{
    [Route("admin/customers")]
    public class AdminCustomersController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
