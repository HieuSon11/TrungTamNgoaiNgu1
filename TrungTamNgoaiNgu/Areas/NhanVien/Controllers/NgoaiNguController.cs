using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyTTNN.TrungTamNgoaiNgu;
using TrungTamNgoaiNgu.Models;

namespace TrungTamNgoaiNgu.Areas.NhanVien.Controllers
{
    public class NgoaiNguController : Controller
    {
        private TrungTamNgoaiNguDBContext db = new TrungTamNgoaiNguDBContext();

        // GET: NhanVien/NgoaiNgu
        public ActionResult Index()
        {
            var list = db.NgoaiNgus.Where(m => m.TrangThai != 0)
                .OrderByDescending(m => m.ThoiGianTao)
                .ToList();
            return View(list);
        }

        // GET: NhanVien/NgoaiNgu/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NgoaiNgu ngoaiNgu = db.NgoaiNgus.Find(id);
            if (ngoaiNgu == null)
            {
                return HttpNotFound();
            }
            return View(ngoaiNgu);
        }

        // GET: NhanVien/NgoaiNgu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhanVien/NgoaiNgu/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNn,NhanVienID,TenNN,NguoiTao,NguoiCapNhat,ThoiGianTao,ThoiGianCapNhat,TrangThai")] NgoaiNgu ngoaiNgu)
        {
            if (ModelState.IsValid)
            {
                ngoaiNgu.NguoiTao = "Sơn Văn Hiếu";
                ngoaiNgu.ThoiGianTao = DateTime.Now;
                ngoaiNgu.ThoiGianCapNhat = DateTime.Now;
                ngoaiNgu.TrangThai = 1;
                db.NgoaiNgus.Add(ngoaiNgu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ngoaiNgu);
        }

        // GET: NhanVien/NgoaiNgu/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NgoaiNgu ngoaiNgu = db.NgoaiNgus.Find(id);
            if (ngoaiNgu == null)
            {
                return HttpNotFound();
            }
            return View(ngoaiNgu);
        }

        // POST: NhanVien/NgoaiNgu/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNn,NhanVienID,TenNN,NguoiTao,NguoiCapNhat,ThoiGianTao,ThoiGianCapNhat,TrangThai")] NgoaiNgu ngoaiNgu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ngoaiNgu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ngoaiNgu);
        }

        // GET: NhanVien/NgoaiNgu/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NgoaiNgu ngoaiNgu = db.NgoaiNgus.Find(id);
            if (ngoaiNgu == null)
            {
                return HttpNotFound();
            }
            return View(ngoaiNgu);
        }

        // POST: NhanVien/NgoaiNgu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NgoaiNgu ngoaiNgu = db.NgoaiNgus.Find(id);
            db.NgoaiNgus.Remove(ngoaiNgu);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Status(int id)
        {
            NgoaiNgu ngoaingu = db.NgoaiNgus.Find(id);
            int trangthai = (ngoaingu.TrangThai == 1) ? 2 : 1;
            ngoaingu.NguoiCapNhat = "Sơn Văn Hiếu";
            ngoaingu.TrangThai = trangthai;
            ngoaingu.ThoiGianCapNhat = DateTime.Now;
            db.Entry(ngoaingu).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Trash()
        {
            var list = db.NgoaiNgus.Where(m => m.TrangThai == 0)
               .OrderByDescending(m => m.ThoiGianTao)
               .ToList();
            return View("Trash", list);
        }

        public ActionResult DelTrash(int id)
        {
            NgoaiNgu ngoaiNgu = db.NgoaiNgus.Find(id);
            int trangthai = (ngoaiNgu.TrangThai == 0) ? 1 : 0;
            ngoaiNgu.NguoiCapNhat = "Sơn Văn Hiếu";
            ngoaiNgu.TrangThai = trangthai;
            ngoaiNgu.ThoiGianCapNhat = DateTime.Now;
            db.Entry(ngoaiNgu).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Trash");
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
