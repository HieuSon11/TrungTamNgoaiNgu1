using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using MyTTNN.TrungTamNgoaiNgu;
using TrungTamNgoaiNgu.Models;

namespace TrungTamNgoaiNgu.Areas.NhanVien.Controllers
{
    public class ChucVusController : Controller
    {
        private TrungTamNgoaiNguDBContext db = new TrungTamNgoaiNguDBContext();

        // GET: NhanVien/ChucVus
        public ActionResult Index()
        {
            var list = db.ChucVus.Where(m => m.TrangThai != 0)
                .OrderByDescending(m => m.ThoiGianTao)
                .ToList();
            return View(list);
        }

        // GET: NhanVien/ChucVus/Details/5
        public ActionResult Details(int id)
        {
            ChucVu chucVu = db.ChucVus.Find(id);
            if (chucVu == null)
            {
                return HttpNotFound();
            }
            return View(chucVu);
        }

        // GET: NhanVien/ChucVus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhanVien/ChucVus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaCv,TenCv,NguoiTao,NguoiCapNhat,ThoiGianTao,ThoiGianCapNhat,TrangThai")] ChucVu chucVu)
        {
            if (ModelState.IsValid)
            {
                chucVu.NguoiTao = "Sơn Văn Hiếu";
                chucVu.ThoiGianTao = DateTime.Now;
                chucVu.ThoiGianCapNhat = DateTime.Now;
                chucVu.TrangThai = 1;
                db.ChucVus.Add(chucVu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(chucVu);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add([Bind(Include = "MaCv,TenCv,NguoiTao,NguoiCapNhat,ThoiGianTao,ThoiGianCapNhat,TrangThai")] ChucVu chucVu)
        {
            if (ModelState.IsValid)
            {
                chucVu.NguoiTao = "Sơn Văn Hiếu";
                chucVu.ThoiGianTao = DateTime.Now;
                chucVu.ThoiGianCapNhat = DateTime.Now;
                chucVu.TrangThai = 0;
                db.ChucVus.Add(chucVu);
                try
                {
                    db.SaveChanges();
                    return Json(new { success = true });
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                    return Json(new { success = false });
                }
                
            }
            return Json(new { success = true });
        }

        // GET: NhanVien/ChucVus/Edit/5
        public ActionResult Edit(int id)
        {
            ChucVu chucVu = db.ChucVus.Find(id);
            if (chucVu == null)
            {
                return HttpNotFound();
            }
            return View(chucVu);
        }

        // POST: NhanVien/ChucVus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaCv,TenCv,NguoiTao,NguoiCapNhat,ThoiGianTao,ThoiGianCapNhat,TrangThai")] ChucVu chucVu)
        {
            if (ModelState.IsValid)
            {
                chucVu.NguoiCapNhat = "Sơn Văn Hiếu";
                chucVu.ThoiGianCapNhat = DateTime.Now;
                db.Entry(chucVu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chucVu);
        }

        // GET: NhanVien/ChucVus/Delete/5
        public ActionResult Delete(int id)
        {
            ChucVu chucVu = db.ChucVus.Find(id);
            if (chucVu == null)
            {
                return HttpNotFound();
            }
            return View(chucVu);
        }

        // POST: NhanVien/ChucVus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ChucVu chucVu = db.ChucVus.Find(id);
            db.ChucVus.Remove(chucVu);
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
            ChucVu chucvu = db.ChucVus.Find(id);
            int trangthai = (chucvu.TrangThai == 1) ? 2 : 1;
            chucvu.NguoiCapNhat = "Sơn Văn Hiếu";
            chucvu.TrangThai = trangthai;
            chucvu.ThoiGianCapNhat = DateTime.Now;
            db.Entry(chucvu).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Trash()
        {
            var list = db.ChucVus.Where(m => m.TrangThai == 0)
               .OrderByDescending(m => m.ThoiGianTao)
               .ToList();
            return View("Trash" ,list);
        }

        public ActionResult DelTrash(int id)
        {
            ChucVu chucvu = db.ChucVus.Find(id);
            int trangthai = (chucvu.TrangThai == 0) ? 1 : 0; 
            chucvu.NguoiCapNhat = "Sơn Văn Hiếu";
            chucvu.TrangThai = trangthai;
            chucvu.ThoiGianCapNhat = DateTime.Now;
            db.Entry(chucvu).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Trash");
        }
    }
}
