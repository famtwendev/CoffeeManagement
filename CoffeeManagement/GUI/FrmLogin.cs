using CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement.GUI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //gan de test
            txtuser.Text = "admin";
            txtpass.Text = "admin";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự có muốn thoát chương trình?", "Thông báo thoát", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }


        private void showPass_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                txtpass.UseSystemPasswordChar = false;
                flag = 1;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
                flag = 0;
            }
        }
        private void DangNhap_Load(object sender, EventArgs e)
        {
        }

        //Chúc năng đăng nhập khi liên kết với sql 
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Account account1 = new Account();
            if (KiemTraThongTin())
            {
                string username = txtuser.Text;
                string password = txtpass.Text;

                // Tim va truyen account vao cac form khac
                using (QuanLyCaPheModels db = new QuanLyCaPheModels())
                {
                    Account tim = db.Accounts.FirstOrDefault(c => c.UserName == username);
                    if (tim == null)
                    {
                        MessageBox.Show("Sai tên đăng nhập!!!", "Thông báo");
                        return;
                    }
                    if (tim != null) // co ton tai user trong danh sach
                    {
                        if (BCrypt.Net.BCrypt.Verify(password, tim.Password))
                        {
                            account1.UserName = username;
                            account1.Password = tim.Password;
                            account1.IDAccount = tim.IDAccount;
                            account1.DisplayName = tim.DisplayName;
                            this.Hide();
                            FrmMHChinh frmOrder = new FrmMHChinh(account1);
                            frmOrder.ShowDialog();
                            this.Show();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Sai mật khẩu!!!", "Thông báo");
                            return;
                        }

                    }

                }
            }
            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống!!!", "Thông báo");
            }
        }

        private bool KiemTraThongTin()
        {
            if (String.IsNullOrEmpty(txtuser.Text))
            {
                errorCanhBao.SetError(txtuser, "*");
                return false;
            }
            if (String.IsNullOrEmpty(txtpass.Text))
            {
                errorCanhBao.SetError(txtpass, "*");
                return false;
            }
            return true;
        }
        int flag = 0;

        private void Ketthuc(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnDangNhap_Click(sender, e);
            }
        }
    }
}
