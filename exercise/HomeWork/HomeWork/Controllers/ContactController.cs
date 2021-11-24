using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.bannerTextHeader = "Contact Us";
            ViewBag.bannerTextBody = "Drop us Message for any Query";
            return View();
        }
    }
}
