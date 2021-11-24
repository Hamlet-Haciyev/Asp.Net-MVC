using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.bannerTextHeader = "About";
            ViewBag.bannerTextBody = "The Strax Story";

            return View();
        }
    }
}
