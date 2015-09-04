using System.Diagnostics;
using System.Web.Mvc;

namespace PagesJaunesResto.ApplicationPoolManager.Api.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.DateLastReset = Process.GetCurrentProcess().StartTime.ToString();
            return View();
            ViewBag.Title = "Home Page";
        }
    }
}
