using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Szakdoga.Models;

namespace Szakdoga.Controllers
{
    public class HirdetesController : Controller
    {
        // GET: Hirdetes
        readonly ApplicationDbContext _context;
        public HirdetesController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var Hirdetesek = _context.Hirdetesek.ToList();
            return View("Index",Hirdetesek);
        }
        public ActionResult UjHirdetes()
        {

            return View("UjHirdetes");
        }
    }
}