namespace CoffeeManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TheThanhVien")]
    public partial class TheThanhVien
    {
        [Key]
        [StringLength(100)]
        public string SoDT { get; set; }

        [Required]
        [StringLength(100)]
        public string TenKH { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string KMLoai { get; set; }

        public int Diem { get; set; }
    }
}
