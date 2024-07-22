using Microsoft.AspNetCore.Mvc;

namespace Master_Layout.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
