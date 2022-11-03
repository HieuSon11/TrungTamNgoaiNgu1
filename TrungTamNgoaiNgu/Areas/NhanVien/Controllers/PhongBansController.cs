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
    public class PhongBansController : Controller
    {
        private TrungTamNgoaiNguDBContext db = new TrungTamNgoaiNguDBContext();

        // GET: NhanVien/PhongBans
        public ActionResult Index()
        {
            var list = db.PhongBans.Where(m => m.TrangThai != 0)
               .OrderByDescending(m => m.ThoiGianTao)
               .ToList();
            return View(list);
        }

        // GET: NhanVien/PhongBans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhongBan phongBan = db.PhongBans.Find(id);
            if (phongBan == null)
            {
                return HttpNotFound();
            }
            return View(phongBan);
        }

        // GET: NhanVien/PhongBans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhanVien/PhongBans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaPb,TenPhonSg,NguoiTao,NguoiCapNhat,ThoiGianTao,ThoiGianCapNhat,TrangThai")] PhongBan phongBan)
        {
            if (ModelState.IsValid)
            {
                phongBan.NguoiTao = "Sơn Văn Hiếu";
                phongBan.ThoiGianTao = DateTime.Now;
                phongBan.ThoiGianCapNhat = DateTime.Now;
                phongBan.TrangThai = 1;
                db.PhongBans.Add(phongBan);
                db.PhongBans.Add(phongBan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(phongBan);
        }

        // GET: NhanVien/PhongBans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhongBan phongBan = db.PhongBans.Find(id);
            if (phongBan == null)
            {
                return HttpNotFound();
            }
            return View(phongBan);
        }

        // POST: NhanVien/PhongBans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaPb,TenPhonSg,NguoiTao,NguoiCapNhat,ThoiGianTao,ThoiGianCapNhat,TrangThai")] PhongBan phongBan)
        {
            if (ModelState.IsValid)
            {
                phongBan.NguoiCapNhat = "Sơn Văn Hiếu";
                phongBan.ThoiGianCapNhat = DateTime.Now;
                db.Entry(phongBan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(phongBan);
        }

        // GET: NhanVien/PhongBans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhongBan phongBan = db.PhongBans.Find(id);
            if (phongBan == null)
            {
                return HttpNotFound();
            }
            return View(phongBan);
        }

        // POST: NhanVien/PhongBans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PhongBan phongBan = db.PhongBans.Find(id);
            db.PhongBans.Remove(phongBan);
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
            PhongBan PhongBan = db.PhongBans.Find(id);
            int trangthai = (PhongBan.TrangThai == 1) ? 2 : 1;
            PhongBan.NguoiCapNhat = "Sơn Văn Hiếu";
            PhongBan.TrangThai = trangthai;
            PhongBan.ThoiGianCapNhat = DateTime.Now;
            db.Entry(PhongBan).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Trash()
        {
            var list = db.PhongBans.Where(m => m.TrangThai == 0)
               .OrderByDescending(m => m.ThoiGianTao)
               .ToList();
            return View("Trash", list);
        }

        public ActionResult DelTrash(int id)
        {
            PhongBan PhongBan = db.PhongBans.Find(id);
            int trangthai = (PhongBan.TrangThai == 0) ? 1 : 0;
            PhongBan.NguoiCapNhat = "Sơn Văn Hiếu";
            PhongBan.TrangThai = trangthai;
            PhongBan.ThoiGianCapNhat = DateTime.Now;
            db.Entry(PhongBan).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Trash");
        }
    }
}
