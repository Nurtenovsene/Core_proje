using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_proje.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.v1 = "Dashboard";
            ViewBag.v2 = "İstatistikler";
            ViewBag.v3 = "İstatistik Listesi";
          
            return View();
           
        }
    }
}
