using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using ProjektniCentar.Models.CentarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjektniCentar.Controllers
{
    public class HomeController : Controller
    {
        private CentarContext db = new CentarContext();

        [Authorize]
        public ActionResult Index()
        {
            var userName = User.Identity.GetUserName();
            var KorisnikUserName = db.Korisniks.Where(c => c.Username ==(userName)).First().Username;

            ViewBag.KorisnikUserName = KorisnikUserName;

            return View();
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