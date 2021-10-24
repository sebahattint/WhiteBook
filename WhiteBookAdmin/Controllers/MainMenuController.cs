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
    public class MainMenuController : Controller
    {
        IMainMenuService _mainMenuService;

        public MainMenuController(IMainMenuService mainMenuService)
        {
            _mainMenuService = mainMenuService;
        }

        public IActionResult Index()
        {
            var result=_mainMenuService.GetAll();
            return View(result);
        }
        public IActionResult Delete(int id)
        {
            var result = _mainMenuService.Get(id);
            _mainMenuService.Delete(result);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(MainMenu mainMenu)
        {
            _mainMenuService.Add(mainMenu);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var result = new MainMenuAddModel
            {
                MainMenu = _mainMenuService.Get(id)
            };
            return View(result);
        }
        [HttpPost]
        public IActionResult Update(MainMenu mainMenu)
        {
            _mainMenuService.Update(mainMenu);
            return RedirectToAction("Index");
        }


    }
}
