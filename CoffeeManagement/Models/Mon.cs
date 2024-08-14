namespace CoffeeManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mon")]
    public partial class Mon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mon()
        {
            ChiTietBills = new HashSet<ChiTietBill>();
        }

        [Key]
        public int IdMon { get; set; }

        [Required]
        [StringLength(100)]
        public string TenMon { get; set; }

        public double Gia { get; set; }

        public int IdDanhMuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietBill> ChiTietBills { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
    }
}
