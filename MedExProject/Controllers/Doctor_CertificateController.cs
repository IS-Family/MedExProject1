using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MedExProject.DAL;
using MedExProject.Models;

namespace MedExProject.Controllers
{
    public class Doctor_CertificateController : Controller
    {
        private MedExContext db = new MedExContext();

        // GET: Doctor_Certificate
        public ActionResult Index()
        {
            return View(db.Doctors_Certificates.ToList());
        }

        // GET: Doctor_Certificate/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor_Certificate doctor_Certificate = db.Doctors_Certificates.Find(id);
            if (doctor_Certificate == null)
            {
                return HttpNotFound();
            }
            return View(doctor_Certificate);
        }

        // GET: Doctor_Certificate/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Doctor_Certificate/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DoctorID,CertID,ExpirDate")] Doctor_Certificate doctor_Certificate)
        {
            if (ModelState.IsValid)
            {
                db.Doctors_Certificates.Add(doctor_Certificate);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(doctor_Certificate);
        }

        // GET: Doctor_Certificate/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor_Certificate doctor_Certificate = db.Doctors_Certificates.Find(id);
            if (doctor_Certificate == null)
            {
                return HttpNotFound();
            }
            return View(doctor_Certificate);
        }

        // POST: Doctor_Certificate/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DoctorID,CertID,ExpirDate")] Doctor_Certificate doctor_Certificate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctor_Certificate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(doctor_Certificate);
        }

        // GET: Doctor_Certificate/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor_Certificate doctor_Certificate = db.Doctors_Certificates.Find(id);
            if (doctor_Certificate == null)
            {
                return HttpNotFound();
            }
            return View(doctor_Certificate);
        }

        // POST: Doctor_Certificate/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Doctor_Certificate doctor_Certificate = db.Doctors_Certificates.Find(id);
            db.Doctors_Certificates.Remove(doctor_Certificate);
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
