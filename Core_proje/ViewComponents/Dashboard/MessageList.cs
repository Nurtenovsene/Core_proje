using BusinessLayer.Concreate;
using DataAcessLayor.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_proje.ViewComponents.Dashboard
{
    public class MessageList:ViewComponent
    {
        UserMessageManager messageManager = new UserMessageManager(new EfUserMessageDal());
 
        public IViewComponentResult Invoke()
        {
            var Values = messageManager.GetUserMessageWithUserService();
            return View(Values);
        }
    }
}
