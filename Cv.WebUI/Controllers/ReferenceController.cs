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
    public class ReferenceController : Controller
    {
        private IReferenceService _referenceService;
        public ReferenceController(IReferenceService referenceService)
        {
            _referenceService = referenceService;
        }
        public IActionResult Index()
        {
            return View(new ReferenceListViewModel
            {
                References=_referenceService.GetList()
            });
        }

        public IActionResult Add()
        {
            return View();
        }

        public JsonResult storeAdd(Reference reference)
        {
            _referenceService.Add(reference);
            return Json("Referans başarıyla eklendi");
        }

        public IActionResult Update(int id)
        {
            return View(new ReferenceUpdateViewModel
            {
                Reference = _referenceService.GetById(id)
            });
        }

        public JsonResult storeUpdate(Reference reference)
        {
            _referenceService.Update(reference);
            return Json("Referans başarıyla güncellendi");
        }

        public JsonResult delete(int id)
        {
            var reference = _referenceService.GetById(id);
            _referenceService.Delete(reference);
            return Json("Referans başarıyla silindi");
        }
    }
}
