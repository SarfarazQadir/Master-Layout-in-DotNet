using Microsoft.AspNetCore.Mvc;

namespace Master_Layout.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
