using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTTNN.TrungTamNgoaiNgu
{
    [Table("HocSinhs")]
    public partial class HocSinh
    {
        public HocSinh()
        {
            LopHocSinhs = new HashSet<LopHocSinh>();
            TaiKhoanHs = new HashSet<TaiKhoanHS>();
            ThanhToans = new HashSet<ThanhToan>();
        }
        [Key]
        public int MaHs { get; set; }
        [Required]
        public string Ho { get; set; }
        [Required]
        public string Ten { get; set; }
        public DateTime? NgaySinh { get; set; }
        [Required]
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string Dchi { get; set; }
        public string MaPh { get; set; }
        
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianCapNhat { get; set; }
        public int TrangThai { get; set; }


        public virtual PhuHuynh MaPhNavigation { get; set; }
        public virtual ICollection<LopHocSinh> LopHocSinhs { get; set; }
        public virtual ICollection<TaiKhoanHS> TaiKhoanHs { get; set; }
        public virtual ICollection<ThanhToan> ThanhToans { get; set; }
    }
}
