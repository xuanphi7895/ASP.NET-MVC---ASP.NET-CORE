using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Areas.Admin.Controllers.Charts
{
    public class ChartjsController : Controller
    {
        // GET: Admin/Chartjs
        [HttpGet]
        public ActionResult ChartsJS()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Flot() => View();
        [HttpGet]
        public ActionResult Inline() => View();
        [HttpGet]
        public ActionResult Morris() => View();
    }
}