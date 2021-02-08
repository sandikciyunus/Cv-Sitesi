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
    public class InterestController : Controller
    {
        private IInterestService _interestService;
        public InterestController(IInterestService interestService)
        {
            _interestService = interestService;
        }
        public IActionResult Index()
        {
            return View(new InterestListViewModel
            {
                Interests=_interestService.GetList()
            });
        }

        public IActionResult Add()
        {
            return View();
        }

        public JsonResult storeAdd(Interest ınterest)
        {
            _interestService.Add(ınterest);
            return Json("Başarıyla eklendi");
        }

        public IActionResult Update(int id)
        {
            return View(new InterestUpdateViewModel
            {
                Interest = _interestService.GetById(id)
            });
        }

        public JsonResult storeUpdate(Interest ınterest)
        {
            _interestService.Update(ınterest);
            return Json("Başarıyla güncellendi");
        }

        public JsonResult delete(int id)
        {
            var ınterest = _interestService.GetById(id);
            _interestService.Delete(ınterest);
            return Json("Başarıyla silindi");
        }
    }
}
