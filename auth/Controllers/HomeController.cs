using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using auth.Models;

namespace auth.Controllers
{
    public class HomeController : Controller
    {
        public EksaProjectEntities db = new EksaProjectEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hakkında()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult KullanıcıGirisi()
        {
            return View();
        }

        public ActionResult Randevu()
        {
            return View();
        }

        public ActionResult BizeUlasın()
        {
            return View();
        }

        public ActionResult BizeUlas()
        {
            return View();
        }

        public ActionResult Doktorlar()
        {
            Doctors doctors = new Doctors();
            doctors.Doctor = db.Doctor.ToList();
            doctors.Section = db.Section.ToList();
            return View(doctors);
        }

        public ActionResult RandevuAl()
        {
            return View();
        }

        public ActionResult KullanıcıGiris()
        {
            return View();
        }

        public ActionResult KullanıcıEkranı()
        {
            return View();
        }

        public ActionResult ilacHatırlatıcı()
        {
            Medicines Medicine = new Medicines();
            Medicine.Medicine = db.Medicine.ToList();
            Medicine.MedicineReminder = db.MedicineReminder.ToList();
            return View(Medicine);
        }

        public ActionResult addReminder(string day1, string clock1, string Select, string Select2)
        {
            MedicineReminder yeni = new MedicineReminder();

            if (Select != null && Select2 != null && clock1 != null && day1 != null)
            {
                yeni.identityNumber = "160313008";
                yeni.medicineId = int.Parse(Select);
                yeni.start = DateTime.Now;
                yeni.reuse = int.Parse(clock1);
                yeni.day = int.Parse(day1);
                yeni.clock = Select2;
                yeni.used = false;

                db.MedicineReminder.Add(yeni);
                db.SaveChanges();
            }
            return RedirectToAction("ilacHatırlatıcı", "Home");
            
        }

        public ActionResult TahlilSorgulama()
        {
            return View();
        }

        public ActionResult BlogSayfası()
        {
            return View();
        }

        public ActionResult SingleBlogSayfası()
        {
            return View();
        }

        public ActionResult KitleEndeksi()
        {
            return View();
        }

    }
}