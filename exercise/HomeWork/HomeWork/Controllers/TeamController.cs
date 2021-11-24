using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.bannerTextHeader = "Team";
            ViewBag.bannerTextBody = "Meet Our experts always ready to help you";
            return View();
        }
    }
}
