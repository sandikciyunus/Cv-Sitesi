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
    public class ExperienceViewComponent:ViewComponent
    {
        private IExperienceService _experienceService;
        public ExperienceViewComponent(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }
        public IViewComponentResult Invoke()
        {
            return View(new ExperienceListViewModel
            {
                Experiences = _experienceService.GetList().OrderByDescending(p=>p.Id).ToList()
            });
        }
    }
}
