using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VandrarhemDbAccess;

namespace Vandrarhem.Controllers
{
    public class BokningarsController : Controller
    {
        private VandrarhemSQLEntities db = new VandrarhemSQLEntities();

        // GET: Bokningars
        public ActionResult Index()
        {
            return View(db.Bokningars.ToList());
        }

        // GET: Bokningars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bokningar bokningar = db.Bokningars.Find(id);
            if (bokningar == null)
            {
                return HttpNotFound();
            }
            return View(bokningar);
        }

        // GET: Bokningars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bokningars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BokningsId,InCheckning,UtCheckning,Betalt")] Bokningar bokningar)
        {
            if (ModelState.IsValid)
            {
                db.Bokningars.Add(bokningar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bokningar);
        }

        // GET: Bokningars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bokningar bokningar = db.Bokningars.Find(id);
            if (bokningar == null)
            {
                return HttpNotFound();
            }
            return View(bokningar);
        }

        // POST: Bokningars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BokningsId,InCheckning,UtCheckning,Betalt")] Bokningar bokningar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bokningar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bokningar);
        }

        // GET: Bokningars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bokningar bokningar = db.Bokningars.Find(id);
            if (bokningar == null)
            {
                return HttpNotFound();
            }
            return View(bokningar);
        }

        // POST: Bokningars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bokningar bokningar = db.Bokningars.Find(id);
            db.Bokningars.Remove(bokningar);
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
