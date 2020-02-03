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
            Korosztaly korosztaly = new Korosztaly();
            var sportLista = _context.Sportok.ToList();
            var korosztalyLista = korosztaly.korosztalyLista;

            HirdetesAddViewModel model = new HirdetesAddViewModel();
            model.Sport = sportLista;
            model.KrosztalyLista = korosztalyLista;

            return View("ujHirdetes",model);
        }
        public ActionResult HirdetesAdd(SportHirdetes sportHirdetes) 
        {
            if (sportHirdetes.Id == 0)
            {
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
    }
}