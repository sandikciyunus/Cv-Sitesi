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
    [Authorize(Roles ="Admin")]
    public class CertificationController : Controller
    {
        private ICertificationService _certifcationService;
        public CertificationController(ICertificationService certificationService)
        {
            _certifcationService = certificationService;
        }
        public IActionResult Index()
        {
            return View(new CerticationListViewModel 
            { 
             Certifications=_certifcationService.GetList()
            });
        }

        public IActionResult Add()
        {
            return View();
        }

        public JsonResult storeAdd(Certification certification)
        {
            _certifcationService.Add(certification);
            return Json("Sertifka başarıyla eklendi");
        }

        public JsonResult delete(int id)
        {
            var certification = _certifcationService.GetById(id);
            _certifcationService.Delete(certification);
            return Json("Sertifaka başarıyla silindi");
        }

        public IActionResult Update(int id)
        {
            var certification = _certifcationService.GetById(id);
            return View(new CertificationUpdateListViewModel
            {
                Certification = certification
            });
        }

        public JsonResult storeUpdate(Certification certification)
        {
            _certifcationService.Update(certification);
            return Json("Sertifika başarıyla güncellendi");
        }
    }
}
