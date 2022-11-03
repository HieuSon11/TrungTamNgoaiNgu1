using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTTNN.TrungTamNgoaiNgu
{
    [Table("lopHoc")]
    public partial class LopHoc
    {
        public LopHoc()
        {
            LopHocSinhs = new HashSet<LopHocSinh>();
            LopNgayThus = new HashSet<LopNgayThu>();
            ThanhToans = new HashSet<ThanhToan>();
        }
        [Key]
        public int MaLop { get; set; }
        [Required]
        public string TenLop { get; set; }
        [Required]
        public DateTime NgayBd { get; set; }
        [Required]
        public DateTime NgayKt { get; set; }
        [Required]
        public decimal Gia { get; set; }
        public int? KhoaHocID { get; set; }
        public int? NhanVienID { get; set; }

        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianCapNhat { get; set; }
        public int TrangThai { get; set; }

        public virtual KhoaHoc MaKhNavigation { get; set; }
        public virtual NhanViens MaNvNavigation { get; set; }
        public virtual ICollection<LopHocSinh> LopHocSinhs { get; set; }
        public virtual ICollection<LopNgayThu> LopNgayThus { get; set; }
        public virtual ICollection<ThanhToan> ThanhToans { get; set; }
    }
}
