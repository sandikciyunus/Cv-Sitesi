using Cv.Business.Abstract;
using Cv.Entities.Concrete;
using Cv.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Cv.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private IAppUserService _appUserService;
        public HomeController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }
        public IActionResult Index()
        {
            var user = _appUserService.GetByName(User.Identity.Name);
            return View(new AppUserListViewModel
            {
                Id=user.Id,
                FirstName=user.FirstName,
                LastName=user.LastName,
                Address=user.Address,
                UserName=user.UserName,
                Password=user.Password,
                Email=user.Email,
                ImageUrl=user.ImageUrl,
                ShortDescription=user.ShortDescription,
                LınkedinLink=user.LınkedinLink,
                GithubLink=user.GithubLink,
                PhoneNumber=user.PhoneNumber
            }); 
        }

        public JsonResult update(AppUser appUser)
        {
            _appUserService.Update(appUser);
            return Json("Başarıyla güncellendi");
        }

       
    }
}
