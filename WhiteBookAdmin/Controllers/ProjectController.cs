using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Whitebook.WhiteBookDto.Entities;
using WhiteBookAdmin.Models;
using WhiteBookBusiness.Abstract;

namespace WhiteBookAdmin.Controllers
{
    public class ProjectController : Controller
    {
        public IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }
        public IActionResult Index()
        {
            var result = _projectService.GetAll();
            return View(result);
        }
        public IActionResult Delete(int id)
        {
            var result = _projectService.Get(id);
            _projectService.Delete(result);
            return RedirectToAction("Index");

        }
        public IActionResult Update(int id)
        {
            var result = new ProjectUpdateModel
            {
                Project = _projectService.Get(id)
            };
            return View(result);
        }
        [HttpPost]
        public IActionResult Update(Project project)
        {
            _projectService.Update(project);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Project project)
        {
            _projectService.Add(project);
            return RedirectToAction("Index");
        }
    }
}
