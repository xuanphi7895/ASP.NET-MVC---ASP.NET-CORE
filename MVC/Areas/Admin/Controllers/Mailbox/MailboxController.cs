using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Areas.Admin.Controllers.Mailbox
{
    public class MailboxController : Controller
    {
        // GET: Admin/Mailbox
        [HttpGet]
        public ActionResult Compose()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Maibox() => View();
        [HttpGet]
        public ActionResult ReadMaibox() => View();
    }
}