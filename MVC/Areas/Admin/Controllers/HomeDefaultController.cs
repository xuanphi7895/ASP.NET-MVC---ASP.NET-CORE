using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Areas.Admin.Controllers
{
    public class HomeDefaultController : Controller
    {
        // GET: Admin/HomeDefault
        [HttpGet]
        public ActionResult IndexDefault()
        {
            return View();
        }
        [HttpGet]
        public ActionResult LeftMenu()
        {
            return View();
        }
        //Function1: C# version  1
        //public ActionResult SideBar()
        //{
        //    return View();
        //}
        //Function1: C# version  4: 
        [HttpGet]
        public ActionResult SideBar() => PartialView();
    }
}