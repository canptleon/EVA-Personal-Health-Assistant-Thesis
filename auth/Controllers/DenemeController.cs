using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using auth.Models;

namespace auth.Controllers
{
    public class DenemeController : Controller
    {
        private EksaProjectEntities db = new EksaProjectEntities();

        // GET: Deneme
        public ActionResult Index()
        {
            var users = db.Users.Include(u => u.Rol);
            return View(users.ToList());
        }

        // GET: Deneme/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Users users = db.Users.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            return View(users);
        }

        // GET: Deneme/Create
        public ActionResult Create()
        {
            ViewBag.userRol = new SelectList(db.Rol, "rolId", "rolName");
            return View();
        }

        // POST: Deneme/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,userIdentityNumber,userPersonalName,userPersonalSurname,userPassword,userPhoneNumber,userEmail,userImageSource,userBirthDate,userRol,isActivity")] Users users)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(users);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.userRol = new SelectList(db.Rol, "rolId", "rolName", users.userRol);
            return View(users);
        }

        // GET: Deneme/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Users users = db.Users.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            ViewBag.userRol = new SelectList(db.Rol, "rolId", "rolName", users.userRol);
            return View(users);
        }

        // POST: Deneme/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,userIdentityNumber,userPersonalName,userPersonalSurname,userPassword,userPhoneNumber,userEmail,userImageSource,userBirthDate,userRol,isActivity")] Users users)
        {
            if (ModelState.IsValid)
            {
                db.Entry(users).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.userRol = new SelectList(db.Rol, "rolId", "rolName", users.userRol);
            return View(users);
        }

        // GET: Deneme/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Users users = db.Users.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            return View(users);
        }

        // POST: Deneme/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Users users = db.Users.Find(id);
            db.Users.Remove(users);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
