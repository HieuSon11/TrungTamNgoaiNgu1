using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTTNN.TrungTamNgoaiNgu
{
    [Table("LopHocSinhs")]
    public partial class LopHocSinh
    {
        [Key]
        public int MaLopHs { get; set; }
        public int? LopHocID { get; set; }
        public int? HocSinhID { get; set; }

        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianCapNhat { get; set; }
        public int TrangThai { get; set; }

        public virtual HocSinh MaHsNavigation { get; set; }
        public virtual LopHoc MaLopNavigation { get; set; }
    }
}
