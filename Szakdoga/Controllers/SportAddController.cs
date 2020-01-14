using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Szakdoga.Models;

namespace Szakdoga.Controllers
{
    public class SportAddController : Controller
    {
        readonly ApplicationDbContext _context;

        public SportAddController() => _context = new ApplicationDbContext();
        // GET: SportAdd
        public ActionResult Index()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult SportAdd(Sport sport) 
        { 
            if(!ModelState.IsValid)
            {
                var vm = new SportViewModel
                {
                    Sport = sport
                };
                return View("index", vm);
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

        
    }
}