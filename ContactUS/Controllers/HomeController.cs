﻿using ContactUs.Models;
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
            if (message.PhoneNumber.Length == 11) {
                TempData["IsSuccess"] = true;
                DataBase.DataBase.Messages.Add(message);
                return Redirect("/home/Messages");
            }

            return Redirect("/home/Messages");
        }

        public IActionResult Project()
        {
            return View(model: "asdasdasd");
        }
    }
}
