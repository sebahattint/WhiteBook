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
    public class SubmenuController : Controller
    {
        ISubMenuService _subMenuService;

        public SubmenuController(ISubMenuService subMenuService)
        {
            _subMenuService = subMenuService;
        }

        public IActionResult Index()
        {
            var result = _subMenuService.GetAll();
            return View(result);
        }
        public IActionResult Delete(int id)
        {
            var result = _subMenuService.Get(id);
            _subMenuService.Delete(result);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Submenu submenu)
        {
            _subMenuService.Add(submenu);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var result = new SubmenuAddModel
            {
                Submenu = _subMenuService.Get(id)
            };
            return View(result);
        }
        [HttpPost]
        public IActionResult Update(Submenu submenu )
        {
            _subMenuService.Update(submenu);
            return RedirectToAction("Index");
        }

    }
}
