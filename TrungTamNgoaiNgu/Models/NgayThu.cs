using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTTNN.TrungTamNgoaiNgu
{
    [Table("NgayThus")]
    public partial class NgayThu
    {
        public NgayThu()
        {
            LopNgayThus = new HashSet<LopNgayThu>();
        }

        [Key]
        public int MaNgay { get; set; }
        [Required]
        public string TenNgayThu { get; set; }

        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianCapNhat { get; set; }
        public int TrangThai { get; set; }

        public virtual ICollection<LopNgayThu> LopNgayThus { get; set; }
    }
}
