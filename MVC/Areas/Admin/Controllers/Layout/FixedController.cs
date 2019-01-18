using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Areas.Admin.Controllers.Layout
{
    public class FixedController : Controller
    {
        // GET: Admin/Fixed
        [HttpGet]
        public ActionResult Fixed()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Boxed() => View();
        [HttpGet]
        public ActionResult CollapsedSidebar() => View();
        [HttpGet]
        public ActionResult TopNav() => View();
    }
}