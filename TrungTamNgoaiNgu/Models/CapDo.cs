using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTTNN.TrungTamNgoaiNgu
{
    [Table("CapDos")]
    public class CapDo
    {
        
        public CapDo()
        {
            KhoaHocs = new HashSet<KhoaHoc>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string TenCapDo { get; set; }

        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianCapNhat { get; set; }
        public int TrangThai { get; set; }

        public virtual ICollection<KhoaHoc> KhoaHocs { get; set; }
    }
}
