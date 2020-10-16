using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YuceEgitim.Web.Controllers
{
    public class MenuViewComponent : ViewComponent
    {
        public readonly string[] menuItems;
        public MenuViewComponent()
        {
            menuItems = new string[] { "Home", "About", "Products" ,"Contact", "Gallery"};
        }
        public IViewComponentResult Invoke(bool hideLast)
        {
            return View(hideLast ? menuItems[..^1] : menuItems);
        }
    }
}
