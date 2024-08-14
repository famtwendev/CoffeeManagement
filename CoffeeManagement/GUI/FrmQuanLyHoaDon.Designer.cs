namespace CoffeeManagement.GUI
{
    partial class FrmQuanLyHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labTongCong = new System.Windows.Forms.Label();
            this.labGiamgia = new System.Windows.Forms.Label();
            this.labThanhtien = new System.Windows.Forms.Label();
            this.labstatus = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.dataHoaDon = new System.Windows.Forms.DataGridView();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnHoaDon = new System.Windows.Forms.Button();
            this.btnHuyHoaDon = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // labTongCong
            // 
            this.labTongCong.AutoSize = true;
            this.labTongCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTongCong.ForeColor = System.Drawing.Color.White;
            this.labTongCong.Location = new System.Drawing.Point(305, 517);
            this.labTongCong.Name = "labTongCong";
            this.labTongCong.Size = new System.Drawing.Size(124, 29);
            this.labTongCong.TabIndex = 5;
            this.labTongCong.Text = "Tổng tiền";
            // 
            // labGiamgia
            // 
            this.labGiamgia.AutoSize = true;
            this.labGiamgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGiamgia.ForeColor = System.Drawing.Color.White;
            this.labGiamgia.Location = new System.Drawing.Point(306, 580);
            this.labGiamgia.Name = "labGiamgia";
            this.labGiamgia.Size = new System.Drawing.Size(109, 29);
            this.labGiamgia.TabIndex = 6;
            this.labGiamgia.Text = "Giảm giá";
            // 
            // labThanhtien
            // 
            this.labThanhtien.AutoSize = true;
            this.labThanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labThanhtien.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labThanhtien.Location = new System.Drawing.Point(304, 649);
            this.labThanhtien.Name = "labThanhtien";
            this.labThanhtien.Size = new System.Drawing.Size(205, 42);
            this.labThanhtien.TabIndex = 7;
            this.labThanhtien.Text = "Thành tiền";
            // 
            // labstatus
            // 
            this.labstatus.AutoSize = true;
            this.labstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labstatus.ForeColor = System.Drawing.Color.White;
            this.labstatus.Location = new System.Drawing.Point(130, 20);
            this.labstatus.Name = "labstatus";
            this.labstatus.Size = new System.Drawing.Size(122, 39);
            this.labstatus.TabIndex = 8;
            this.labstatus.Text = "Status";
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTime.ForeColor = System.Drawing.Color.White;
            this.labTime.Location = new System.Drawing.Point(719, 29);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(73, 29);
            this.labTime.TabIndex = 9;
            this.labTime.Text = "Time";
            // 
            // dataHoaDon
            // 
            this.dataHoaDon.AllowUserToResizeColumns = false;
            this.dataHoaDon.AllowUserToResizeRows = false;
            this.dataHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataHoaDon.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenSP,
            this.colDonGia,
            this.colSoluong,
            this.colThanhTien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataHoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataHoaDon.GridColor = System.Drawing.Color.DimGray;
            this.dataHoaDon.Location = new System.Drawing.Point(43, 100);
            this.dataHoaDon.Name = "dataHoaDon";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataHoaDon.RowHeadersVisible = false;
            this.dataHoaDon.RowHeadersWidth = 60;
            this.dataHoaDon.Size = new System.Drawing.Size(1125, 398);
            this.dataHoaDon.TabIndex = 10;
            // 
            // colTenSP
            // 
            this.colTenSP.HeaderText = "Tên Sản Phẩm";
            this.colTenSP.Name = "colTenSP";
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn Giá";
            this.colDonGia.Name = "colDonGia";
            // 
            // colSoluong
            // 
            this.colSoluong.HeaderText = "Số Lượng";
            this.colSoluong.Name = "colSoluong";
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.Name = "colThanhTien";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CoffeeManagement.Properties.Resources.delivery_status;
            this.pictureBox2.Location = new System.Drawing.Point(58, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoffeeManagement.Properties.Resources.clock;
            this.pictureBox1.Location = new System.Drawing.Point(647, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnAnHoaDon
            // 
            this.btnAnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnHoaDon.Image = global::CoffeeManagement.Properties.Resources.remove1;
            this.btnAnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnHoaDon.Location = new System.Drawing.Point(43, 621);
            this.btnAnHoaDon.Name = "btnAnHoaDon";
            this.btnAnHoaDon.Size = new System.Drawing.Size(96, 83);
            this.btnAnHoaDon.TabIndex = 2;
            this.btnAnHoaDon.Text = "Ẩn";
            this.btnAnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnHoaDon.UseVisualStyleBackColor = true;
            this.btnAnHoaDon.Click += new System.EventHandler(this.btnAnHoaDon_Click);
            // 
            // btnHuyHoaDon
            // 
            this.btnHuyHoaDon.BackColor = System.Drawing.Color.White;
            this.btnHuyHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyHoaDon.Image = global::CoffeeManagement.Properties.Resources.close2;
            this.btnHuyHoaDon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuyHoaDon.Location = new System.Drawing.Point(1072, 621);
            this.btnHuyHoaDon.Name = "btnHuyHoaDon";
            this.btnHuyHoaDon.Size = new System.Drawing.Size(96, 83);
            this.btnHuyHoaDon.TabIndex = 1;
            this.btnHuyHoaDon.Text = "Hủy";
            this.btnHuyHoaDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuyHoaDon.UseVisualStyleBackColor = false;
            this.btnHuyHoaDon.Click += new System.EventHandler(this.btnHuyHoaDon_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CoffeeManagement.Properties.Resources.money1;
            this.pictureBox3.Location = new System.Drawing.Point(506, 639);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(788, 621);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(183, 83);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "In Hóa Đơn";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FrmQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1206, 716);
            this.ControlBox = false;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataHoaDon);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.labstatus);
            this.Controls.Add(this.labThanhtien);
            this.Controls.Add(this.labGiamgia);
            this.Controls.Add(this.labTongCong);
            this.Controls.Add(this.btnAnHoaDon);
            this.Controls.Add(this.btnHuyHoaDon);
            this.Name = "FrmQuanLyHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQuanLyHoaDon";
            this.Load += new System.EventHandler(this.FrmQuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuyHoaDon;
        private System.Windows.Forms.Button btnAnHoaDon;
        private System.Windows.Forms.Label labTongCong;
        private System.Windows.Forms.Label labGiamgia;
        private System.Windows.Forms.Label labThanhtien;
        private System.Windows.Forms.Label labstatus;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.DataGridView dataHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnPrint;
    }
}