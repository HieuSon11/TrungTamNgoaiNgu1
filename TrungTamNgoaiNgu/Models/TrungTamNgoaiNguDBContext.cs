using MyTTNN.TrungTamNgoaiNgu;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrungTamNgoaiNgu.Models
{
    public class TrungTamNgoaiNguDBContext: DbContext
    {
        public TrungTamNgoaiNguDBContext() : base("name=ChuoiKN"){ }
        public virtual DbSet<CapDo> CapDos { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<Cong> Congs { get; set; }
        public virtual DbSet<HocSinh> HocSinhs { get; set; }
        public virtual DbSet<HopDong> HopDongs { get; set; }
        public virtual DbSet<ThiDua> ThiDuas { get; set; }
        public virtual DbSet<KhoaHoc> KhoaHocs { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<LoaiKhoaHoc> LoaiKhoaHocs { get; set; }
        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<LopHocSinh> LopHocSinhs { get; set; }
        public virtual DbSet<LopNgayThu> LopNgayThus { get; set; }
        public virtual DbSet<Luong> Luongs { get; set; }
        public virtual DbSet<NgayThu> NgayThus { get; set; }
        public virtual DbSet<NghiViec> NghiViecs { get; set; }
        public virtual DbSet<NgoaiNgu> NgoaiNgus { get; set; }
        public virtual DbSet<NgonNgu> NgonNgus { get; set; }
        public virtual DbSet<NhanViens> NhanViens { get; set; }
        public virtual DbSet<PhongBan> PhongBans { get; set; }
        public virtual DbSet<PhuHuynh> PhuHuynhs { get; set; }
        public virtual DbSet<PhuongThucThanhToan> PhuongThucThanhToans { get; set; }
        public virtual DbSet<TaiKhoanHS> TaiKhoanHs { get; set; }
        public virtual DbSet<TaiKhoanNhanVien> TaiKhoanNhanViens { get; set; }
        public virtual DbSet<ThanhToan> ThanhToans { get; set; }
        public virtual DbSet<ThanhToanLuong> ThanhToanLuongs { get; set; }
    }
}