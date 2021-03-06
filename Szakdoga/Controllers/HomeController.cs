﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Szakdoga.Models;

namespace Szakdoga.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        readonly ApplicationDbContext _context;

        public HomeController() 
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var Hirdetesek = _context.Hirdetesek.OrderByDescending(u => u.Id).Take(3).ToList();
            return View("Index",Hirdetesek);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}