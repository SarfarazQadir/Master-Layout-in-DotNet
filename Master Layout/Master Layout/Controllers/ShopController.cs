using Microsoft.AspNetCore.Mvc;

namespace Master_Layout.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
