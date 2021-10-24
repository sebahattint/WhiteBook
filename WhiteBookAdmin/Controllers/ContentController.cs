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
    public class ContentController:Controller
    {
        IContentService _contentService;
        public ContentController(IContentService contentService)
        {
            _contentService = contentService;
        }
        public IActionResult Index()
        {
            var result = _contentService.GetAll();
            return View(result);
        }
        public IActionResult Delete(int id)
        {
            var result = _contentService.Get(id);
            _contentService.Delete(result);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Content content)
        {
            _contentService.Add(content);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var result = new ContentAddModel
            {
                Content = _contentService.Get(id)
            };
            return View(result);
        }
        [HttpPost]
        public IActionResult Update(Content content)
        {
            _contentService.Update(content);
            return RedirectToAction("Index");
        }
    }
}
