using MyTTNN.TrungTamNgoaiNgu;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTTNN.TrungTamNgoaiNgu
{
    [Table("NhanViens")]
    public partial class NhanViens
    {
        public NhanViens()
        {
            Congs = new HashSet<Cong>();
            HopDongs = new HashSet<HopDong>();
            ThiDuas = new HashSet<ThiDua>();
            LopHocs = new HashSet<LopHoc>();
            Luongs = new HashSet<Luong>();
            NghiViecs = new HashSet<NghiViec>();
            NgoaiNgus = new HashSet<NgoaiNgu>();
            TaiKhoanNhanViens = new HashSet<TaiKhoanNhanVien>();
            ThanhToanLuongs = new HashSet<ThanhToanLuong>();
        }

        [Key]
        public int MaNv { get; set; }
        [Required]
        public string Ho { get; set; }
        [Required]
        public string Ten { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Sdt { get; set; }
        public int? PhongBanID { get; set; }
        public int? ChucVuID { get; set; }
        [Required]
        public string Hinh { get; set; }

        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianCapNhat { get; set; }
        public int TrangThai { get; set; }

        public virtual ChucVu MaCvNavigation { get; set; }
        public virtual PhongBan MaPbNavigation { get; set; }
        public virtual ICollection<Cong> Congs { get; set; }
        public virtual ICollection<HopDong> HopDongs { get; set; }
        public virtual ICollection<ThiDua> ThiDuas { get; set; }
        public virtual ICollection<LopHoc> LopHocs { get; set; }
        public virtual ICollection<Luong> Luongs { get; set; }
        public virtual ICollection<NghiViec> NghiViecs { get; set; }
        public virtual ICollection<NgoaiNgu> NgoaiNgus { get; set; }
        public virtual ICollection<TaiKhoanNhanVien> TaiKhoanNhanViens { get; set; }
        public virtual ICollection<ThanhToanLuong> ThanhToanLuongs { get; set; }
    }
}
