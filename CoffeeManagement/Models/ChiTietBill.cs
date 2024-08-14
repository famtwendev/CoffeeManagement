namespace CoffeeManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietBill")]
    public partial class ChiTietBill
    {
        public int Id { get; set; }

        public int IdHoaDon { get; set; }

        public int IdMon { get; set; }

        public int SoLuong { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual Mon Mon { get; set; }
    }
}
