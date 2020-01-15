using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Szakdoga.Models;

namespace Szakdoga.Controllers
{
    [Authorize(Roles=Roles.Admin)]
    public class SportAddController : Controller
    {
        readonly ApplicationDbContext _context;

        public SportAddController() => _context = new ApplicationDbContext();
        // GET: SportAdd
        public ActionResult Index()
        {
            var sportok = _context.Sportok.ToList();
            return View("index",sportok);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult ujSport(Sport sport) 
        { 
            if(!ModelState.IsValid)
            {
                var vm = new SportViewModel
                {
                    Sport = sport
                };
                return View("newSport", vm);
            }
            if (sport.Id==0)
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
            return View("felhasznalok",Users);
        }


    }
}