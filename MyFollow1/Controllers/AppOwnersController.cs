using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyFollow1.DAL;
using MyFollow1.Models;

namespace MyFollow1.Controllers
{
    public class AppOwnersController : Controller
    {
        private ApplicationContext db = new ApplicationContext();

        // GET: AppOwners
        public ActionResult Index()
        {
            return View(db.AppOwners.ToList());
        }

        // GET: AppOwners/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppOwner appOwner = db.AppOwners.Find(id);
            if (appOwner == null)
            {
                return HttpNotFound();
            }
            return View(appOwner);
        }

        // GET: AppOwners/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppOwners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "email,CompanyName,Description,DateOfJoin,FoundedIn,Address,ContactNumber,WebsiteUrl,TwitterHandler,FacebookUrl")] AppOwner appOwner)
        {
            if (ModelState.IsValid)
            {
                db.AppOwners.Add(appOwner);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(appOwner);
        }

        // GET: AppOwners/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppOwner appOwner = db.AppOwners.Find(id);
            if (appOwner == null)
            {
                return HttpNotFound();
            }
            return View(appOwner);
        }

        // POST: AppOwners/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "email,CompanyName,Description,DateOfJoin,FoundedIn,Address,ContactNumber,WebsiteUrl,TwitterHandler,FacebookUrl")] AppOwner appOwner)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appOwner).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(appOwner);
        }

        // GET: AppOwners/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppOwner appOwner = db.AppOwners.Find(id);
            if (appOwner == null)
            {
                return HttpNotFound();
            }
            return View(appOwner);
        }

        // POST: AppOwners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            AppOwner appOwner = db.AppOwners.Find(id);
            db.AppOwners.Remove(appOwner);
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
