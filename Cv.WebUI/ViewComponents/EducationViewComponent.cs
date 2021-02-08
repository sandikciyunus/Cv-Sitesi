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
    public class EducationViewComponent:ViewComponent
    {
        private IEducationService _educationService;
        public EducationViewComponent(IEducationService educationService)
        {
            _educationService = educationService;
        }

        public IViewComponentResult Invoke()
        {
            return View(new EducationListViewModel
            {
                Educations=_educationService.GetList()
            });
        }
    }
}
