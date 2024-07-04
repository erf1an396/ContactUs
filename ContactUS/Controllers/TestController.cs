using Microsoft.AspNetCore.Mvc;

namespace ContactUs.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
