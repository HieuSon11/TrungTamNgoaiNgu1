using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTTNN.TrungTamNgoaiNgu
{
    [Table("Luongs")]
    public partial class Luong
    {
        [Key]
        public int MaLuong { get; set; }
        public int NhanVienID { get; set; }
        [Required]
        public decimal MucLuong { get; set; }
        public DateTime NgayLenLuong { get; set; }

        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianCapNhat { get; set; }
        public int TrangThai { get; set; }

        public virtual NhanViens MaNvNavigation { get; set; }
    }
}
