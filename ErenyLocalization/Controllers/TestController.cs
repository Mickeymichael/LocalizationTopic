using Microsoft.AspNetCore.Mvc;

namespace ErenyLocalization.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
