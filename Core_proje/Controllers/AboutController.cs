
using BusinessLayer.Concrete;
using DataAcessLayor.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_proje.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAbutDal());

        [HttpGet]
        public IActionResult Index()
        {

            ViewBag.v1 = "Düzenleme";
            ViewBag.v2 = "Hakkımda ";
            ViewBag.v3 = "Hakkımda Sayfası";
            var values =aboutManager.TGetByID(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(About about)
        {
            aboutManager.TUpdate(about);
            return RedirectToAction("Index", "Default");

        }
    }
}
