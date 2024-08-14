namespace CoffeeManagement.GUI
{
    partial class FrmThucUong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThucUong));
            this.labelTime = new System.Windows.Forms.Label();
            this.lableThang = new System.Windows.Forms.Label();
            this.LabDateY = new System.Windows.Forms.Label();
            this.tbuser = new System.Windows.Forms.Label();
            this.tabSanPham = new System.Windows.Forms.TabControl();
            this.tabCaphe = new System.Windows.Forms.TabPage();
            this.tabDaxay = new System.Windows.Forms.TabPage();
            this.tabTra = new System.Windows.Forms.TabPage();
            this.tabBanhNgot = new System.Windows.Forms.TabPage();
            this.dataGridViewDS = new System.Windows.Forms.DataGridView();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTongMon = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTC = new System.Windows.Forms.Label();
            this.Ban = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDS)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(8, 699);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(134, 55);
            this.labelTime.TabIndex = 27;
            this.labelTime.Text = "Time";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lableThang
            // 
            this.lableThang.AutoSize = true;
            this.lableThang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lableThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableThang.Location = new System.Drawing.Point(224, 699);
            this.lableThang.Name = "lableThang";
            this.lableThang.Size = new System.Drawing.Size(84, 29);
            this.lableThang.TabIndex = 24;
            this.lableThang.Text = "Month";
            this.lableThang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabDateY
            // 
            this.LabDateY.AutoSize = true;
            this.LabDateY.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabDateY.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LabDateY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDateY.Location = new System.Drawing.Point(225, 728);
            this.LabDateY.Name = "LabDateY";
            this.LabDateY.Size = new System.Drawing.Size(48, 24);
            this.LabDateY.TabIndex = 25;
            this.LabDateY.Text = "Date";
            this.LabDateY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbuser
            // 
            this.tbuser.AutoSize = true;
            this.tbuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbuser.Location = new System.Drawing.Point(98, 676);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(44, 20);
            this.tbuser.TabIndex = 28;
            this.tbuser.Text = "user";
            // 
            // tabSanPham
            // 
            this.tabSanPham.Controls.Add(this.tabCaphe);
            this.tabSanPham.Controls.Add(this.tabDaxay);
            this.tabSanPham.Controls.Add(this.tabTra);
            this.tabSanPham.Controls.Add(this.tabBanhNgot);
            this.tabSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSanPham.ItemSize = new System.Drawing.Size(190, 58);
            this.tabSanPham.Location = new System.Drawing.Point(1, 94);
            this.tabSanPham.Name = "tabSanPham";
            this.tabSanPham.SelectedIndex = 0;
            this.tabSanPham.Size = new System.Drawing.Size(764, 579);
            this.tabSanPham.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabSanPham.TabIndex = 37;
            // 
            // tabCaphe
            // 
            this.tabCaphe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabCaphe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabCaphe.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tabCaphe.Location = new System.Drawing.Point(4, 62);
            this.tabCaphe.Name = "tabCaphe";
            this.tabCaphe.Padding = new System.Windows.Forms.Padding(3);
            this.tabCaphe.Size = new System.Drawing.Size(756, 513);
            this.tabCaphe.TabIndex = 0;
            this.tabCaphe.Text = "Cà Phê";
            // 
            // tabDaxay
            // 
            this.tabDaxay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabDaxay.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tabDaxay.Location = new System.Drawing.Point(4, 62);
            this.tabDaxay.Name = "tabDaxay";
            this.tabDaxay.Padding = new System.Windows.Forms.Padding(3);
            this.tabDaxay.Size = new System.Drawing.Size(756, 513);
            this.tabDaxay.TabIndex = 1;
            this.tabDaxay.Text = "Đá Xay";
            // 
            // tabTra
            // 
            this.tabTra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabTra.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tabTra.Location = new System.Drawing.Point(4, 62);
            this.tabTra.Name = "tabTra";
            this.tabTra.Padding = new System.Windows.Forms.Padding(3);
            this.tabTra.Size = new System.Drawing.Size(756, 513);
            this.tabTra.TabIndex = 2;
            this.tabTra.Text = "Trà";
            // 
            // tabBanhNgot
            // 
            this.tabBanhNgot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabBanhNgot.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tabBanhNgot.Location = new System.Drawing.Point(4, 62);
            this.tabBanhNgot.Name = "tabBanhNgot";
            this.tabBanhNgot.Padding = new System.Windows.Forms.Padding(3);
            this.tabBanhNgot.Size = new System.Drawing.Size(756, 513);
            this.tabBanhNgot.TabIndex = 3;
            this.tabBanhNgot.Text = "Bánh Ngọt";
            // 
            // dataGridViewDS
            // 
            this.dataGridViewDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewDS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSoLuong,
            this.colIDMon,
            this.colTenMon,
            this.colDonGia,
            this.colThanhTien});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDS.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewDS.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewDS.Location = new System.Drawing.Point(765, 94);
            this.dataGridViewDS.Name = "dataGridViewDS";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDS.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewDS.RowHeadersVisible = false;
            this.dataGridViewDS.RowHeadersWidth = 60;
            this.dataGridViewDS.RowTemplate.Height = 30;
            this.dataGridViewDS.Size = new System.Drawing.Size(486, 524);
            this.dataGridViewDS.TabIndex = 38;
            this.dataGridViewDS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDS_CellClick);
            // 
            // colSoLuong
            // 
            this.colSoLuong.FillWeight = 36.57009F;
            this.colSoLuong.HeaderText = "SL";
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colIDMon
            // 
            this.colIDMon.FillWeight = 37.4049F;
            this.colIDMon.HeaderText = "Mã";
            this.colIDMon.Name = "colIDMon";
            // 
            // colTenMon
            // 
            this.colTenMon.FillWeight = 208.7678F;
            this.colTenMon.HeaderText = "Tên Món";
            this.colTenMon.Name = "colTenMon";
            // 
            // colDonGia
            // 
            this.colDonGia.FillWeight = 98.98478F;
            this.colDonGia.HeaderText = "Đơn Giá";
            this.colDonGia.Name = "colDonGia";
            // 
            // colThanhTien
            // 
            this.colThanhTien.FillWeight = 118.2725F;
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.Name = "colThanhTien";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.txtTongMon);
            this.panel1.Controls.Add(this.txtThanhTien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelTC);
            this.panel1.Location = new System.Drawing.Point(767, 611);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 75);
            this.panel1.TabIndex = 39;
            // 
            // txtTongMon
            // 
            this.txtTongMon.AutoSize = true;
            this.txtTongMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongMon.ForeColor = System.Drawing.Color.White;
            this.txtTongMon.Location = new System.Drawing.Point(58, 41);
            this.txtTongMon.Name = "txtTongMon";
            this.txtTongMon.Size = new System.Drawing.Size(30, 31);
            this.txtTongMon.TabIndex = 3;
            this.txtTongMon.Text = "0";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.AutoSize = true;
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.ForeColor = System.Drawing.Color.White;
            this.txtThanhTien.Location = new System.Drawing.Point(330, 41);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(30, 31);
            this.txtThanhTien.TabIndex = 2;
            this.txtThanhTien.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "#    Sản phẩm";
            // 
            // labelTC
            // 
            this.labelTC.AutoSize = true;
            this.labelTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTC.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTC.Location = new System.Drawing.Point(285, 10);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(151, 31);
            this.labelTC.TabIndex = 0;
            this.labelTC.Text = "Tổng cộng";
            // 
            // Ban
            // 
            this.Ban.AutoSize = true;
            this.Ban.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ban.Location = new System.Drawing.Point(958, 29);
            this.Ban.Name = "Ban";
            this.Ban.Size = new System.Drawing.Size(81, 39);
            this.Ban.TabIndex = 43;
            this.Ban.Text = "Bàn";
            // 
            // picBox
            // 
            this.picBox.Image = global::CoffeeManagement.Properties.Resources.giaohang;
            this.picBox.Location = new System.Drawing.Point(864, 7);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(88, 81);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox.TabIndex = 42;
            this.picBox.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.Info;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Image = global::CoffeeManagement.Properties.Resources.close;
            this.btnThoat.Location = new System.Drawing.Point(1080, 693);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(139, 63);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.SystemColors.Info;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Image = global::CoffeeManagement.Properties.Resources.credit_card;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(765, 694);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(280, 62);
            this.btnThanhToan.TabIndex = 21;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, -14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(764, 118);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // FrmThucUong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1254, 757);
            this.ControlBox = false;
            this.Controls.Add(this.Ban);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDS);
            this.Controls.Add(this.tabSanPham);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.lableThang);
            this.Controls.Add(this.LabDateY);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FrmThucUong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmThucUong";
            this.Load += new System.EventHandler(this.FrmThucUong_Load);
            this.tabSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label lableThang;
        private System.Windows.Forms.Label LabDateY;
        private System.Windows.Forms.Label tbuser;
        private System.Windows.Forms.TabControl tabSanPham;
        private System.Windows.Forms.TabPage tabCaphe;
        private System.Windows.Forms.TabPage tabDaxay;
        private System.Windows.Forms.TabPage tabTra;
        private System.Windows.Forms.TabPage tabBanhNgot;
        private System.Windows.Forms.DataGridView dataGridViewDS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTC;
        private System.Windows.Forms.Label txtTongMon;
        private System.Windows.Forms.Label txtThanhTien;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label Ban;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    }
}