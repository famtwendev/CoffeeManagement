using CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using GroupBox = System.Windows.Forms.GroupBox;
using Label = System.Windows.Forms.Label;

namespace CoffeeManagement.GUI
{
    public partial class FrmThongKe : Form
    {
        Account account;
        public FrmThongKe()
        {
            InitializeComponent();
        }

        public FrmThongKe(Account accounty)
        {
            this.account = accounty;
            InitializeComponent();
        }
        private void LoadBill()
        {
            int x = 10, y = 15, count = 1; //toa do x va y
            using (var dbcontext = new QuanLyCaPheModels())
            {
                foreach (var hoadon in dbcontext.HoaDons.ToList())
                {
                    VeHoaDon(hoadon, x, y);
                    if (count++ % 4 == 0)
                    {
                        x = 10;
                        y += 220;
                        continue;
                    }
                    x += 315;
                }
            }
        }

        private void VeHoaDon(HoaDon old, int x, int y)
        {
            System.Windows.Forms.GroupBox groupBox = new System.Windows.Forms.GroupBox();
            groupBox.Text = string.Format("Bàn {0}", old.IdBan); // Đặt tiêu đề "Tên bàn"
            groupBox.Font = new System.Drawing.Font(groupBox.Font.FontFamily, 12, FontStyle.Bold);
            groupBox.Size = new Size(290, 180);
            groupBox.Location = new System.Drawing.Point(x, y);
            groupBox.Tag = old.IdHoaDon;

            // Tạo ba Label bên trong GroupBox
            Label label1 = new Label();
            label1.Location = new System.Drawing.Point(20, 45);
            label1.Text = string.Format("Mã hóa đơn: {0}", old.IdHoaDon);
            label1.AutoSize = true;



            Label label2 = new Label();
            label2.Location = new System.Drawing.Point(20, 85);
            label2.Text = string.Format("Tổng cộng:  {0}", old.TongTien);
            label2.AutoSize = true;

            Label label3 = new Label();
            label3.Text = string.Format("Thanh toán: {0}", old.ThanhToan);
            label3.Location = new System.Drawing.Point(20, 125);
            label3.AutoSize = true;
            Label label4 = new Label();



            label4.Text = old.ThoiGian.ToString();
            label4.Location = new System.Drawing.Point(80, 15);
            label4.AutoSize = true;

            if (old.Status == "Mang Về")
            {
                groupBox.BackColor = Color.Khaki;
            }
            else if (old.Status == "Giao Hàng")
            {
                groupBox.BackColor = Color.CornflowerBlue;
            }
            else if (old.Status == "Tại Quán")
            {
                groupBox.BackColor = Color.Aqua;
            }

            foreach (Control control in groupBox.Controls)
            {
                control.Font = new System.Drawing.Font(control.Font.FontFamily, 12, FontStyle.Bold);
            }
            groupBox.Controls.Add(label1);
            groupBox.Controls.Add(label2);
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(label4);
            panelBaoCao.Controls.Add(groupBox);
            groupBox.Click += Groupbox_Click;
        }
        private void Groupbox_Click(object sender, EventArgs e)
        {
            GroupBox groupBox = sender as GroupBox;
            int mahoadon = (int)groupBox.Tag;
            FrmQuanLyHoaDon frmQuanLyHoaDon = new FrmQuanLyHoaDon(mahoadon);
            frmQuanLyHoaDon.ShowDialog();
            if (frmQuanLyHoaDon.abc == true)
            {
                btnTatca_Click(sender, new EventArgs());
            }
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            LoadBill();
        }

        private void btnGiaohang_Click(object sender, EventArgs e)
        {
            panelBaoCao.Controls.Clear();
            int x = 10, y = 15, count = 1; //toa do x va y
            using (var dbcontext = new QuanLyCaPheModels())
            {
                var status = "Giao Hàng"; // Điều kiện IdDanhMuc = 1
                var hoadons = dbcontext.HoaDons.Where(hoadon => hoadon.Status == status).ToList();
                foreach (var hoadon in hoadons)
                {
                    VeHoaDon(hoadon, x, y);
                    if (count++ % 4 == 0)
                    {
                        x = 10;
                        y += 220;
                        continue;
                    }
                    x += 3150;
                }
            }
        }

        private void btnMangve_Click(object sender, EventArgs e)
        {
            panelBaoCao.Controls.Clear();
            int x = 10, y = 15, count = 1; //toa do x va y
            using (var dbcontext = new QuanLyCaPheModels())
            {
                var status = "Mang Về"; // Điều kiện IdDanhMuc = 1
                var hoadons = dbcontext.HoaDons.Where(hoadon => hoadon.Status == status).ToList();
                foreach (var hoadon in hoadons)
                {
                    VeHoaDon(hoadon, x, y);
                    if (count++ % 4 == 0)
                    {
                        x = 10;
                        y += 220;
                        continue;
                    }
                    x += 315;
                }
            }
        }

        private void btnTaiquan_Click(object sender, EventArgs e)
        {
            panelBaoCao.Controls.Clear();
            int x = 10, y = 15, count = 1; //toa do x va y
            using (var dbcontext = new QuanLyCaPheModels())
            {
                var status = "Tại Quán"; // Điều kiện IdDanhMuc = 1
                var hoadons = dbcontext.HoaDons.Where(hoadon => hoadon.Status == status).ToList();
                foreach (var hoadon in hoadons)
                {
                    VeHoaDon(hoadon, x, y);
                    if (count++ % 4 == 0)
                    {
                        x = 10;
                        y += 220;
                        continue;
                    }
                    x += 315;
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTatca_Click(object sender, EventArgs e)
        {
            panelBaoCao.Controls.Clear();
            LoadBill();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int change = panelBaoCao.VerticalScroll.Value - panelBaoCao.VerticalScroll.SmallChange * 30;
            panelBaoCao.AutoScrollPosition = new Point(0, change);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int change = panelBaoCao.VerticalScroll.Value + panelBaoCao.VerticalScroll.SmallChange * 30;
            panelBaoCao.AutoScrollPosition = new Point(0, change);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
        }
    }
}
