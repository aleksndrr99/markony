using Microsoft.AspNet.Identity;
using ProjektniCentar.Models.CentarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjektniCentar.Controllers
{
    [Authorize]
    public class KorisnikController : Controller
    {
        private CentarContext db = new CentarContext();
        // GET: Korisnik
        public ActionResult Index()
        {
            return View();
        }

        // GET: Korisnik/Details/5
        public ActionResult Details(int id)
        {
            var userId = User.Identity.GetUserId();
            var KorisnikId = db.Kontakts.Where(c => c.ID == Convert.ToInt32(userId)).First().ID;
            return View();
        }

        // GET: Korisnik/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Korisnik/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Korisnik/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Korisnik/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Korisnik/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Korisnik/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
