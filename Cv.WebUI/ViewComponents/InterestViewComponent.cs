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
    public class InterestViewComponent:ViewComponent
    {
        private IInterestService _ınterestService;
        public InterestViewComponent(IInterestService ınterestService)
        {
            _ınterestService = ınterestService;
        }

        public IViewComponentResult Invoke()
        {
            return View(new InterestListViewModel
            {
                Interests=_ınterestService.GetList()
            });
        }
    }
}
