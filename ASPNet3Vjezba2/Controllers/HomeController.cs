using ASPNet3Vjezba2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNet3Vjezba2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Forma() {


            return View();
        }
        [HttpPost]
        public ActionResult Forma(FormaPodaci a) {

            FormaContext db = new FormaContext();

            db.Settings.Add(a);
            db.SaveChanges();
            return View("Forma2");



        }
        public ActionResult Prikazi() {

            FormaContext db = new FormaContext();
            var poruke = db.Settings.ToList();
            return View(poruke);
        }
    }
}