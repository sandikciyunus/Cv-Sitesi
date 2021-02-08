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
    public class CertificateViewComponent:ViewComponent
    {
        private ICertificationService _certificationService;
        public CertificateViewComponent(ICertificationService certificationService)
        {
            _certificationService = certificationService;
        }

        public IViewComponentResult Invoke()
        {
            return View(new CerticationListViewModel
            {
               Certifications=_certificationService.GetList()
            });
        }
    }
}
