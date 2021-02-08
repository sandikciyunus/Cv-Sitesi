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
    public class ProjectController : Controller
    {
        private IProjectService _projectService;
        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }
        public IActionResult Index()
        {
            return View(new ProjectListViewModel
            {
                Projects=_projectService.GetList()
            });
        }

        public IActionResult Add()
        {
            return View();
        }

        public JsonResult storeAdd(Project project)
        {
            _projectService.Add(project);
            return Json("Proje başarıyla eklendi");
        }

        public IActionResult Update(int id)
        {
            return View(new ProjectUpdateViewModel
            {
                Project = _projectService.GetById(id)
            });
        }

        public JsonResult storeUpdate(Project project)
        {
            _projectService.Update(project);
            return Json("Proje başarıyla güncellendi");
        }

        public JsonResult delete(int id)
        {
            var project = _projectService.GetById(id);
            _projectService.Delete(project);
            return Json("Proje başarıyla silindi");
        }
    }
}
