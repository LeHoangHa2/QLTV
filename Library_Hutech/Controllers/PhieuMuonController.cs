using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Library_Hutech.Models;

namespace Library_Hutech.Controllers
{
    public class PhieuMuonController : Controller
    {
        private Model1 db = new Model1();

        // GET: PhieuMuon
        public ActionResult Index()
        {
            var PhieuMuon = db.PhieuMuon.Include(p => p.SinhVien);
            return View(PhieuMuon.ToList());
        }

        // GET: PhieuMuon/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuMuon phieuMuon = db.PhieuMuon.Find(id);
            if (phieuMuon == null)
            {
                return HttpNotFound();
            }
            return View(phieuMuon);
        }

        // GET: PhieuMuon/Create
        public ActionResult Create()
        {
            ViewBag.NguoiMuon = new SelectList(db.SinhVien, "ID", "HoTen");
            return View();
        }

        // POST: PhieuMuon/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,MaMuon,NguoiMuon,NgayMuon,NgayTra,HinhThuc,TimeUpdate,TimeCreate,SoNgayMuon")] PhieuMuon phieuMuon)
        {
            if (ModelState.IsValid)
            {
                db.PhieuMuon.Add(phieuMuon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.NguoiMuon = new SelectList(db.SinhVien, "ID", "MaSV", phieuMuon.NguoiMuon);
            return View(phieuMuon);
        }

        // GET: PhieuMuon/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuMuon phieuMuon = db.PhieuMuon.Find(id);
            if (phieuMuon == null)
            {
                return HttpNotFound();
            }
            ViewBag.NguoiMuon = new SelectList(db.SinhVien, "ID", "MaSV", phieuMuon.NguoiMuon);
            return View(phieuMuon);
        }

        // POST: PhieuMuon/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,MaMuon,NguoiMuon,NgayMuon,NgayTra,HinhThuc,TimeUpdate,TimeCreate,SoNgayMuon")] PhieuMuon phieuMuon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phieuMuon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.NguoiMuon = new SelectList(db.SinhVien, "ID", "MaSV", phieuMuon.NguoiMuon);
            return View(phieuMuon);
        }

        // GET: PhieuMuon/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuMuon phieuMuon = db.PhieuMuon.Find(id);
            if (phieuMuon == null)
            {
                return HttpNotFound();
            }
            return View(phieuMuon);
        }

        // POST: PhieuMuon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PhieuMuon phieuMuon = db.PhieuMuon.Find(id);
            db.PhieuMuon.Remove(phieuMuon);
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
