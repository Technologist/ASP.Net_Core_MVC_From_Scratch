using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheWorld_Init.Models;

namespace TheWorld_Init.Controllers.Api
{
    public class TripsController : Controller
    {
        public JsonResult Get()
        {
            return Json(new Trip() {Name = "My Trip"});
        }
    }
}
