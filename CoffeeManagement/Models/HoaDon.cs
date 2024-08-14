namespace CoffeeManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            ChiTietBills = new HashSet<ChiTietBill>();
        }

        [Key]
        public int IdHoaDon { get; set; }

        [Column(TypeName = "date")]
        public DateTime ThoiGian { get; set; }

        public int IdBan { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        public double TongTien { get; set; }

        public double ThanhToan { get; set; }

        public virtual Ban Ban { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietBill> ChiTietBills { get; set; }
    }
}
