using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.ViewModels
{
    internal class MonDat
    {
        public int MaMon { get; set; }
        public string TenMon { get; set; }
        public int SoLuong { get; set; }
        public double Gia { get; set; }
        public double ThanhTien { get { return SoLuong * Gia; } }
        public string TenDanhMuc { get; set; }
    }
}
