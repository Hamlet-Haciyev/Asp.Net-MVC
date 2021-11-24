using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.Controllers
{
    public class Services2Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.bannerTextHeader = "Service Details";
            return View();
        }
    }
}
