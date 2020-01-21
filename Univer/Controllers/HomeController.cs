using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Univer.Models;

namespace Univer.Controllers
{
    public class HomeController : Controller
    {
        private UniverContext db = new UniverContext();

        public ActionResult Index()
        {
            var courses = db.Courses;
            ViewBag.Courses = courses;
            return View();
        }
    }
}