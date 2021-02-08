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
    public class SkillController : Controller
    {
        private ISkillService _skillService;
        public SkillController(ISkillService skillService)
        {
            _skillService = skillService;
        }
        public IActionResult Index()
        {
            return View(new SkillListViewModel
            {
                Skills=_skillService.GetList()
            });
        }

        public IActionResult Add()
        {
            return View();
        }

        public JsonResult storeAdd(Skill skill)
        {
            _skillService.Add(skill);
            return Json("Başarıyla eklendi");
        }

        public IActionResult Update(int id)
        {
            return View(new SkillUpdateViewModel
            {
                Skill = _skillService.GetById(id)
            });
        }

        public JsonResult storeUpdate(Skill skill)
        {
            _skillService.Update(skill);
            return Json("Başarıyla güncellendi");
        }

        public JsonResult delete(int id)
        {
            var skill = _skillService.GetById(id);
            _skillService.Delete(skill);
            return Json("Başarıyla silindi");
        }
    }
}
