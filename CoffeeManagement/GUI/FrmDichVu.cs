using CoffeeManagement.Models;
using CoffeeManagement.ViewModels;
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
    public partial class FrmDichVu : Form
    {
        private string status = null;
        private Button banDangChon = null;
        private Account accountb = null;
        public FrmDichVu()
        {
            InitializeComponent();
        }
        public FrmDichVu(Account accountcu, Button Bandangchon)
        {
            this.accountb = accountcu;
            this.banDangChon = Bandangchon;
            InitializeComponent();          
        }

        //xfgAfhaerfh

        //ÁDsdgaefhgaerfh
        private void btnGiaoHang_Click(object sender, EventArgs e)
        {
            status = "Giao Hàng";
            FrmThucUong frmThucUong = new FrmThucUong(accountb, banDangChon, status);
            frmThucUong.ShowDialog();
            this.Close();
        }

        private void btnMangVe_Click(object sender, EventArgs e)
        {
            status = "Mang Về";
            FrmThucUong frmThucUong = new FrmThucUong(accountb, banDangChon, status);
            frmThucUong.ShowDialog();
            this.Close();
        }

        private void btnTaiQuan_Click(object sender, EventArgs e)
        {
            status = "Tại Quán";
            FrmThucUong frmThucUong = new FrmThucUong(accountb, banDangChon, status);
            frmThucUong.ShowDialog();
            this.Close();
        }

        private void FrmDichVu_Load(object sender, EventArgs e)
        {
            btnGiaoHang.FlatStyle = btnTaiQuan.FlatStyle = btnMangVe.FlatStyle = FlatStyle.Flat; // Đảm bảo FlatStyle được đặt thành Flat
            btnGiaoHang.FlatAppearance.BorderColor = Color.White;
            btnMangVe.FlatAppearance.BorderColor = Color.White;
            btnTaiQuan.FlatAppearance.BorderColor = Color.White;
            btnGiaoHang.FlatAppearance.BorderSize = btnMangVe.FlatAppearance.BorderSize = btnTaiQuan.FlatAppearance.BorderSize = 10;
        }
    }
}
