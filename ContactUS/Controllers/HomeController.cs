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

        public IActionResult Messages()
        {
            return View(DataBase.DataBase.Messages);
        }

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            DataBase.DataBase.Messages.Add(message);
            return Redirect("/home/Messages");
        }
    }
}
