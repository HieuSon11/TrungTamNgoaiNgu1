using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTTNN.TrungTamNgoaiNgu
{
    [Table("ThanhToans")]
    public partial class ThanhToan
    {
        [Key]
        public int MaThanhToan { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public decimal? TongTien { get; set; }
        public int? PhuongThucTTID { get; set; }
        public int? KhuyenMaiID { get; set; }
        public Boolean? TrangThaiTT { get; set; }
        public int? HocSinhID { get; set; }
        public int? LopHocID { get; set; }

        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianCapNhat { get; set; }
        public int TrangThai { get; set; }

        public virtual HocSinh MaHsNavigation { get; set; }
        public virtual KhuyenMai MaKmNavigation { get; set; }
        public virtual LopHoc MaLopNavigation { get; set; }
        public virtual PhuongThucThanhToan MaPhuongThucNavigation { get; set; }
    }
}
