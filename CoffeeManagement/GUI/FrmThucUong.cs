using CoffeeManagement.Models;
using CoffeeManagement.Properties;
using CoffeeManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CoffeeManagement.GUI
{
    public partial class FrmThucUong : Form
    {
        private Timer timer = new Timer();
        private string status = null;
        private Button banDangChon = null;
        private Account account1 = null;
        List<PhieuDatBan> danhsachphieudatban = new List<PhieuDatBan>();
        public FrmThucUong()
        {
            InitializeComponent();
        }
        public FrmThucUong(Account accounta, Button bandachon, string status)
        {
            this.account1 = accounta;
            this.banDangChon = bandachon;
            this.status = status;
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

        private void FrmThucUong_Load(object sender, EventArgs e)
        {
            tbuser.Text = account1.DisplayName;
            if (status == "Mang Về")
            {
                picBox.Image = Image.FromFile("../../Resources/mangve.png");
            }
            else if (status == "Tại Quán")
            {
                picBox.Image = Image.FromFile("../../Resources/taiquan.png");
            }
            else if (status == "Giao Hàng")
            {
                picBox.Image = Image.FromFile("../../Resources/giaohang.png");
            }
            Ban.Text = string.Format("Bàn {0}",banDangChon.Text);
            LoadDanMucCaPhe();
            LoadDanMucDaxay();
            LoadDanhMucTra();
            LoadDanhMucBanh();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //-------------------------------------- CÀ PHÊ --------------------------------------------------

        private void LoadDanMucCaPhe()
        {
            int x = 35, y = 15, count = 1; //toa do x va y
            using (var dbcontext = new QuanLyCaPheModels())
            {
                var danhMucId = 1; // Điều kiện IdDanhMuc = 1
                var mons = dbcontext.Mons.Where(mon => mon.IdDanhMuc == danhMucId).ToList();
                foreach (var moncf in mons)
                {
                    Caphe(moncf, x, y);
                    if (count++ % 4 == 0)
                    {
                        x = 35;
                        y += 170;
                        continue;
                    }
                    x += 180;
                }
            }
        }
        private void Caphe(Mon cf, int x, int y)
        {
            Button btn = new Button();
            btn.Location = new Point(x, y);
            btn.Size = new Size(141, 129);
            btn.Text = cf.TenMon;
            btn.Tag = cf.IdMon;
            btn.BackColor = Color.Lavender;
            btn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
            tabCaphe.Controls.Add(btn);
            btn.Click += btn_Click;
        }


        //-------------------------------------- ĐÁ XAY --------------------------------------------------
        private void LoadDanMucDaxay()
        {
            int x = 35, y = 15, count = 1; //toa do x va y
            using (var dbcontext = new QuanLyCaPheModels())
            {
                var danhMucId = 2; // Điều kiện IdDanhMuc = 1
                var mons = dbcontext.Mons.Where(mon => mon.IdDanhMuc == danhMucId).ToList();
                foreach (var mondx in mons)
                {
                    Daxay(mondx, x, y); // CHỈNH ĐÁ XAY
                    if (count++ % 4 == 0)
                    {
                        x = 35;
                        y += 170;
                        continue;
                    }
                    x += 180;
                }
            }
        }
        private void Daxay(Mon dx, int x, int y)
        {
            Button btn = new Button();
            btn.Location = new Point(x, y);
            btn.Size = new Size(141, 129);
            btn.Text = dx.TenMon;
            btn.Tag = dx.IdMon;
            btn.BackColor = Color.Lavender;
            btn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
            tabDaxay.Controls.Add(btn);
            btn.Click += btn_Click;
        }
        //-------------------------------------- TRÀ  --------------------------------------------------
        private void LoadDanhMucTra()
        {
            int x = 35, y = 15, count = 1; //toa do x va y
            using (var dbcontext = new QuanLyCaPheModels())
            {
                var danhMucId = 3; // Điều kiện IdDanhMuc = 1
                var mons = dbcontext.Mons.Where(mon => mon.IdDanhMuc == danhMucId).ToList();
                foreach (var montra in mons)
                {
                    Tra(montra, x, y); // CHỈNH ĐÁ XAY
                    if (count++ % 4 == 0)
                    {
                        x = 35;
                        y += 170;
                        continue;
                    }
                    x += 180;
                }
            }
        }
        private void Tra(Mon tra, int x, int y)
        {
            Button btn = new Button();
            btn.Location = new Point(x, y);
            btn.Size = new Size(141, 129);
            btn.Text = tra.TenMon;
            btn.Tag = tra.IdMon;
            btn.BackColor = Color.Lavender;
            btn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
            tabTra.Controls.Add(btn);
            btn.Click += btn_Click;
        }

        //-------------------------------------- Bánh Ngọt  --------------------------------------------------
        private void LoadDanhMucBanh()
        {
            int x = 35, y = 15, count = 1; //toa do x va y
            using (var dbcontext = new QuanLyCaPheModels())
            {
                var danhMucId = 4; // Điều kiện IdDanhMuc = 1
                var mons = dbcontext.Mons.Where(mon => mon.IdDanhMuc == danhMucId).ToList();
                foreach (var banh in mons)
                {
                    BanhNgot(banh, x, y); // CHỈNH ĐÁ XAY
                    if (count++ % 4 == 0)
                    {
                        x = 35;
                        y += 170;
                        continue;
                    }
                    x += 180;
                }
            }
        }
        private void BanhNgot(Mon banh, int x, int y)
        {
            Button btn = new Button();
            btn.Location = new Point(x, y);
            btn.Size = new Size(141, 129);
            btn.Text = banh.TenMon;
            btn.Tag = banh.IdMon;
            btn.BackColor = Color.Lavender;
            btn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
            tabBanhNgot.Controls.Add(btn);
            btn.Click += btn_Click;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //Xac dinh ban dang duoc dat
            int maban = int.Parse(banDangChon.Tag.ToString());
            //Kiem tra phieu dat ban da ton tai hay chua?
            PhieuDatBan phieu = danhsachphieudatban.FirstOrDefault(c => c.Maban == maban);
            if (phieu == null)
            {
                phieu = new PhieuDatBan();
                phieu.Maban = maban;
                danhsachphieudatban.Add(phieu);
            }
            Button button = sender as Button;
            using (QuanLyCaPheModels db = new QuanLyCaPheModels())
            {
                Mon ann = db.Mons.FirstOrDefault(c => c.IdMon == (int)button.Tag);
                MonDat mondat = phieu.Danhsachmon.FirstOrDefault(m => m.MaMon == ann.IdMon);
                if (mondat != null)
                {
                    // Món đã tồn tại, tăng số lượng lên 1
                    mondat.SoLuong += 1;
                    phieu.Goimon(mondat);
                }
                else
                {
                    // Món chưa tồn tại, thêm món mới vào danh sách
                    MonDat newMonDat = new MonDat()
                    {
                        MaMon = ann.IdMon,
                        TenMon = ann.TenMon,
                        Gia = ann.Gia,
                        SoLuong = 1
                    };
                    phieu.Goimon(newMonDat);
                }
                //                phieu.Goimon(mondat);
                HienThiDanhSachMon(phieu.Danhsachmon);
                txtTongMon.Text = phieu.TongSoMon.ToString();
                txtThanhTien.Text = phieu.TongTienHoaDon.ToString();
            }
        }
        private void HienThiDanhSachMon(List<MonDat> danhsachmon)
        {
            dataGridViewDS.Rows.Clear();
            foreach (var item in danhsachmon)
            {
                int index = dataGridViewDS.Rows.Add();
                dataGridViewDS.Rows[index].Cells[0].Value = item.SoLuong;
                dataGridViewDS.Rows[index].Cells[1].Value = item.MaMon;
                dataGridViewDS.Rows[index].Cells[2].Value = item.TenMon;
                dataGridViewDS.Rows[index].Cells[3].Value = item.Gia;
                dataGridViewDS.Rows[index].Cells[4].Value = item.ThanhTien;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            Random random = new Random(DateTime.Now.Millisecond);
            // Tạo số ngẫu nhiên
            int maBan = int.Parse(banDangChon.Tag.ToString());
            PhieuDatBan phieu = danhsachphieudatban.FirstOrDefault(x => x.Maban == maBan);
            if (phieu == null)
            {
                MessageBox.Show("Vui lòng đặt món trước khi thanh toán!");
                return;
            }
            this.Hide();
            FrmThanhToan frmThanhToan = new FrmThanhToan(account1, status,phieu.TongTienHoaDon);
            frmThanhToan.ShowDialog();
            this.Show();
            if(frmThanhToan.chonlua == 1)
            {
                HoaDon hd = new HoaDon();
                hd.IdHoaDon = random.Next(1, 101);
                hd.ThoiGian = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                hd.IdBan = maBan;
                hd.Status = status;
                hd.TongTien = phieu.TongTienHoaDon;
                hd.ThanhToan = frmThanhToan.thanhtien;
                //them chi tiet vao hoa don
                ChiTietBill ct;
                foreach (var item in phieu.Danhsachmon)
                {
                    ct = new ChiTietBill();
                    ct.IdMon = item.MaMon;
                    ct.SoLuong = item.SoLuong;
                    hd.ChiTietBills.Add(ct);
                }
                try
                {
                    using (var dbcontext = new QuanLyCaPheModels())
                    {
                        dbcontext.HoaDons.Add(hd);
                        dbcontext.SaveChanges();
                    }
                    danhsachphieudatban.Remove(phieu);
                    txtThanhTien.Text = String.Empty;
                    banDangChon.Image = null;
                    dataGridViewDS.Rows.Clear();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }               
        }
        private void dataGridViewDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int maban = int.Parse(banDangChon.Tag.ToString());
            PhieuDatBan phieu = danhsachphieudatban.FirstOrDefault(c => c.Maban == maban);
            if (e.RowIndex >= 0) // Kisểm tra nếu người dùng đã chọn một dòng (loại trừ tiêu đề)
            {
                int selectedRow = e.RowIndex;
                DialogResult result = MessageBox.Show("Bạn muốn loại bỏ món này?", "Xác nhận", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    int choice = e.RowIndex;
                    int mamon = int.Parse(dataGridViewDS.Rows[choice].Cells[1].Value.ToString());
                    phieu.XoaMon(mamon);
                    HienThiDanhSachMon(phieu.Danhsachmon);
                    txtTongMon.Text = phieu.TongSoMon.ToString();
                    txtThanhTien.Text = phieu.TongTienHoaDon.ToString();
                }
            }
        }
    }
}
