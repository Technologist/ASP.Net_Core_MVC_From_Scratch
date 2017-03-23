using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheWorld_Init.ViewModules;

namespace TheWorld_Init.Controllers.Web
{
    //Install-Package Microsoft.AspNetCore.Mvc
    public class AppController : Controller
    {
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
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

    }
}
