﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Areas.Admin.Controllers.Forms
{
    public class FormsController : Controller
    {
        // GET: Admin/Forms
        [HttpGet]
        public ActionResult Advanced()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Editor() => View();
        [HttpGet]
        public ActionResult General() => View();
    }
}