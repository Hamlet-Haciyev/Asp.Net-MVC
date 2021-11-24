using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Login";
            return View();
        }
    }
}
