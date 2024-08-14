using CoffeeManagement.Models;
using CoffeeManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement.GUI
{
    public partial class FrmMHChinh : Form
    {
        private Account account1;
        private Timer timer = new Timer();
        private Button banDangChon = null;
        private bool formBIsOpen = false;
        public FrmMHChinh()
        {
            InitializeComponent();
        }
        public FrmMHChinh(Account account)
        {
            account1 = account;
            InitializeComponent();
            InitializeUI();
            InitializeTimer();
        }
        private void InitializeUI()
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
            Controls.Add(labelTime);
            lableThang.Text = DateTime.Now.ToString("MMMM", CultureInfo.GetCultureInfo("en-US"));
            Controls.Add(lableThang);
            LabDateY.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Controls.Add(LabDateY);
        }
        private void InitializeTimer()
        {
            timer.Interval = 1000; // 1000ms = 1 giây
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        //-------------------------------------------------------
        private void FrmMHChinh_Load(object sender, EventArgs e)
        {
            btnOutMHC.Text = account1.DisplayName;
            LoadDanhSachBan();
        }
        //-------------------------------------------------------
        private void LoadDanhSachBan()
        {
            int x = 34, y = 160, count = 1; //toa do x va y
            using (var dbcontext = new QuanLyCaPheModels())
            {
                foreach (var ban in dbcontext.Bans.ToList())
                {
                    VeBan(ban, x, y);
                    if (count++ % 9 == 0)
                    {
                        x = 34;
                        y += 135;//122
                        continue;
                    }//120
                    x += 135;
                }
            }
        }
        private void VeBan(Ban ban, int x, int y)
        {
            Button btn = new Button();
            btn.Location = new Point(x, y);
            btn.Size = new Size(100, 100);
            btn.Text = ban.NameTable;
            btn.Tag = ban.IDTable;
            btn.BackColor = Color.Lavender;
            btn.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Bold);
            btn.FlatStyle = FlatStyle.Flat; // Đảm bảo FlatStyle được đặt thành Flat
            btn.FlatAppearance.BorderColor = Color.Red; // Thay đổi màu viền thành màu đỏ
            btn.FlatAppearance.BorderSize = 2;
            panelVIP.Controls.Add(btn);
            btn.Click += Btn_Click;
        }
        private void HideMH_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void outForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button banChon = sender as Button;
            banDangChon = banChon;
            FrmDichVu frmDichvu = new FrmDichVu(account1, banDangChon);
            frmDichvu.ShowDialog();        
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmChucNang form2 = new FrmChucNang(account1);
            form2.ShowDialog();
            this.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmThongKe frmThongKe = new FrmThongKe(account1);
            frmThongKe.ShowDialog();
            this.Show();
        }
    }
}
