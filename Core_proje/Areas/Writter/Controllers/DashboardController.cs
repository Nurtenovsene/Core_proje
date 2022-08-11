using DataAcessLayor.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core_proje.Areas.Writter.Controllers
{
    [Area("Writter")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var Values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = Values.Name + " " + Values.Surname;

            //Hava durumu kısmı dinamik hale getirilecek.
            //Weather APİ


            string api = "10b10ed96020059ae20ee3ec98412e33";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.Temperature = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            //Statics
            Context c = new Context();
            ViewBag.v1 = c.WriterMessages.Where(x => x.Receiver == Values.Email).Count();
            ViewBag.v2 = c.Announcements.Count();
            ViewBag.v3 = c.Users.Count();
            ViewBag.v4 = c.Skills.Count();


            return View();
        }
    }
}
