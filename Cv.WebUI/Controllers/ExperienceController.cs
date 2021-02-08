using Cv.Business.Abstract;
using Cv.Entities.Concrete;
using Cv.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cv.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ExperienceController : Controller
    {
        private IExperienceService _experienceService;
        public ExperienceController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }
        public IActionResult Index()
        {
            return View(new ExperienceListViewModel
            {
                Experiences=_experienceService.GetList()
            });
        }

        public IActionResult Add()
        {
            return View();
        }

        public JsonResult storeAdd(Experience experience)
        {
            _experienceService.Add(experience);
            return Json("Başarıyla eklendi");
        }

        public IActionResult Update(int id)
        {
            return View(new ExperienceUpdateViewModel
            {
                Experience = _experienceService.GetById(id)
            });
        }

        public JsonResult storeUpdate(Experience experience)
        {
            _experienceService.Update(experience);
            return Json("Başarıyla güncellendi");
        }

       
    }
}
