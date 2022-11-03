using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTTNN.TrungTamNgoaiNgu
{
    [Table("KhoaHocs")]
    public partial class KhoaHoc
    {
        public KhoaHoc()
        {
            LopHocs = new HashSet<LopHoc>();
        }

        [Key]
        public int MaKhoaHoc { get; set; }
        [Required]
        public int BaiHoc { get; set; }
        public string MoTa { get; set; }
        [Required]
        public string KyHan { get; set; }
        public int? MaNgonNgu { get; set; }
        public int? MaCapDo { get; set; }
        public int? LoaiKhoaHoc { get; set; }

        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianCapNhat { get; set; }
        public int TrangThai { get; set; }

        public virtual LoaiKhoaHoc LoaiKhoaHocNavigation { get; set; }
        public virtual CapDo MaCapDoNavigation { get; set; }
        public virtual NgonNgu MaNgonNguNavigation { get; set; }
        public virtual ICollection<LopHoc> LopHocs { get; set; }
    }
}
