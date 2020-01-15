﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Szakdoga.Models;

namespace Szakdoga.Controllers
{
    [Authorize(Roles = Roles.Admin)]
    public class SportAddController : Controller
    {
        readonly ApplicationDbContext _context;

        public SportAddController() => _context = new ApplicationDbContext();
        // GET: SportAdd
        public ActionResult Index()
        {
            var sportok = _context.Sportok.ToList();
            return View("index", sportok);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult ujSport(Sport sport)
        {
            
            if (sport.Id == 0)
            {
                _context.Sportok.Add(sport);
            }
            else
            {
                var letezoSport = _context.Sportok.Single(u => u.Id == sport.Id);
                letezoSport.Nev = sport.Nev;
                letezoSport.Sportag = sport.Sportag;

            }
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public ActionResult newSport()
        {
            return View();
        }

        public ActionResult felhasznalok()
        {
            var Users = _context.Users.ToList();
            return View("felhasznalok", Users);
        }

        public ActionResult Edit(int id)
        {

            if (id == 0)
            {
                return HttpNotFound();
            }
            var letezoSport = _context.Sportok.Single(u => u.Id == id);
            var vm = new SportViewModel()
            {
                Sport = letezoSport
            };
            return View("newSport", vm);
        }

        public ActionResult Delete(int id)
        {
            if (id == 0)
            {
                return HttpNotFound();
            }

            var letezoSport = _context.Sportok.Single(u => u.Id == id);

            _context.Sportok.Remove(letezoSport);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

    }


}