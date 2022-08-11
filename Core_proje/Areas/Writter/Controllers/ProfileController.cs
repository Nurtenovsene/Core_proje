using Core_proje.Areas.Writter.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Core_proje.Areas.Writter.Controllers
{
    [Area("Writter")]
    [Route("Writter/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly UserManager<WriterUser> _userManager;

        public ProfileController(UserManager<WriterUser> userMnager, IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _userManager = userMnager;
        }
        [HttpGet]

        public async Task<IActionResult> Index()
        {
            var Values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.Name = Values.Name;
            model.SurName = Values.Surname;
            model.PictureUrl = Values.ImageUrl;
            return View(model);

        }


        [HttpPost]
        public IActionResult Index(UserEditViewModel p, IFormFile Picture)
        {
            var user = _userManager.FindByNameAsync(User.Identity.Name).Result;
            {
                if (Picture != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        var fileName = System.IO.Path.GetFileName(Picture.FileName);
                        var fileNameWithOutExtension = System.IO.Path.GetFileNameWithoutExtension(Picture.FileName);
                        var myUniqueFileName = Convert.ToString(Guid.NewGuid());
                        var fileExtension = System.IO.Path.GetExtension(fileName);
                        var newFileName = String.Concat(myUniqueFileName, fileExtension);
                        var Upload = System.IO.Path.Combine(_hostingEnvironment.WebRootPath, @"UserImage\", newFileName);
                        Picture.CopyTo(new FileStream(Upload, FileMode.Create));
                        user.ImageUrl = Upload.ToString();
                    }
                }
                user.Name = p.Name;
                user.Surname = p.SurName;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
                var result = _userManager.UpdateAsync(user).Result;
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                return View();
            }
        }
    }
}