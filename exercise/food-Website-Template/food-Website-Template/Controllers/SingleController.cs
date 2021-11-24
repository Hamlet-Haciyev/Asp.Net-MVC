using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace food_Website_Template.Controllers
{
    public class SingleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
