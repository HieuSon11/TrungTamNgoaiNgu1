using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTTNN.TrungTamNgoaiNgu
{
    [Table("Congs")]
    public partial class Cong
    {
        public Cong()
        {
            ThanhToanLuongs = new HashSet<ThanhToanLuong>();
        }
        [Key]
        public int MaCong { get; set; }
        public int? NhanVienID { get; set; }
        public int? NgayCong { get; set; }
        public int? NghiHl { get; set; }
        public DateTime? Ngay { get; set; }
        public virtual NhanViens MaNvNavigation { get; set; }
        public virtual ICollection<ThanhToanLuong> ThanhToanLuongs { get; set; }
    }
}
