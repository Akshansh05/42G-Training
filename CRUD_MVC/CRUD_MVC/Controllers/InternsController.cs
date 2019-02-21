using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRUD_MVC.Models;

namespace CRUD_MVC.Controllers
{
    public class InternsController : Controller
    {
        private SampleDBEntities db = new SampleDBEntities();

        // GET: Interns
        public ActionResult Index()
        {
            return View(db.Interns.ToList());
        }

        // GET: Interns/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Intern intern = db.Interns.Find(id);
            if (intern == null)
            {
                return HttpNotFound();
            }
            return View(intern);
        }

        // GET: Interns/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Interns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Intern intern)
        {
            if (ModelState.IsValid)
            {
                db.Interns.Add(intern);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(intern);
        }

        // GET: Interns/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Intern intern = db.Interns.Find(id);
            if (intern == null)
            {
                return HttpNotFound();
            }
            return View(intern);
        }

        // POST: Interns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Intern intern)
        {
            if (ModelState.IsValid)
            {
                db.Entry(intern).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(intern);
        }

        // GET: Interns/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Intern intern = db.Interns.Find(id);
            if (intern == null)
            {
                return HttpNotFound();
            }
            return View(intern);
        }

        // POST: Interns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Intern intern = db.Interns.Find(id);
            db.Interns.Remove(intern);
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
