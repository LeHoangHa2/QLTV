﻿using System;
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
    public class ViTriController : Controller
    {
        private THUVIENEntities2 db = new THUVIENEntities2();

        // GET: ViTri
        public ActionResult Index()
        {
            return View(db.ViTri.ToList());
        }

        // GET: ViTri/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViTri viTri = db.ViTri.Find(id);
            if (viTri == null)
            {
                return HttpNotFound();
            }
            return View(viTri);
        }

        // GET: ViTri/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ViTri/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,MaViTri,Ngan,Ke,TimeUpdate,TimeCreate,Khu")] ViTri viTri)
        {
            if (ModelState.IsValid)
            {
                db.ViTri.Add(viTri);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(viTri);
        }

        // GET: ViTri/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViTri viTri = db.ViTri.Find(id);
            if (viTri == null)
            {
                return HttpNotFound();
            }
            return View(viTri);
        }

        // POST: ViTri/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,MaViTri,Ngan,Ke,TimeUpdate,TimeCreate,Khu")] ViTri viTri)
        {
            if (ModelState.IsValid)
            {
                db.Entry(viTri).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(viTri);
        }

        // GET: ViTri/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViTri viTri = db.ViTri.Find(id);
            if (viTri == null)
            {
                return HttpNotFound();
            }
            return View(viTri);
        }

        // POST: ViTri/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ViTri viTri = db.ViTri.Find(id);
            db.ViTri.Remove(viTri);
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
