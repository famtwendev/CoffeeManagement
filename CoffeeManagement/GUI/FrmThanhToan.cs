using CoffeeManagement.Models;
using CoffeeManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement.GUI
{
    public partial class FrmThanhToan : Form
    {
        private bool isButtonClicked = false;
        Account account;
        double giatien;
        public double thanhtien;
        public int chonlua = 0;
        private string status = "";
        public FrmThanhToan()
        {
            InitializeComponent();
        }
        public FrmThanhToan(Account accountt, string statust, double TongTienHoaDon)
        {
            this.account = accountt;
            this.giatien = TongTienHoaDon;
            this.status = statust;
            InitializeComponent();
        }
        private void Caidat()
        {
            btnGiam20.Enabled = false;
            btnGiam10.Enabled = false;
            btnGH10.Enabled = false;
            btnGH15.Enabled = false;
        }
        private void FrmThanhToan_Load(object sender, EventArgs e)
        {
            Caidat();
            tabControl1.SelectTab(2);
            txtTienCanTra.Text = txtTongtien.Text = giatien.ToString();
            if (account.IDAccount != 1)
            {
                btnGiam50.Enabled = false;
            }
            if (status == "Giao Hàng")
            {
                btnGH10.Enabled = true;
                btnGH15.Enabled = true;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Lấy chữ số từ nút số và thêm vào TextBox
            txtTienKhach.Text += button.Text;
        }
        private void btnTien_Click(object sender, EventArgs e)
        {
            txtTienKhach.Text = null;
            txtKhachDua.Text = 0.ToString();
            txtTraLai.Text = 0.ToString();
            txtThieu.Text = 0.ToString();
            isButtonClicked = false;
        }
        private bool KTTien()
        {
            if (String.IsNullOrEmpty(txtTienKhach.Text))
            {
                error.SetError(txtTienKhach, "*");
                return false;
            }
            return true;
        }

        private void btnGiam10_Click(object sender, EventArgs e)
        {
            double giamgia = (double.Parse(txtTongtien.Text) * 10) / 100;
            txtGiamGia.Text = giamgia.ToString();
            btnGiam50.Enabled = false;
            tabControl1.SelectTab(2);
        }

        private void btnGiam20_Click(object sender, EventArgs e)
        {
            double giamgia = (double.Parse(txtTongtien.Text) * 20) / 100;
            txtGiamGia.Text = giamgia.ToString();
            btnGiam50.Enabled = false;
            tabControl1.SelectTab(2);
        }

        private void btnGiam50_Click(object sender, EventArgs e)
        {
            double giamgia = (double.Parse(txtTongtien.Text) * 50) / 100;
            txtGiamGia.Text = giamgia.ToString();
            btnGiam10.Enabled = false;
            btnGiam20.Enabled = false;
            btnGiam50.Enabled = false;
            tabControl1.SelectTab(2);
        }

        private void btnGiam5k_Click(object sender, EventArgs e)
        {
            txtGiamGia.Text = (double.Parse(txtGiamGia.Text) + 5000).ToString();
            btnGiam10K.Enabled = false;
            btnGiam15K.Enabled = false;
            tabControl1.SelectTab(2);
        }

        private void btnGiam10K_Click(object sender, EventArgs e)
        {
            txtGiamGia.Text = (double.Parse(txtGiamGia.Text) + 10000).ToString();
            btnGiam5K.Enabled = false;
            btnGiam15K.Enabled = false;
            tabControl1.SelectTab(2);
        }

        private void btnGiam15K_Click(object sender, EventArgs e)
        {
            txtGiamGia.Text = (double.Parse(txtGiamGia.Text) + 15000).ToString();
            btnGiam5K.Enabled = false;
            btnGiam10K.Enabled = false;
            tabControl1.SelectTab(2);
        }

        private void btnGH10_Click(object sender, EventArgs e)
        {
            txtTongtien.Text = (double.Parse(txtTongtien.Text) + 10000).ToString();
            btnGH15.Enabled = false;
            tabControl1.SelectTab(2);
        }

        private void btnGH15_Click(object sender, EventArgs e)
        {
            txtTongtien.Text = (double.Parse(txtTongtien.Text) + 15000).ToString();
            btnGH10.Enabled = false;
            tabControl1.SelectTab(2);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            chonlua = 0;
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (QuanLyCaPheModels db = new QuanLyCaPheModels())
            {
                string sodienthoai = txtsdt.Text;
                List<TheThanhVien> dsThanhVien = db.TheThanhViens.ToList();
                foreach (var item in dsThanhVien)
                {
                    TheThanhVien tim = db.TheThanhViens.FirstOrDefault(c => c.SoDT == sodienthoai);
                    if (tim != null)
                    {
                        btnGiam10.Enabled = true;
                        btnGiam20.Enabled = true;
                        txtKH.Text = tim.TenKH;
                        if (string.IsNullOrEmpty(tim.DiaChi) == false)
                            txtDiaChi.Text = tim.DiaChi.ToString();
                        else
                        {
                            txtDiaChi.Text = tim.DiaChi = "";
                        }
                        if (string.IsNullOrEmpty(tim.Email) == false)
                            txtEmail.Text = tim.Email.ToString();
                        else
                        {
                            txtEmail.Text = tim.Email = "";
                        }
                        txtHangThe.Text = tim.KMLoai;
                        txtDiem.Text = tim.Diem.ToString();
                        if (txtHangThe.Text == "Platium")
                        {
                            btnGiam20.Enabled = true;
                            btnGiam10.Enabled = false;
                        }
                        else if (txtHangThe.Text == "Sliver")
                        {
                            btnGiam10.Enabled = true;
                            btnGiam20.Enabled = false;
                        }
                        else if (txtHangThe.Text == "Bronze")
                        {
                            btnGiam10.Enabled = false;
                            btnGiam20.Enabled = false;
                        }
                        tabControl1.SelectTab(2);
                    }
                    else
                    {
                        txtKH.Text = txtDiaChi.Text = txtEmail.Text = txtDiem.Text = txtHangThe.Text = string.Empty;
                        Caidat();
                    }
                }
            }
        }
        private void btnXacNhanTien_Click(object sender, EventArgs e)
        {
            txtKhachDua.Text = txtTienKhach.Text;
            if (KTTien())
            {
                double tinh = double.Parse(txtKhachDua.Text) - double.Parse(txtTongtien.Text);
                if (tinh > 0)
                {
                    txtTraLai.Text = (double.Parse(txtKhachDua.Text) - double.Parse(txtTongtien.Text) + double.Parse(txtGiamGia.Text)).ToString();
                    thanhtien = double.Parse(txtTongtien.Text) - double.Parse(txtGiamGia.Text);
                    isButtonClicked = true;
                }
                else if (tinh < 0)
                {
                    txtThieu.Text = (double.Parse(txtKhachDua.Text) - double.Parse(txtTongtien.Text) + double.Parse(txtGiamGia.Text)).ToString();
                    MessageBox.Show("Không được thiếu\n Vui lòng nhập số tiền lớn hơn số tiền phải thanh toán", "Thông Báo");
                    txtTienKhach.Text = string.Empty;
                    txtKhachDua.Text = txtTraLai.Text = txtThieu.Text = 0.ToString();
                }
                else
                {
                    isButtonClicked = true;
                    thanhtien = double.Parse(txtTongtien.Text) - double.Parse(txtGiamGia.Text);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số tiền khách đưa");
                return;
            }
        }
        private void btnHoantat_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtsdt.Text) == false)
            {
                if (isButtonClicked == true)
                {
                    using (QuanLyCaPheModels db = new QuanLyCaPheModels())
                    {
                        string sodienthoai = txtsdt.Text;
                        TheThanhVien thanhVien = db.TheThanhViens.FirstOrDefault(c => c.SoDT == sodienthoai);
                        if (thanhVien != null) // có trùng sdt
                        {
                            thanhVien.TenKH = txtKH.Text;
                            thanhVien.DiaChi = txtDiaChi.Text;
                            txtDiem.ReadOnly = false;
                            txtHangThe.ReadOnly = false;
                            thanhVien.Email = txtEmail.Text;
                            thanhVien.Diem = int.Parse(txtDiem.Text) + 10;
                            if (thanhVien.Diem >= 200 && thanhVien.Diem < 500)
                            {
                                thanhVien.KMLoai = "Sliver";
                            }
                            else if (thanhVien.Diem >= 500)
                            {
                                thanhVien.KMLoai = "Platium";
                            }
                            else if (thanhVien.Diem > 0 && thanhVien.Diem < 200)
                                thanhVien.KMLoai = txtHangThe.Text;
                            db.SaveChanges();
                        }
                        chonlua = 1;
                        this.Close();
                    }
                }
                else
                {
                    chonlua = 0;
                    MessageBox.Show("Vui lòng xác nhận trước khi hoàn tất!");
                    return;
                }

            }
            else
            {
                if (isButtonClicked == true)
                {
                    chonlua = 1;
                    this.Close();
                }
                else if (isButtonClicked == false)
                {
                    chonlua = 0;
                    MessageBox.Show("Vui lòng xác nhận trước khi hoàn tất!");
                    return;
                }
            }
        }
    }
}
