using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTTNN.TrungTamNgoaiNgu
{
    [Table("NgonNgus")]
    public partial class NgonNgu
    {
        public NgonNgu()
        {
            KhoaHocs = new HashSet<KhoaHoc>();
        }
        [Key]
        public string MaNgonNgu { get; set; }
        [Required]
        public string TenNgonNgu { get; set; }

        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianCapNhat { get; set; }
        public int TrangThai { get; set; }

        public virtual ICollection<KhoaHoc> KhoaHocs { get; set; }
    }
}
