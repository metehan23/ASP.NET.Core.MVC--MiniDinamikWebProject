using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiniProje.Models;

namespace MiniProje.Controllers
{
    public class HomeController : Controller
    {
      public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            ViewBag.Greeting = saat > 12 ? "İyi Günler" : "Günaydın";
            ViewBag.UserName = "Mete";
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Details()
        {
            var proje = new Proje();
            proje.Name = "Mini Dinamik Proje";
            proje.Description = "Dinamik";
            proje.isPublished = true;
            return View(proje);
        }
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Apply(Anket anket)
        {
            if (ModelState.IsValid)
            {
                Repository.AddAnket(anket);
                return View("Thanks", anket);
            }
            else
            {
                return View(anket);
            }
            
        }
        public IActionResult List()
        {
            var anket = Repository.Ankett.Where(i => i.Confirm == true);

            return View(anket);
        }
    }
}
