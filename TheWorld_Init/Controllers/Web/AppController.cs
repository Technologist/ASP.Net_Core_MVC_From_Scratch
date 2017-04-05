using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TheWorld_Init.Models;
using TheWorld_Init.Services;
using TheWorld_Init.ViewModules;

namespace TheWorld_Init.Controllers.Web
{
    //Install-Package Microsoft.AspNetCore.Mvc
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        private readonly IConfigurationRoot _config;
        private WorldContext _context;

        public AppController(IMailService mailService , IConfigurationRoot config,WorldContext context)
        {
            _mailService = mailService;
            _config = config;
            _context = context;
        }
        public IActionResult Index()
        {
            //var data = _context.Trips.ToList();

            //return View(data);
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModule model)
        {
            if (model.Email.Contains("gmail.com"))
            {
                ModelState.AddModelError("","gmail is not supported");

            }
            else if (ModelState.IsValid)
            {
                _mailService.SendMail( _config["MailSettings:ToAddress"] ,model.Email,"From TheWorld" , model.Message);
                ModelState.Clear();
                ViewBag.UserMessage = "Message Sent!";
            }
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

    }
}
