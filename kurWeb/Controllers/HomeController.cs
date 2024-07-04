using Microsoft.AspNetCore.Mvc;

namespace kurWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
