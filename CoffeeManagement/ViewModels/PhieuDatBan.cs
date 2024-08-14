using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement.ViewModels
{
    class PhieuDatBan
    {
        public int Maban { get; set; }

        public List<MonDat> Danhsachmon { get; set; }
        public double TongTienHoaDon
        {
            get
            {
                return Danhsachmon.Sum(x => x.ThanhTien);
            }
        }
        public int TongSoMon
        {
            get
            {
                return Danhsachmon.Sum(x => x.SoLuong);
            }
        }

        public PhieuDatBan()
        {
            Danhsachmon = new List<MonDat>();
        }
        //phuong thuc goi mon 
        //1 Goi mon moi 
        //2 Cap nhap so luong mon da goi 
        public void Goimon(MonDat monDat)
        {
            MonDat mon = Danhsachmon.FirstOrDefault(x => x.MaMon == monDat.MaMon);
            if (mon != null)
            {
                mon.SoLuong = monDat.SoLuong;
            }
            else
            {
                Danhsachmon.Add(monDat);
            }
        }
        public void XoaMon(int mamon)
        {
            MonDat mon = Danhsachmon.FirstOrDefault(x => x.MaMon == mamon);
            if (mon != null)
            {
                Danhsachmon.Remove(mon);
            }
        }
    }
}
