using Microsoft.AspNetCore.Mvc;

namespace ContactUs.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("test/source/{name}")]
        public IActionResult Source(string name, int dd )
        {

            ViewBag.number = dd;
            return View( model: name);
        }
    }
}
