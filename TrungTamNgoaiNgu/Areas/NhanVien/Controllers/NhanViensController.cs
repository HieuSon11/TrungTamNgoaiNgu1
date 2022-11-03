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
    public class NhanViensController : Controller
    {
        private TrungTamNgoaiNguDBContext db = new TrungTamNgoaiNguDBContext();

        // GET: NhanVien/NhanViens
        public ActionResult Index()
        {
            return View(db.NhanViens.ToList());

        }

        // GET: NhanVien/NhanViens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhanViens nhanVien = db.NhanViens.Find(id);
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            return View(nhanVien);
        }

        // GET: NhanVien/NhanViens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhanVien/NhanViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNv,nhanVien,Ho,Ten,Email,Sdt,PhongBanID,nhanVienID,Hinh,NguoiTao,NguoiCapNhat,ThoiGianTao,ThoiGianCapNhat,TrangThai")] NhanViens nhanVien)
        {
            if (ModelState.IsValid)
            {
                nhanVien.NguoiTao = "Sơn Văn Hiếu";
                nhanVien.ThoiGianTao = DateTime.Now;
                nhanVien.ThoiGianCapNhat = DateTime.Now;
                nhanVien.TrangThai = 1;
                db.NhanViens.Add(nhanVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhanVien);
        }

        // GET: NhanVien/NhanViens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhanViens nhanVien = db.NhanViens.Find(id);
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            return View(nhanVien);
        }

        // POST: NhanVien/NhanViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNv,nhanVien,Ho,Ten,Email,Sdt,PhongBanID,nhanVienID,Hinh,NguoiTao,NguoiCapNhat,ThoiGianTao,ThoiGianCapNhat,TrangThai")] NhanViens nhanVien)
        {
            if (ModelState.IsValid)
            {
                nhanVien.NguoiCapNhat = "Sơn Văn Hiếu";
                nhanVien.ThoiGianCapNhat = DateTime.Now;
                db.Entry(nhanVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhanVien);
        }

        // GET: NhanVien/NhanViens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhanViens nhanVien = db.NhanViens.Find(id);
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            return View(nhanVien);
        }

        // POST: NhanVien/NhanViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NhanViens nhanVien = db.NhanViens.Find(id);
            db.NhanViens.Remove(nhanVien);
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
        public ActionResult Status(int id)
        {
            NhanViens nhanVien = db.NhanViens.Find(id);
            int trangthai = (nhanVien.TrangThai == 1) ? 2 : 1;
            nhanVien.NguoiCapNhat = "Sơn Văn Hiếu";
            nhanVien.TrangThai = trangthai;
            nhanVien.ThoiGianCapNhat = DateTime.Now;
            db.Entry(nhanVien).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Trash()
        {
            var list = db.NhanViens.Where(m => m.TrangThai == 0)
               .OrderByDescending(m => m.ThoiGianTao)
               .ToList();
            return View("Trash", list);
        }

        public ActionResult DelTrash(int id)
        {
            NhanViens nhanVien = db.NhanViens.Find(id);
            int trangthai = (nhanVien.TrangThai == 0) ? 1 : 0;
            nhanVien.NguoiCapNhat = "Sơn Văn Hiếu";
            nhanVien.TrangThai = trangthai;
            nhanVien.ThoiGianCapNhat = DateTime.Now;
            db.Entry(nhanVien).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Trash");
        }
    }
}
