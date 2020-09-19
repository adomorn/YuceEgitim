using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace YuceEgitim.Web.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            TempData["Title"] = "Merhaba";
            ViewBag.Title = "Merhaba2";
            return View();
        }

        public IActionResult Index3()
        {
            TempData["Title"] = "Merhaba";
            ViewBag.Title = "Merhaba2";
            return View();
        }
    }
}
