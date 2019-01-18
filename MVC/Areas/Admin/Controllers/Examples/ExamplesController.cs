using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Areas.Admin.Controllers.Examples
{
    public class ExamplesController : Controller
    {
        // GET: Admin/Examples
        public ActionResult Index()
        {
            return View();
        }
    }
}