using ASPNet3Vjezba2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNet3Vjezba2.Controllers
{
    public class KontaktController : Controller
    {
        // GET: Kontakt
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Kontakt() {

            return View();
        }

        [HttpPost]
        public ActionResult Kontakt(KontaktPodaci k) {

            KontaktContext db = new KontaktContext();

            if (k.PostanskiBroj != 31000 && k.PostanskiBroj != 10000) {
                //poruka korisniku da dostavljamo samo u Osijek i Zagreb
                ViewBag.greska = "Vaša narudžba se ne može izvršiti jer se ne nalazite na području Osijeka ili Zagreba";
                return View("KontaktPogreska");
            }
            if (k.KucniBroj < 1) {
                //poruka korisniku da kucni broj nije ispravan
                ViewBag.greska = "Neispravan kućni broj";
                return View("KontaktPogreska");
            }
            db.Podaci.Add(k);
            db.SaveChanges();
            return View("Kontakt2");

            
        }
    }
}