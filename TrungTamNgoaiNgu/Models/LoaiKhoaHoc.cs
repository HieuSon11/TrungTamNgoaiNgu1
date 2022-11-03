using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTTNN.TrungTamNgoaiNgu
{
    [Table("LoaiKhoaHocs")]
    public partial class LoaiKhoaHoc
    {
        public LoaiKhoaHoc()
        {
            KhoaHocs = new HashSet<KhoaHoc>();
        }
        [Key]
        public int MaLoai { get; set; }
        [Required]
        public string TenLoai { get; set; }

        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianCapNhat { get; set; }
        public int TrangThai { get; set; }

        public virtual ICollection<KhoaHoc> KhoaHocs { get; set; }
    }
}
