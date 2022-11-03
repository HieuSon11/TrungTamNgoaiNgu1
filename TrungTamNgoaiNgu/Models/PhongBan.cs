using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTTNN.TrungTamNgoaiNgu
{
    [Table("PhongBans")]
    public partial class PhongBan
    {
        public PhongBan()
        {
            NhanViens = new HashSet<NhanViens>();
        }

        [Key]
        public int MaPb { get; set; }
        [Required]
        public string TenPhonSg { get; set; }

        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianCapNhat { get; set; }
        public int TrangThai { get; set; }

        public virtual ICollection<NhanViens> NhanViens { get; set; }
    }
}
