using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Szakdoga.Controllers
{
    public class HirdetesController : Controller
    {
        // GET: Hirdetes
        public ActionResult Index()
        {
            return View();
        }
    }
}