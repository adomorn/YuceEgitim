using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using YuceEgitim.Database;
using YuceEgitim.Services;
using YuceEgitim.Web.Classes;

namespace YuceEgitim.Web.Controllers
{
    public class HelloController : Controller
    {
        private readonly EgitimDbContext _db;
        private readonly ICounterService _counterService;
        private readonly MusteriOptions MusteriOptions;
        private readonly ITicket _ticket;

        public HelloController(EgitimDbContext db, ICounterService _counterService, ITicket ticket, IOptions<MusteriOptions> options)
        {
            _db = db;
            _ticket = ticket;
            this._counterService = _counterService;
            MusteriOptions = options.Value;
        }

        public IActionResult Index()
        {
            //var users = _db.Users.IgnoreQueryFilters().ToList();
            //var ilkKayit = _db.Users.FirstOrDefault();
            //_db.Users.Remove(ilkKayit);
            //_db.SaveChanges();
            _counterService.AddToMyList(4);
            var list = _counterService.GetMyList();

            TempData["Title"] = _ticket.IPAddress;
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
