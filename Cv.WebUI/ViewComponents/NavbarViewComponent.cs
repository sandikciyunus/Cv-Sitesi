using Cv.Business.Abstract;
using Cv.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cv.WebUI.ViewComponents
{
    [ViewComponent]
    public class NavbarViewComponent:ViewComponent
    {
        private IAppUserService _appUserService;
        public NavbarViewComponent(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }
        public IViewComponentResult Invoke()
        {
            return View(new AppUserListViewModel2
            {
                AppUsers = _appUserService.GetList()
            });
        }
    }
}
