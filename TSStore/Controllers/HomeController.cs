using Microsoft.AspNetCore.Mvc;

namespace TSStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
