using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TheWorld_Init.Services;
using TheWorld_Init.ViewModules;

namespace TheWorld_Init.Controllers.Web
{
    //Install-Package Microsoft.AspNetCore.Mvc
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        private IConfigurationRoot _config;

        public AppController(IMailService mailService , IConfigurationRoot config)
        {
            _mailService = mailService;
            _config = config;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModule model)
        {
            _mailService.SendMail( _config["MailSettings:ToAddress"] ,model.Email,"From TheWorld" , model.Message);
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

    }
}
