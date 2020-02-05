using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Szakdoga.Models;
using Microsoft.AspNet.Identity;

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
            Korosztaly korosztaly = new Korosztaly();
            var sportLista = _context.Sportok.ToList();
            var korosztalyLista = korosztaly.korosztalyLista;

            HirdetesAddViewModel model = new HirdetesAddViewModel();
            model.Sport = sportLista;
            model.KrosztalyLista = korosztalyLista;
            return View("Index", model);
        }
        public ActionResult UjHirdetes()
        {
            Korosztaly korosztaly = new Korosztaly();
            var sportLista = _context.Sportok.ToList();
            var korosztalyLista = korosztaly.korosztalyLista;

            HirdetesAddViewModel model = new HirdetesAddViewModel();
            model.Sport = sportLista;
            model.KrosztalyLista = korosztalyLista;

            return View("ujHirdetes", model);
        }
        public ActionResult Hirdeteseim()
        {
            string currentUserId = User.Identity.GetUserId();
            var sajathirdetesek = _context.Hirdetesek.Where(u => u.UserId == currentUserId).ToList();
            return View("Hirdeteseim", sajathirdetesek);
        }
        public ActionResult HirdetesAdd(SportHirdetes sportHirdetes)
        {
            if (sportHirdetes.Id == 0)
            {
                sportHirdetes.UserId = User.Identity.GetUserId();
                _context.Hirdetesek.Add(sportHirdetes);
            }
            else
            {
                var letezoHirdetes = _context.Hirdetesek.Single(u => u.Id == sportHirdetes.Id);
                letezoHirdetes.Nev = sportHirdetes.Nev;
                letezoHirdetes.sportId = sportHirdetes.sportId;
                letezoHirdetes.SportoloLetszam = sportHirdetes.SportoloLetszam;
                letezoHirdetes.Korosztaly = sportHirdetes.Korosztaly;
                letezoHirdetes.Leiras = sportHirdetes.Leiras;
            }
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult Edit(int id)
        {

            if (id == 0)
            {
                return HttpNotFound();
            }
            var letezoHirdetes = _context.Hirdetesek.Single(u => u.Id == id);
            var sportLista = _context.Sportok.ToList();
            Korosztaly korosztaly = new Korosztaly();
            var vm = new HirdetesAddViewModel()
            {
                sportHirdetes = letezoHirdetes,
                Sport = sportLista,
                KrosztalyLista = korosztaly.korosztalyLista
            };
            return View("UjHirdetes", vm);
        }
        public ActionResult Delete(int id)
        {
            if (id == 0)
            {
                return HttpNotFound();
            }

            var letezoHirdetes = _context.Hirdetesek.Single(u => u.Id == id);

            _context.Hirdetesek.Remove(letezoHirdetes);
            _context.SaveChanges();
            return RedirectToAction("Hirdeteseim");
        }
        public ActionResult _HirdetesSearch(int sportId=0,string korosztalyId="")
        {
            if (sportId==0||korosztalyId=="")
            {

                var Hirdetesek = _context.Hirdetesek.ToList();
                return PartialView("_HirdetesSearch", Hirdetesek);
            }
            else
            {
                var Hirdetesek = _context.Hirdetesek.Where(h => h.sportId == sportId && h.Korosztaly == korosztalyId).ToList();
                return PartialView("_HirdetesSearch", Hirdetesek);
            }

        }
    }
}