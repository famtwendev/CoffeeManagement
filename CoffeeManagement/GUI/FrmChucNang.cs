using CoffeeManagement.Models;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CoffeeManagement.GUI
{
    public partial class FrmChucNang : Form
    {
        Account accountt = new Account();
        public FrmChucNang()
        {
            InitializeComponent();
        }
        public FrmChucNang(Account account1)
        {
            accountt = account1;
            InitializeComponent();
            CaiDatDieuKhien();
        }
        private void picEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool KiemTraThongTin()
        {
            if (String.IsNullOrEmpty(txtsdt.Text))
            {
                errorCanhBao.SetError(txtsdt, "*");
                return false;
            }
            if (String.IsNullOrEmpty(txtKH.Text))
            {
                errorCanhBao.SetError(txtKH, "*");
                return false;
            }
            if (String.IsNullOrEmpty(cmbHangThe.Text))
            {
                errorCanhBao.SetError(cmbHangThe, "*");
                return false;
            }
            int diem;
            if (int.TryParse(txtDiem.Text, out diem) && diem < 0 || diem == null)
            {
                errorCanhBao.SetError(txtDiem, "*");
                return false;
            }
            return true;
        }
        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
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
                            cmbHangThe.Text = tim.KMLoai;
                            txtDiem.Text = tim.Diem.ToString();
                            return;
                        }
                    }
                    if (String.IsNullOrEmpty(txtsdt.Text))
                    {
                        errorCanhBao.SetError(txtsdt, "*");
                        return;
                    }
                }
            }
        }
        private void txtsdt_Validating(object sender, CancelEventArgs e)
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
                        txtKH.Text = tim.TenKH;
                        txtDiaChi.Text = tim.DiaChi;
                        txtEmail.Text = tim.Email.ToString();
                        cmbHangThe.Text = tim.KMLoai;
                        txtDiem.Text = tim.Diem.ToString();
                        return;
                    }
                }
            }
        }

        private void Empty()
        {
            txtKH.Text = txtsdt.Text = txtDiaChi.Text = txtEmail.Text = string.Empty;
            txtDiem.Text = null;
            txtHotenND.Text = txtNewPass.Text = txtPassNow.Text = txtusername.Text = cmbTypeAcc.Text = string.Empty;
        }
        private void btnCapTheThanhVien_Click(object sender, EventArgs e)
        {
            using (QuanLyCaPheModels db = new QuanLyCaPheModels())
            {
                string sodienthoai = txtsdt.Text;
                TheThanhVien tim = db.TheThanhViens.FirstOrDefault(c => c.SoDT == sodienthoai);
                if (tim == null)
                {
                    if (KiemTraThongTin() == true)
                    {
                        TheThanhVien newThanhVien = new TheThanhVien()
                        {
                            SoDT = sodienthoai,
                            TenKH = txtKH.Text,
                            DiaChi = txtDiaChi.Text,
                            Email = txtEmail.Text,
                            KMLoai = cmbHangThe.Text
                        };
                        db.TheThanhViens.Add(newThanhVien);
                        db.SaveChanges();
                        MessageBox.Show("Thêm thành viên thành công!");
                        Empty();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại vừa nhập hiện đã có trong danh sách. Hãy sửa thông tin nếu cần thiết!");
                    return;
                }

            }
        }
        private void btnXoaThe_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin() == true)
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
                            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thành viên này khỏi danh sách", "Xác nhận xóa", MessageBoxButtons.OKCancel);
                            if (result == DialogResult.OK)
                            {
                                db.TheThanhViens.Remove(tim);
                                db.SaveChanges();
                                Empty();
                            }
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Số điện thoại vừa nhập không có trong danh sách!", "Nhập lại!", MessageBoxButtons.OKCancel);
                            //                          MessageBox.Show("Không có số điện thoại nào trùng với số vừa nhập!");
                            return;
                        }
                    }
                }
            }
        }
        private void btnSuaTheTV_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin() == true)
            {
                using (QuanLyCaPheModels db = new QuanLyCaPheModels())
                {
                    string sodienthoai = txtsdt.Text;
                    TheThanhVien thanhVien = db.TheThanhViens.FirstOrDefault(c => c.SoDT == sodienthoai);
                    if (thanhVien != null) // có trùng sdt
                    {
                        thanhVien.TenKH = txtKH.Text;
                        thanhVien.DiaChi = txtDiaChi.Text;
                        thanhVien.Email = txtEmail.Text;
                        thanhVien.Diem = int.Parse(txtDiem.Text);
                        thanhVien.KMLoai = cmbHangThe.Text;
                        db.SaveChanges();
                        MessageBox.Show("Sửa Thành Viên Thành Công!");
                        Empty();
                        return;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Số điện thoại vừa nhập không có trong danh sách!\n\nThêm mới thì nhấn OK", "Thông Báo", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            btnCapTheThanhVien_Click(sender, e);
                        }
                        else
                            return;
                    }
                }
            }
        }


        private void FrmChucNang_Load(object sender, EventArgs e)
        {
            cmbHangThe.Items.Add("Bronze");
            cmbHangThe.Items.Add("Sliver");
            cmbHangThe.Items.Add("Platium");
            cmbHangThe.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHangThe.SelectedIndex = 0;
            if (accountt.IDAccount != 1)
            {
                btnDangKy.Visible = false;
                btnXoaTKNguoiDung.Visible = false;

                labelHoTenND.Visible = false;
                txtHotenND.Visible = false;

                labeltenDN.Visible = false; // ten Dang Nhap
                txtusername.Visible = false;

                labelLoaiTK.Visible = false;
                cmbTypeAcc.Visible = false;
            }
            else
            {
                cmbTypeAcc.Items.Add(1);
                cmbTypeAcc.Items.Add(2);
                cmbTypeAcc.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbTypeAcc.SelectedIndex = 0;
                labelNew.Visible = false; // ten Dang Nhap
                txtNewPass.Visible = false;
                btnDoiPassNguoiDung.Visible = false;
            }
            LoadDanhMuc();
        }


        private bool KiemTraThongTinNguoiDung()
        {
            if (String.IsNullOrEmpty(txtusername.Text))
            {
                errorCanhBao.SetError(txtusername, "*");
                return false;
            }
            if (String.IsNullOrEmpty(txtHotenND.Text))
            {
                errorCanhBao.SetError(txtHotenND, "*");
                return false;
            }
            if (String.IsNullOrEmpty(txtPassNow.Text))
            {
                errorCanhBao.SetError(txtPassNow, "*");
                return false;
            }
            int cmbLoai;
            if (int.TryParse(cmbTypeAcc.Text, out cmbLoai) && cmbLoai <= 0 || cmbLoai >= 3 || cmbLoai == null)
            {
                errorCanhBao.SetError(cmbTypeAcc, "*");
                return false;
            }
            return true;
        }

        private bool KTPassNew()
        {
            if (String.IsNullOrEmpty(txtNewPass.Text))
            {
                errorCanhBao.SetError(txtNewPass, "*");
                return false;
            }
            return true;
        }

        private void btnDoiPassNguoiDung_Click(object sender, EventArgs e)
        {
            if (accountt.IDAccount != 1)
            {
                using (QuanLyCaPheModels db = new QuanLyCaPheModels())
                {
                    Account acc = db.Accounts.FirstOrDefault(c => c.UserName == accountt.UserName && c.Password == txtPassNow.Text);
                    if (acc != null) // có trùng sdt
                    {
                        if (KTPassNew())
                        {
                            acc.Password = txtNewPass.Text;
                            db.SaveChanges();
                            MessageBox.Show("Đổi Mật Khẩu Thành Công!");
                            txtNewPass.Text = txtPassNow.Text = string.Empty;
                        }
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Không đổi được mật khẩu! Mật khẩu nhập không khớp!!!", "Thông báo");
                        return;
                    }
                }
            }
        }
        private void btnXoaTKNguoiDung_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinNguoiDung())
            {
                using (QuanLyCaPheModels db = new QuanLyCaPheModels())
                {
                    string tentaikhoan = txtsdt.Text;
                    List<Account> dsacc = db.Accounts.ToList();
                    foreach (var item in dsacc)
                    {
                        Account tim = db.Accounts.FirstOrDefault(c => c.UserName == txtusername.Text);
                        if (tim != null)
                        {
                            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này khỏi danh sách", "Xác nhận xóa", MessageBoxButtons.OKCancel);
                            if (result == DialogResult.OK)
                            {
                                db.Accounts.Remove(tim);
                                db.SaveChanges();
                                Empty();
                            }
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập không có trong danh sách!", "Nhập lại!", MessageBoxButtons.OKCancel);
                            //                          MessageBox.Show("Không có số điện thoại nào trùng với số vừa nhập!");
                            return;
                        }
                    }
                }
            }
        }

        private void btnDangKy_Sua_Click(object sender, EventArgs e)
        {
            if (accountt.IDAccount == 1)
            {
                using (QuanLyCaPheModels db = new QuanLyCaPheModels())
                {
                    if (KiemTraThongTinNguoiDung())
                    {
                        string us = txtusername.Text;
                        string ps = txtPassNow.Text;
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(ps);
                        Account tam = db.Accounts.FirstOrDefault(c => c.UserName == us);
                        if (tam != null)
                        {
                            DialogResult result = MessageBox.Show("Tên đăng nhập đã có trong danh sách!\n\nCập nhật thông tin người dùng!Click 'OK'", "Thông Báo", MessageBoxButtons.OKCancel);
                            if (result == DialogResult.OK)
                            {
                                tam.UserName = us;
                                tam.DisplayName = txtHotenND.Text;
                                tam.Password = hashedPassword;
                                tam.IDAccount = int.Parse(cmbTypeAcc.Text);
                                db.SaveChanges();
                                MessageBox.Show("Cập nhật thông tin người dùng thành công!");
                            }
                            else
                            {
                                Empty();
                                return;
                            }
                        }
                        else
                        {
                            Account newAccount = new Account()
                            {
                                UserName = us,
                                DisplayName = txtHotenND.Text,
                                Password = hashedPassword,
                                IDAccount = int.Parse(cmbTypeAcc.Text)
                            };
                            db.Accounts.Add(newAccount);
                            db.SaveChanges();
                            MessageBox.Show("Thêm người dùng thành công!");
                        }
                        Empty();
                    }
                }
            }
        }
        private void CaiDatDieuKhien()
        {
            cmbDanhMuc.DisplayMember = "TenDanhMuc"; // Ten: thuoc tinh trong bang Danh Muc
            cmbDanhMuc.ValueMember = "IdDanhMuc";
            cmbDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void ClearInput()
        {
            txtIDmon.Text = txtTenMon.Text = txtGiaMon.Text = string.Empty;
            cmbDanhMuc.SelectedIndex = 0;
        }
        private void LoadDanhMuc()
        {
            try
            {
                using (var dbcontext = new QuanLyCaPheModels())
                {
                    cmbDanhMuc.DataSource = dbcontext.DanhMucs.Select(x => new { x.TenDanhMuc, x.IdDanhMuc }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load danh mục!!!");
            }
        }
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (KiemTraTTMon())
            {
                using (var db = new QuanLyCaPheModels())
                {
                    string us = txtTenMon.Text;
                    Mon tenmon = db.Mons.FirstOrDefault(c => c.TenMon == us);
                    if (tenmon != null)
                    {
                        MessageBox.Show("Tên món này đã có");
                    }
                    else
                    {
                        Mon mon = new Mon()
                        {
                            IdMon = int.Parse(txtIDmon.Text),
                            TenMon = txtTenMon.Text,
                            Gia = double.Parse(txtGiaMon.Text),
                            IdDanhMuc = int.Parse(cmbDanhMuc.SelectedValue.ToString()),
                        };
                        using (var dbcontext = new QuanLyCaPheModels())
                        {
                            dbcontext.Mons.Add(mon);
                            dbcontext.SaveChanges();
                            MessageBox.Show("Thêm món thành công!");
                            ClearInput();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Thêm món không thành công!");
            }
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (KiemTraTTMon())
            {
                using (QuanLyCaPheModels db = new QuanLyCaPheModels())
                {
                    string id = txtIDmon.Text;
                    int idmon = int.Parse(id);
                    List<Mon> dsmon = db.Mons.ToList();
                    foreach (var item in dsmon)
                    {
                        Mon tim = db.Mons.FirstOrDefault(c => c.IdMon == idmon);
                        if (tim != null)
                        {
                            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa món này khỏi danh sách", "Xác nhận xóa", MessageBoxButtons.OKCancel);
                            if (result == DialogResult.OK)
                            {
                                db.Mons.Remove(tim);
                                db.SaveChanges();
                                ClearInput();
                            }
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Số ID món vừa nhập không có trong danh sách!", "Nhập lại!", MessageBoxButtons.OKCancel);

                            return;
                        }
                    }
                }
            }
        }

        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            if (KiemTraTTMon())
            {
                using (QuanLyCaPheModels db = new QuanLyCaPheModels())
                {
                    string id = txtIDmon.Text;
                    int ID = int.Parse(id);
                    Mon mon = db.Mons.FirstOrDefault(c => c.IdMon == ID);
                    if (mon != null)
                    {
                        mon.IdMon = int.Parse(txtIDmon.Text);
                        mon.TenMon = txtTenMon.Text;
                        mon.Gia = double.Parse(txtGiaMon.Text);
                        mon.IdDanhMuc = int.Parse(cmbDanhMuc.SelectedValue.ToString());
                        db.SaveChanges();
                        MessageBox.Show("Sửa món Thành Công!");
                        ClearInput();
                        return;
                    }
                }
            }
        }

        private void txtIDmon_Validated(object sender, EventArgs e)
        {
            using (QuanLyCaPheModels db = new QuanLyCaPheModels())
            {
                string id = txtIDmon.Text;
                int idmon = int.Parse(id);
                List<Mon> dsmon = db.Mons.ToList();
                foreach (var item in dsmon)
                {
                    Mon tim = db.Mons.FirstOrDefault(c => c.IdMon == idmon);
                    if (tim != null)
                    {
                        txtIDmon.Text = tim.IdMon.ToString();
                        txtTenMon.Text = tim.TenMon.ToString();
                        txtGiaMon.Text = tim.Gia.ToString();
                        cmbDanhMuc.Text = tim.DanhMuc.TenDanhMuc.ToString();
                        return;
                    }
                }
            }
        }
        private bool KiemTraTTMon()
        {
            if (String.IsNullOrEmpty(txtIDmon.Text))
            {
                errorCanhBao.SetError(txtIDmon, "*");
                return false;
            }
            if (String.IsNullOrEmpty(txtTenMon.Text))
            {
                errorCanhBao.SetError(txtTenMon, "*");
                return false;
            }
            if (String.IsNullOrEmpty(txtGiaMon.Text))
            {
                errorCanhBao.SetError(txtGiaMon, "*");
                return false;

            }
                return true;
        }
    }
}