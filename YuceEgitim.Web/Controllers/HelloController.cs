using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YuceEgitim.Database;

namespace YuceEgitim.Web.Controllers
{
    public class HelloController : Controller
    {
        private readonly EgitimDbContext _db;

        public HelloController(EgitimDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var users = _db.Users.IgnoreQueryFilters().ToList();
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
