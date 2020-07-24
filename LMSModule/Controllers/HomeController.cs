using Microsoft.AspNetCore.Mvc;
using OrchardCore.Admin;

namespace LMSModule.Controllers
{
    [Admin]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {



            return View();
        }
    }
}
