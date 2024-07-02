using ContactUs.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactUs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            return Redirect("/home/Messages");
        }
    }
}
