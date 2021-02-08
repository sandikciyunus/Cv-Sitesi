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
    public class EducationController : Controller
    {
        private IEducationService _educationService;
        public EducationController(IEducationService educationService)
        {
            _educationService = educationService;
        }
        public IActionResult Index()
        {
            return View(new EducationListViewModel { 
            Educations=_educationService.GetList()
            });
        }

        public IActionResult Add()
        {
            return View();
        }

        public JsonResult storeAdd(Education education)
        {
            _educationService.Add(education);
            return Json("Başarıyla eklendi");
        }

        public IActionResult Update(int id)
        {
            var education = _educationService.GetById(id);
            return View(new EducationUpdateViewModel
            {
                Education = education
            });
        }

          public JsonResult storeUpdate(Education education)
        {
            _educationService.Update(education);
            return Json("Başarıyla güncellendi");
        }

        public JsonResult Delete(int id)
        {
            var education = _educationService.GetById(id);
            _educationService.Delete(education);
            return Json("Başarıyla silindi");
        }
    }
}
