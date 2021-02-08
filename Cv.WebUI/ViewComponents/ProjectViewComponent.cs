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
    public class ProjectViewComponent:ViewComponent
    {
        private IProjectService _projectService;
        public ProjectViewComponent(IProjectService projectService)
        {
            _projectService = projectService;
        }

        public IViewComponentResult Invoke()
        {
            return View(new ProjectListViewModel
            {
                Projects=_projectService.GetList()
            });
        }
    }
}
