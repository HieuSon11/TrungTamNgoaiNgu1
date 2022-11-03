using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTTNN.TrungTamNgoaiNgu
{
    [Table("PhuongThucThanhToans")]
    public partial class PhuongThucThanhToan
    {
        public PhuongThucThanhToan()
        {
            ThanhToans = new HashSet<ThanhToan>();
        }
        [Key]
        public int MaPhuongThuc { get; set; }
        [Required]
        public string TenPhuongThuc { get; set; }

        public virtual ICollection<ThanhToan> ThanhToans { get; set; }
    }
}
