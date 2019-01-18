using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Areas.Admin.Controllers
{
    public class PagesController : Controller
    {
        // GET: Admin/Pages
        [HttpGet]
        public ActionResult DashboardOne()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DashboardTwo() => View();
        [HttpGet]
        public ActionResult Widgets() => View();
        [HttpGet]
        public ActionResult Calendar() => View();

    }
}