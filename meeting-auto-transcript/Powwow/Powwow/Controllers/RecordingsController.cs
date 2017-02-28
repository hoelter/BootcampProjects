using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Powwow.DataContexts;
using Powwow.Models;
using Powwow.Models.Recordings;

namespace Powwow.Controllers
{
    public class RecordingsController : Controller
    {
        private RecordingsDb db = new RecordingsDb();

        // GET: Recordings
        public async Task<ActionResult> Index()
        {
            var recordings = db.Recordings.Include(r => r.SalesforceUser);
            return View(await recordings.ToListAsync());
        }

        // GET: Recordings/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recording recording = await db.Recordings.FindAsync(id);
            if (recording == null)
            {
                return HttpNotFound();
            }
            return View(recording);
        }

        // GET: Recordings/Create
        public ActionResult Create()
        {
            ViewBag.SalesforceUserID = new SelectList(db.SalesforceUsers, "ID", "ID");
            return View();
        }

        // POST: Recordings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,SalesforceUserID,FileName,RecordingTime")] Recording recording)
        {
            if (ModelState.IsValid)
            {
                db.Recordings.Add(recording);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.SalesforceUserID = new SelectList(db.SalesforceUsers, "ID", "ID", recording.SalesforceUserID);
            return View(recording);
        }

        // GET: Recordings/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recording recording = await db.Recordings.FindAsync(id);
            if (recording == null)
            {
                return HttpNotFound();
            }
            ViewBag.SalesforceUserID = new SelectList(db.SalesforceUsers, "ID", "ID", recording.SalesforceUserID);
            return View(recording);
        }

        // POST: Recordings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,SalesforceUserID,FileName,RecordingTime")] Recording recording)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recording).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.SalesforceUserID = new SelectList(db.SalesforceUsers, "ID", "ID", recording.SalesforceUserID);
            return View(recording);
        }

        // GET: Recordings/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recording recording = await db.Recordings.FindAsync(id);
            if (recording == null)
            {
                return HttpNotFound();
            }
            return View(recording);
        }

        // POST: Recordings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Recording recording = await db.Recordings.FindAsync(id);
            db.Recordings.Remove(recording);
            await db.SaveChangesAsync();
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
