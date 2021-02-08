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
    public class SkillViewComponent:ViewComponent
    {
        private ISkillService _skillService;
        public SkillViewComponent(ISkillService skillService)
        {
            _skillService = skillService;
        }

        public IViewComponentResult Invoke()
        {
            return View(new SkillListViewModel
            {
                Skills=_skillService.GetList()
            });
        }
    }
}
