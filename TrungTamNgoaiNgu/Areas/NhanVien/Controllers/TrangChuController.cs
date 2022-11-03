using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrungTamNgoaiNgu.Models;

namespace TrungTamNgoaiNgu.Areas.NhanVien.Controllers
{
    public class TrangChuController : Controller
    {
        private TrungTamNgoaiNguDBContext db = new TrungTamNgoaiNguDBContext(); 
        // GET: NhanVien/TrangChu
        public ActionResult Index()
        {
            ViewBag.SoChucVu = db.ChucVus.Count();
            return View(ViewBag.SoChucVu);
        }
    }
}