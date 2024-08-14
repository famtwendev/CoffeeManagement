using CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace CoffeeManagement.GUI
{
    public partial class FrmQuanLyHoaDon : Form
    {
        private int mahoadon;
        public bool abc = false;
        public FrmQuanLyHoaDon()
        {
            InitializeComponent();
        }
        public FrmQuanLyHoaDon(int mahoadonn)
        {
            this.mahoadon = mahoadonn;
            InitializeComponent();
        }
        private void LoadChiTiet(int Idhoadon)
        {
            using (var db = new QuanLyCaPheModels())
            {
                foreach (var bill in db.ChiTietBills.ToList())
                {
                    if (bill.IdHoaDon == Idhoadon)
                    {
                        Mon mon = db.Mons.FirstOrDefault(c => c.IdMon == bill.IdMon);
                        if (mon != null)
                        {
                            int index = dataHoaDon.Rows.Add();
                            dataHoaDon.Rows[index].Cells["colTenSP"].Value = mon.TenMon;
                            dataHoaDon.Rows[index].Cells["colDonGia"].Value = mon.Gia;
                            dataHoaDon.Rows[index].Cells["colSoLuong"].Value = bill.SoLuong;
                            dataHoaDon.Rows[index].Cells["colThanhTien"].Value = mon.Gia * bill.SoLuong;
                        }
                    }
                }
            }
        }
        private void LoadHoaDon(int mahoadon)
        {
            using (var db = new QuanLyCaPheModels())
            {
                HoaDon hoadonco = db.HoaDons.FirstOrDefault(c => c.IdHoaDon == mahoadon);
                if (hoadonco != null)
                {
                    labstatus.Text = hoadonco.Status;
                    labTime.Text = hoadonco.ThoiGian.ToString();
                    labTongCong.Text = string.Format("Tổng cộng                      {0}", hoadonco.TongTien.ToString());
                    labGiamgia.Text = string.Format("Giảm giá                                   {0}", (hoadonco.TongTien - hoadonco.ThanhToan).ToString());
                    labThanhtien.Text = string.Format("Thành tiền        {0}", hoadonco.ThanhToan.ToString());
                    LoadChiTiet(hoadonco.IdHoaDon);
                }
            }

        }
        private void FrmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDon(mahoadon);
        }

        private void btnAnHoaDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa Hóa đơn này khỏi danh sách", "Xác nhận xóa", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                using (QuanLyCaPheModels db = new QuanLyCaPheModels())
                {
                    HoaDon tam = db.HoaDons.FirstOrDefault(c => c.IdHoaDon == mahoadon);
                    if (tam != null)
                    {
                        var matchingChiTietBills = db.ChiTietBills.Where(c => c.IdHoaDon == mahoadon).ToList();
                        if (matchingChiTietBills.Count > 0)
                        {

                            foreach (var tim in matchingChiTietBills)
                            {
                                db.ChiTietBills.Remove(tim);
                            }
                            db.SaveChanges();


                        }
                        db.HoaDons.Remove(tam);
                        db.SaveChanges();
                        abc = true;
                        this.Close();
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (QuanLyCaPheModels db = new QuanLyCaPheModels())
            {
                HoaDon tam = db.HoaDons.FirstOrDefault(c => c.IdHoaDon == mahoadon);
                if (tam != null)
                {
                    try
                    {
                        Excel.Application exApp = new Excel.Application();
                        exApp.Visible = true;
                        Excel.Workbook exBook = exApp.Workbooks.Add();
                        Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
                        Excel.Range titleCell = exSheet.Range["D2"];
                        titleCell.Font.Size = 20;
                        titleCell.Font.Bold = true;
                        titleCell.Font.Color = Excel.XlRgbColor.rgbRed;
                        titleCell.Value = string.Format("Hoá đơn bán hàng  -  Mã số: {0}",tam.IdHoaDon);
                        Excel.Range headerRange = exSheet.Range["B3:K3"];
                        headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                        headerRange.ColumnWidth = 15;
                        int row = 3;
                        exSheet.Cells[row, 2] = "Tên Sản Phẩm";
                        exSheet.Cells[row, 3] = "Đơn Giá";
                        exSheet.Cells[row, 4] = "Số Lượng";
                        exSheet.Cells[row, 5] = "Thành Tiền";
                        int dong = 4;
                        for (int i = 0; i < dataHoaDon.Rows.Count; i++)
                        {                          
                            exSheet.Cells[dong, 2] = dataHoaDon.Rows[i].Cells["colTenSP"].Value.ToString();
                            exSheet.Cells[dong, 3] = dataHoaDon.Rows[i].Cells["colDonGia"].Value.ToString();
                            exSheet.Cells[dong, 4] = dataHoaDon.Rows[i].Cells["colSoluong"].Value.ToString();
                            exSheet.Cells[dong, 5] = dataHoaDon.Rows[i].Cells["colThanhTien"].Value.ToString();
                            Excel.Range dataRange = exSheet.Range["B" + dong + ":K" + dong];
                            dataRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                            dong++;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Không tra được mã hóa đơn");
                    return;
                }
            }
        }
    }
}
