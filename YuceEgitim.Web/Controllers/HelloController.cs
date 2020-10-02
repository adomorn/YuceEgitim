using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YuceEgitim.Database;
using YuceEgitim.Services;

namespace YuceEgitim.Web.Controllers
{
    public class HelloController : Controller
    {
        private readonly EgitimDbContext _db;
        private readonly ICounterService _counterService;

        public HelloController(EgitimDbContext db, ICounterService _counterService)
        {
            _db = db;
            this._counterService = _counterService;
        }

        public IActionResult Index()
        {
            //var users = _db.Users.IgnoreQueryFilters().ToList();
            //var ilkKayit = _db.Users.FirstOrDefault();
            //_db.Users.Remove(ilkKayit);
            //_db.SaveChanges();
            _counterService.AddToMyList(4);
            var list =  _counterService.GetMyList();

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
