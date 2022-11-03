using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTTNN.TrungTamNgoaiNgu
{
    [Table("TaiKhoanNhanViens")]
    public partial class TaiKhoanNhanVien
    {
        [Key]
        public int MaTaiKhoanNhanVien { get; set; }
        public int? NhanVienID { get; set; }
        public bool TrangThaiNV { get; set; }
        [Required]
        public string TenDangNhap { get; set; }
        [Required]
        public string MatKhau { get; set; }

        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianCapNhat { get; set; }
        public int TrangThai { get; set; }

        public virtual NhanViens MaNvNavigation { get; set; }
    }
}
