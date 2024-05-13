using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciNotMvc.Controllers
{
    public class HesapTestController : Controller
    {
        // GET: HesapTest
        public ActionResult Index(double sayi1 = 0, double sayi2 = 0)
        {

            double sonucTopla = sayi1 + sayi2;
            ViewBag.sncTopla = sonucTopla;

            double sonucCikarma = sayi1 - sayi2;
            ViewBag.sncCikarma = sonucCikarma;

            double sonucCarpma = sayi1 * sayi2;
            ViewBag.sncCarpma = sonucCarpma;

            if (sayi2 == 0)
            {
                Console.WriteLine("sayi2 0 olamaz");

            }
            else
            {
                double sonucBolme = sayi1 / sayi2;
                ViewBag.scnBolme = sonucBolme;
            }




            return View();
        }
    }
}