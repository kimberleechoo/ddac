using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MaesrkLine.Models;

namespace MaesrkLine.Controllers
{
   [Authorize]
    public class VesselsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Vessels
        public ActionResult Index()
        {
            
            return View(db.Vessels.ToList());
        }
        public ActionResult ViewVessels()
        {
         
            return View(db.Vessels.ToList());
        }

        // GET: Vessels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vessels vessels = db.Vessels.Find(id);
            if (vessels == null)
            {
                return HttpNotFound();
            }
            return View(vessels);
        }

        // GET: Vessels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vessels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,VesselName,VesselDeparture,DepartureFrom,VesselArrival,ArrivingTo")] Vessels vessels)
        {
            if (ModelState.IsValid)
            {
                db.Vessels.Add(vessels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vessels);
        }

        // GET: Vessels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vessels vessels = db.Vessels.Find(id);
            if (vessels == null)
            {
                return HttpNotFound();
            }
            return View(vessels);
        }

        // POST: Vessels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,VesselName,VesselDeparture,DepartureFrom,VesselArrival,ArrivingTo")] Vessels vessels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vessels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vessels);
        }

        // GET: Vessels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vessels vessels = db.Vessels.Find(id);
            if (vessels == null)
            {
                return HttpNotFound();
            }
            return View(vessels);
        }

        // POST: Vessels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vessels vessels = db.Vessels.Find(id);
            db.Vessels.Remove(vessels);
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
