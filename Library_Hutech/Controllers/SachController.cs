using Library_Hutech.Models;
using System;
using System.Collections;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Library_Hutech.Controllers
{
    public class SachController : Controller
    {
        private THUVIENEntities2 db = new THUVIENEntities2();

        // GET: Sach
        public ActionResult Index()
        {
            var Sach = db.Sach.Include(s => s.LoaiSach1).Include(s => s.NXB1).Include(s => s.PhieuMuon).Include(s => s.TacGia1).Include(s => s.ViTri1);
            return View(Sach.ToList());
        }

        // GET: Sach/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sach sach = db.Sach.Find(id);
            if (sach == null)
            {
                return HttpNotFound();
            }
            string imgPath = Server.MapPath(sach.ImagePath);
            if (System.IO.File.Exists(imgPath))
            {
                byte[] byteData = System.IO.File.ReadAllBytes(imgPath);
                string imreBase64Data = Convert.ToBase64String(byteData);
                string imgDataURL = string.Format("data:image/png;base64,{0}", imreBase64Data);
                ViewBag.ImageData = imgDataURL;
                return View(sach);
            }
            else
            {
                return View(sach);
            }

        }

        // GET: Sach/Create
        public ActionResult Create()
        {
            //ViewBag.LoaiSach = new SelectList(db.LoaiSach, "ID", "MaLoaiSach");
            //ViewBag.NXB = new SelectList(db.NXB, "ID", "MaNXB");
            //ViewBag.Muon = new SelectList(db.PhieuMuon, "ID", "MaMuon");
            //ViewBag.TacGia = new SelectList(db.TacGia, "ID", "MaTacGia");
            //ViewBag.ViTri = new SelectList(db.ViTri, "ID", "MaViTri");
            ViewBag.LoaiSach = new SelectList(db.LoaiSach, "ID", "TenLoaiSach");
            ViewBag.NXB = new SelectList(db.NXB, "ID", "TenNXB");
            ViewBag.Muon = new SelectList(db.PhieuMuon, "ID", "NguoiMuon");
            ViewBag.TacGia = new SelectList(db.TacGia, "ID", "TenTacGia");
            ViewBag.ViTri = new SelectList(db.ViTri, "ID", "MaViTri");
            Console.WriteLine(ViewBag);
            return View();
        }

        // POST: Sach/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upload(
            [Bind(Include = "ID,MaSach,TenSach,LoaiSach,NamXB,NXB,TacGia,ViTri,SoLuong,Muon,NgonNgu,TimeCreate,TimeUpdate")] Sach sach,HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                string fileName = Path.GetFileName(file.FileName);
                string pictureFile = Path.Combine(Server.MapPath("~/img"),fileName);
                file.SaveAs(pictureFile); //add picture folder img
                string pathFileSaveDb = @"~/img/" + file.FileName;
                sach.ImagePath = pathFileSaveDb;
            }
            if (ModelState.IsValid)
            {
                db.Sach.Add(sach);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LoaiSach = new SelectList(db.LoaiSach, "ID", "MaLoaiSach", sach.LoaiSach);
            ViewBag.NXB = new SelectList(db.NXB, "ID", "MaNXB", sach.NXB);
            ViewBag.Muon = new SelectList(db.PhieuMuon, "ID", "MaMuon", sach.Muon);
            ViewBag.TacGia = new SelectList(db.TacGia, "ID", "MaTacGia", sach.TacGia);
            ViewBag.ViTri = new SelectList(db.ViTri, "ID", "MaViTri", sach.ViTri);
            ViewBag.ImagePath = new SelectList(db.ViTri, "ID", "MaViTri", sach.ViTri);
            return View(sach);
        }

        // GET: Sach/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sach sach = db.Sach.Find(id);
            if (sach == null)
            {
                return HttpNotFound();
            }
            ViewBag.LoaiSach = new SelectList(db.LoaiSach, "ID", "MaLoaiSach", sach.LoaiSach);
            ViewBag.NXB = new SelectList(db.NXB, "ID", "MaNXB", sach.NXB);
            ViewBag.Muon = new SelectList(db.PhieuMuon, "ID", "MaMuon", sach.Muon);
            ViewBag.TacGia = new SelectList(db.TacGia, "ID", "MaTacGia", sach.TacGia);
            ViewBag.ViTri = new SelectList(db.ViTri, "ID", "MaViTri", sach.ViTri);
            return View(sach);
        }

        // POST: Sach/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,MaSach,TenSach,LoaiSach,NamXB,NXB,TacGia,ViTri,SoLuong,Muon,NgonNgu,TimeCreate,TimeUpdate")] Sach sach)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sach).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LoaiSach = new SelectList(db.LoaiSach, "ID", "MaLoaiSach", sach.LoaiSach);
            ViewBag.NXB = new SelectList(db.NXB, "ID", "MaNXB", sach.NXB);
            ViewBag.Muon = new SelectList(db.PhieuMuon, "ID", "MaMuon", sach.Muon);
            ViewBag.TacGia = new SelectList(db.TacGia, "ID", "MaTacGia", sach.TacGia);
            ViewBag.ViTri = new SelectList(db.ViTri, "ID", "MaViTri", sach.ViTri);
            return View(sach);
        }

        // GET: Sach/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sach sach = db.Sach.Find(id);
            if (sach == null)
            {
                return HttpNotFound();
            }
            return View(sach);
        }

        // POST: Sach/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sach sach = db.Sach.Find(id);
            db.Sach.Remove(sach);
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
