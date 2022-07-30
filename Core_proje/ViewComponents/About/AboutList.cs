using BusinessLayer.Concrete;
using DataAcessLayor.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_proje.ViewComponents.About
{
    public class AboutList:ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EfAbutDal());
        public IViewComponentResult Invoke()
        {
            var values = aboutManager.TGetList();
          
            return View(values);
        }
    }
}
