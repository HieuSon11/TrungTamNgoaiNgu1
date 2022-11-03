using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTTNN.TrungTamNgoaiNgu
{
    [Table("PhuHuynhs")]
    public partial class PhuHuynh
    {
        public PhuHuynh()
        {
            HocSinhs = new HashSet<HocSinh>();
        }

        [Key]
        public int MaPh { get; set; }
        [Required]
        public string Ho { get; set; }
        [Required]
        public string Ten { get; set; }
        [Required]
        public string Sdt { get; set; }

        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianCapNhat { get; set; }
        public int TrangThai { get; set; }

        public virtual ICollection<HocSinh> HocSinhs { get; set; }
    }
}
