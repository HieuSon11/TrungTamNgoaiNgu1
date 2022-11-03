using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTTNN.TrungTamNgoaiNgu
{
    [Table("ThanhToanLuongs")]
    public partial class ThanhToanLuong
    {
        [Key]
        public int MaTtl { get; set; }
        public int? NhanVienID { get; set; }
        public int? CongID { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public float? TamUng { get; set; }
        public float? Thuong { get; set; }
        public float? ThucLinh { get; set; }

        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianCapNhat { get; set; }
        public int TrangThai { get; set; }

        public virtual Cong MaCongNavigation { get; set; }
        public virtual NhanViens MaNvNavigation { get; set; }
    }
}
