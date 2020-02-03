using System;
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
                letezoSport.sportagId = sport.sportagId;
            }
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public ActionResult newSport()
        {
            var sportLista = _context.Sportagak.ToList();

            SportViewModel model = new SportViewModel();
            model.sportagLista = sportLista;
            return View(model);
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
            var sportLista = _context.Sportagak.ToList();
            var vm = new SportViewModel()
            {
                Sport = letezoSport,
                sportagLista = sportLista

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


        [ValidateAntiForgeryToken]
        public ActionResult Ujfelhasznalo(ApplicationUser user)
        {
            if (user.Id == null)
            {
                _context.Users.Add(user);
            }
            else
            {
                var letezoUser = _context.Users.Single(u => u.Id == user.Id);
                letezoUser.Vezeteknev = user.Vezeteknev;
                letezoUser.Keresztnev = user.Keresztnev;
                letezoUser.Email = user.Email;
                letezoUser.UserName = user.UserName;
                letezoUser.BirthDate = user.BirthDate;

            }
            _context.SaveChanges();
            return RedirectToAction("felhasznalok");
        }
        public ActionResult DeleteUser(string id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var letezoUser = _context.Users.Single(u => u.Id == id);

            _context.Users.Remove(letezoUser);
            _context.SaveChanges();
            return RedirectToAction("felhasznalok");
        }

        public ActionResult FelhaszaloEdit(string id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var letezoUser = _context.Users.Find(id);
            var vm = new UserViewModel()
            {
                User = letezoUser
            };
            return View("felhasznaloModosit", vm);
        }

    }


}