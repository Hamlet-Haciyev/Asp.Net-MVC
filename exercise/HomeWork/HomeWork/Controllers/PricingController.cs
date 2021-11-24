using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.bannerTextHeader = "Transparent Pricing";
            ViewBag.bannerTextBody = "Border-less account pricing";
            return View();
        }
    }
}
