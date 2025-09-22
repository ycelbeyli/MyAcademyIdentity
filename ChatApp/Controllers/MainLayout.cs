using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers
{
    public class MainLayout : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
