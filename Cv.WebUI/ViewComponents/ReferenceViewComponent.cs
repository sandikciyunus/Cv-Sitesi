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
    public class ReferenceViewComponent:ViewComponent
    {
        private IReferenceService _referenceService;
        public ReferenceViewComponent(IReferenceService referenceService)
        {
            _referenceService = referenceService;
        }
        public IViewComponentResult Invoke()
        {
            return View(new ReferenceListViewModel
            {
                References=_referenceService.GetList()
            });
        }
    }
}
