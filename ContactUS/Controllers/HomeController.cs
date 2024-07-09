using ConatactUs.Services;
using ContactUs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;

namespace ContactUs.Controllers
{
    public class HomeController : Controller


    {
        private ILogger<HomeController> _logger;
        private ITransientNumberService _transientNumberService;
        private IScopeNumberService _scopeNumberService;
        private ISingletonNumberService _singletonNumberService;

        public HomeController(ITransientNumberService transientNumberService, IScopeNumberService scopeNumberService, ISingletonNumberService singletonNumberService, ILogger<HomeController> logger)
        {
            _transientNumberService = transientNumberService;
            _scopeNumberService = scopeNumberService;
            _singletonNumberService = singletonNumberService;
            _logger = logger;
        }


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
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("kkkk", "Test Error");
                return View("Index",message);

            }
            if (message.PhoneNumber.Length == 11) {
                TempData["IsSuccess"] = true;
                DataBase.DataBase.Messages.Add(message);
                return Redirect("/home/Messages");
            }

            return Redirect("/home/Messages");
        }

        public IActionResult Project(string name)
        {
            return View(model: name);
        }

        [HttpGet("/codeyad/hello")]
        public IActionResult Privacy(string name)
        {
            return View(model: name);
        }

        
    }
}
