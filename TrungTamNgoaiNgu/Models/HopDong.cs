using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTTNN.TrungTamNgoaiNgu
{
    [Table("HopDongs")]
    public partial class HopDong
    {
        [Key]
        public int MaHd { get; set; }
        public int? NhanVienID { get; set; }
        [Required]
        public DateTime NgayKi { get; set; }
        [Required]
        public DateTime HanHd { get; set; }
        [Required]
        public string TrangThaiKi { get; set; }

        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianCapNhat { get; set; }
        public int TrangThai { get; set; }

        public virtual NhanViens MaNVNavigation { get; set; }
    }
}
