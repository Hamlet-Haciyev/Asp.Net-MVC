using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.Controllers
{
    public class Services1Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.bannerTextHeader = "Services";
            ViewBag.bannerTextBody = "Our Services";
            return View();
        }
    }
}
