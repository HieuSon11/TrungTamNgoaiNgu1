using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTTNN.TrungTamNgoaiNgu
{
    [Table("Lop_NgayThus")]
    public partial class LopNgayThu
    {
        [Key]
        [Column(Order = 1)]

        public int LopHocID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int NgayThuID { get; set; }
        [Required]
        public string Gio { get; set; }

        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianCapNhat { get; set; }
        public int TrangThai { get; set; }

        public virtual LopHoc MaLopNavigation { get; set; }
        public virtual NgayThu MaNgayNavigation { get; set; }
    }
}
