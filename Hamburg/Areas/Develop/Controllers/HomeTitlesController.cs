using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hamburg.Models;

namespace Hamburg.Areas.Develop.Controllers
{
    public class HomeTitlesController : Controller
    {
        private HamburgEntities db = new HamburgEntities();

        // GET: Develop/HomeTitles
        public ActionResult Index()
        {
            return View(db.HomeTitles.ToList());
        }

        // GET: Develop/HomeTitles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeTitle homeTitle = db.HomeTitles.Find(id);
            if (homeTitle == null)
            {
                return HttpNotFound();
            }
            return View(homeTitle);
        }

        // GET: Develop/HomeTitles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Develop/HomeTitles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,miniTitle,Description")] HomeTitle homeTitle)
        {
            if (ModelState.IsValid)
            {
                db.HomeTitles.Add(homeTitle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(homeTitle);
        }

        // GET: Develop/HomeTitles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeTitle homeTitle = db.HomeTitles.Find(id);
            if (homeTitle == null)
            {
                return HttpNotFound();
            }
            return View(homeTitle);
        }

        // POST: Develop/HomeTitles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,miniTitle,Description")] HomeTitle homeTitle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(homeTitle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(homeTitle);
        }

        // GET: Develop/HomeTitles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeTitle homeTitle = db.HomeTitles.Find(id);
            if (homeTitle == null)
            {
                return HttpNotFound();
            }
            return View(homeTitle);
        }

        // POST: Develop/HomeTitles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HomeTitle homeTitle = db.HomeTitles.Find(id);
            db.HomeTitles.Remove(homeTitle);
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
