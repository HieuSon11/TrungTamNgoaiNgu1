using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTTNN.TrungTamNgoaiNgu
{
    [Table("ThiDuas")]
    public partial class ThiDua
    {
        [Key]
        public string MaKtkl { get; set; }
        public int? NhanVienID { get; set; }
        public bool ThuongPhat { get; set; }
        public string LyDo { get; set; }
        public DateTime NgayApDung { get; set; }
        public decimal Thuong { get; set; }

        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianCapNhat { get; set; }
        public int TrangThai { get; set; }

        public virtual NhanViens MaNVNavigation { get; set; }
    }
}
