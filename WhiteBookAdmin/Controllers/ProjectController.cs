using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhiteBookAdmin.Controllers
{
    public class ProjectController:Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
