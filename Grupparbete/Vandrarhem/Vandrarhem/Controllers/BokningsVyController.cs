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
    public class BokningsVyController : Controller
    {
        private VandrarhemSQLEntities db = new VandrarhemSQLEntities();

        // GET: BokningsVy
        public ActionResult Index()
        {
            return View(db.BokningsVies.ToList());
        }

        // GET: BokningsVy/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BokningsVy bokningsVy = db.BokningsVies.Find(id);
            if (bokningsVy == null)
            {
                return HttpNotFound();
            }
            return View(bokningsVy);
        }

        // GET: BokningsVy/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BokningsVy/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ForNamn,EfterNamn,RumsNummer,AntalBaddar,KundId,InCheckning,UtCheckning")] BokningsVy bokningsVy)
        {
            if (ModelState.IsValid)
            {
                db.BokningsVies.Add(bokningsVy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bokningsVy);
        }

        // GET: BokningsVy/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BokningsVy bokningsVy = db.BokningsVies.Find(id);
            if (bokningsVy == null)
            {
                return HttpNotFound();
            }
            return View(bokningsVy);
        }

        // POST: BokningsVy/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ForNamn,EfterNamn,RumsNummer,AntalBaddar,KundId,InCheckning,UtCheckning")] BokningsVy bokningsVy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bokningsVy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bokningsVy);
        }

        // GET: BokningsVy/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BokningsVy bokningsVy = db.BokningsVies.Find(id);
            if (bokningsVy == null)
            {
                return HttpNotFound();
            }
            return View(bokningsVy);
        }

        // POST: BokningsVy/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            BokningsVy bokningsVy = db.BokningsVies.Find(id);
            db.BokningsVies.Remove(bokningsVy);
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
