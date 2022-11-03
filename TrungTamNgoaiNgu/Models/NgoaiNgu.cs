using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTTNN.TrungTamNgoaiNgu
{
    [Table("NgoaiNgus")]
    public partial class NgoaiNgu
    {
        [Key]
        public int MaNn { get; set; }
        public int? NhanVienID { get; set; }
        [Required]
        public string TenNN { get; set; }

        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianCapNhat { get; set; }
        public int TrangThai { get; set; }

        public virtual NhanViens MaNvNavigation { get; set; }
    }
}
