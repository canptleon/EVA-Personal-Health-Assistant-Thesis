using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using auth.Models;

namespace auth.Controllers
{
    
    public class MemberController : Controller
    {
        public EksaProjectEntities db = new EksaProjectEntities();

        public ActionResult Giris()
        {
           
            return View();
        }

        [HttpPost]
      
        public ActionResult Giris(Users user)
        {
            var kullanici = db.Users.FirstOrDefault(x => x.userEmail == user.userEmail && x.userPassword == user.userPassword);
            if(kullanici!=null)
            {

                Session["Kullanıcı"] = kullanici;
                Session["ID"] = kullanici.id;
                Session["ID2"] = kullanici.userIdentityNumber;
                Session["Email"] = kullanici.userEmail;
                Session["Name"] = kullanici.userPersonalName;
                Session["SurName"] = kullanici.userPersonalSurname;
                Session["DogumTarihi"] = kullanici.userBirthDate;
                Session["TelNo"] = kullanici.userPhoneNumber;

                FormsAuthentication.SetAuthCookie(kullanici.userEmail, false);
             
                return RedirectToAction("Index", "Home");

            }
            else
            {
                //YANLIS GİRERSE
                return RedirectToAction("About", "Home");
            }
        }

        public ActionResult Çıkış()
        {
            Session["Kullanıcı"] = null;
            Session["ID"] = null;
            Session["ID2"] = null;
            Session["Email"] = null;
            Session["Name"] = null;
            Session["SurName"] = null;
            Session["DogumTarihi"] = null;
            Session["TelNo"] = null;
            FormsAuthentication.SignOut();
            return View("Giris");
        }


        // GET: Member
        public ActionResult Create()
        {
            ViewBag.userRol = new SelectList(db.Rol, "rolId", "rolName");
            return View();
        }

        // POST: Member/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,userIdentityNumber,userPersonalName,userPersonalSurname,userPassword,userPhoneNumber,userEmail,userImageSource,userBirthDate,userRol,isActivity")] Users users)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(users);
                db.SaveChanges();
                return RedirectToAction("Index","Home");
            }

            ViewBag.userRol = new SelectList(db.Rol, "rolId", "rolName", users.userRol);
            return View(users);
        }
        //    // GET: Member
        //    public ActionResult Index()
        //    {
        //        var login = db.Login.Include(l => l.Users);
        //        return View(login.ToList());
        //    }

        //    // GET: Member/Details/5
        //    public ActionResult Details(string id)
        //    {
        //        if (id == null)
        //        {
        //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //        }
        //        Login login = db.Login.Find(id);
        //        if (login == null)
        //        {
        //            return HttpNotFound();
        //        }
        //        return View(login);
        //    }

        // GET: Member/Create
        //public ActionResult Create()
        //{
        //    ViewBag.identityNumber = new SelectList(db.Users, "userIdentityNumber", "userPersonalName");
        //    return View();
        //}

        // POST: Member/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "id,identityNumber,token,time")] Login login)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Login.Add(login);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.identityNumber = new SelectList(db.Users, "userIdentityNumber", "userPersonalName", login.identityNumber);
        //    return View(login);
        //}

        //    // GET: Member/Edit/5
        //    public ActionResult Edit(string id)
        //    {
        //        if (id == null)
        //        {
        //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //        }
        //        Login login = db.Login.Find(id);
        //        if (login == null)
        //        {
        //            return HttpNotFound();
        //        }
        //        ViewBag.identityNumber = new SelectList(db.Users, "userIdentityNumber", "userPersonalName", login.identityNumber);
        //        return View(login);
        //    }

        //    // POST: Member/Edit/5
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Edit([Bind(Include = "id,identityNumber,token,time")] Login login)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            db.Entry(login).State = EntityState.Modified;
        //            db.SaveChanges();
        //            return RedirectToAction("Index");
        //        }
        //        ViewBag.identityNumber = new SelectList(db.Users, "userIdentityNumber", "userPersonalName", login.identityNumber);
        //        return View(login);
        //    }

        //    // GET: Member/Delete/5
        //    public ActionResult Delete(string id)
        //    {
        //        if (id == null)
        //        {
        //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //        }
        //        Login login = db.Login.Find(id);
        //        if (login == null)
        //        {
        //            return HttpNotFound();
        //        }
        //        return View(login);
        //    }

        //    // POST: Member/Delete/5
        //    [HttpPost, ActionName("Delete")]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult DeleteConfirmed(string id)
        //    {
        //        Login login = db.Login.Find(id);
        //        db.Login.Remove(login);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    protected override void Dispose(bool disposing)
        //    {
        //        if (disposing)
        //        {
        //            db.Dispose();
        //        }
        //        base.Dispose(disposing);
        //    }
    }
}
