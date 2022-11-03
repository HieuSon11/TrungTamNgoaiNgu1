using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTTNN.TrungTamNgoaiNgu
{
    [Table("TaiKhoanHSs")]
    public partial class TaiKhoanHS
    {
        [Key]
        public int MaTk { get; set; }
        public int? HocSinhID{ get; set; }
        public bool? TrangThai { get; set; }
        [Required]
        public string TenTaiKhoan { get; set; }
        [Required]
        public string MatKhau { get; set; }

        public virtual HocSinh MaHsNavigation { get; set; }
    }
}
