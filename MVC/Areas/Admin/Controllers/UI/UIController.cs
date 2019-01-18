using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Areas.Admin.Controllers.UI
{
    public class UIController : Controller
    {
        // GET: Admin/UI
        [HttpGet]
        public ActionResult Buttons()
        {
            return View();
        }
        [HttpGet]
        public ActionResult General() => View();
        [HttpGet]
        public ActionResult Icons() => View();
        [HttpGet]
        public ActionResult Modals() => View();
        [HttpGet]
        public ActionResult Sliders() => View();
        [HttpGet]
        public ActionResult Timeline() => View();
    }
}