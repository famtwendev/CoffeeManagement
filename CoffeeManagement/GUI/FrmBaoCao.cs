using CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement.GUI
{
    public partial class FrmBaoCao : Form
    {
        public FrmBaoCao()
        {
            InitializeComponent();
        }

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            double tongtien = 0;
            double thanhtien = 0 ;
            int taiquann = 0, mangvee = 0, giaohangg = 0;

            using (var db = new QuanLyCaPheModels())
            {
                foreach (var hoadon in db.HoaDons.ToList())
                {
                    tongtien += hoadon.TongTien;
                    thanhtien += hoadon.ThanhToan;
                    if (hoadon.Status == "Mang Về")
                        mangvee+= 1;
                    else if(hoadon.Status == "Giao Hàng")
                        giaohangg += 1;
                    else if(hoadon.Status == "Tại Quán")
                        taiquann += 1;
                }
                truocgiam.Text = tongtien.ToString();
                saugiam.Text = thanhtien.ToString();
                mangve.Text = mangvee.ToString();
                taiquan.Text = taiquann.ToString();
                giaohang.Text = giaohangg.ToString();
            }
        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
