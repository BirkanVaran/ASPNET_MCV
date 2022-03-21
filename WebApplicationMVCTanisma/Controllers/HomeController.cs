using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationMVCTanisma.Controllers
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

        public ActionResult Anasayfa()
        {

            return View();
        }

        public ActionResult Deneme()
        {
            // ViewBag nedir?
            ViewBag.Ad = "Birkan ViewBag";
            ViewData["Ad"] = "Birkan ViewData"; // ViewData ile ViewBag birbirinin aynısıdır.
                                                // Ekranda ViewBag Ad içinde "Birkan ViewData"yı                                göreceğiz.
                                                // "Birkan ViewBag"i göremiyoruz. Çünkü 40. satırda                              üzerine yazdık.
                                             
            TempData["Adiniz"] = "Birkan TempData";
            return View();
        }
    }
}