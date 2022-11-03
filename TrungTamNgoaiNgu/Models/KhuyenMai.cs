using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTTNN.TrungTamNgoaiNgu
{
    [Table("KhuyenMais")]
    public partial class KhuyenMai
    {
        public KhuyenMai()
        {
            ThanhToans = new HashSet<ThanhToan>();
        }

        [Key]
        public int MaKm { get; set; }
        [Required]
        public string NoiDungKm { get; set; }
        [Required]
        public string DieuKien { get; set; }
        [Required]
        public int KmtheoPt { get; set; }
        [Required]
        public float Voucher { get; set; }
        [Required]
        public DateTime NgayBd { get; set; }
        [Required]
        public DateTime NgayKt { get; set; }

        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianCapNhat { get; set; }
        public int TrangThai { get; set; }

        public virtual ICollection<ThanhToan> ThanhToans { get; set; }
    }
}
