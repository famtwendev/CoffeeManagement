namespace CoffeeManagement.GUI
{
    partial class FrmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKe));
            this.panelBaoCao = new System.Windows.Forms.Panel();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnGiaohang = new System.Windows.Forms.Button();
            this.btnMangve = new System.Windows.Forms.Button();
            this.btnTaiquan = new System.Windows.Forms.Button();
            this.btnTatca = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBaoCao
            // 
            this.panelBaoCao.AutoScroll = true;
            this.panelBaoCao.Location = new System.Drawing.Point(-3, 176);
            this.panelBaoCao.Name = "panelBaoCao";
            this.panelBaoCao.Size = new System.Drawing.Size(1257, 580);
            this.panelBaoCao.TabIndex = 32;
            // 
            // btnDown
            // 
            this.btnDown.Image = global::CoffeeManagement.Properties.Resources.down;
            this.btnDown.Location = new System.Drawing.Point(410, 124);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(179, 44);
            this.btnDown.TabIndex = 34;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Image = global::CoffeeManagement.Properties.Resources.up;
            this.btnUp.Location = new System.Drawing.Point(218, 123);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(186, 47);
            this.btnUp.TabIndex = 33;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::CoffeeManagement.Properties.Resources.remove;
            this.btnThoat.Location = new System.Drawing.Point(-3, 123);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(215, 47);
            this.btnThoat.TabIndex = 29;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnGiaohang
            // 
            this.btnGiaohang.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGiaohang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaohang.Image = global::CoffeeManagement.Properties.Resources.deliveryhd1;
            this.btnGiaohang.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGiaohang.Location = new System.Drawing.Point(1122, -1);
            this.btnGiaohang.Name = "btnGiaohang";
            this.btnGiaohang.Size = new System.Drawing.Size(132, 118);
            this.btnGiaohang.TabIndex = 25;
            this.btnGiaohang.Text = "Giao hàng";
            this.btnGiaohang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGiaohang.UseVisualStyleBackColor = false;
            this.btnGiaohang.Click += new System.EventHandler(this.btnGiaohang_Click);
            // 
            // btnMangve
            // 
            this.btnMangve.BackColor = System.Drawing.Color.Khaki;
            this.btnMangve.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangve.Image = global::CoffeeManagement.Properties.Resources.takeout_bagass;
            this.btnMangve.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMangve.Location = new System.Drawing.Point(994, -1);
            this.btnMangve.Name = "btnMangve";
            this.btnMangve.Size = new System.Drawing.Size(133, 118);
            this.btnMangve.TabIndex = 24;
            this.btnMangve.Text = "Mang về";
            this.btnMangve.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMangve.UseVisualStyleBackColor = false;
            this.btnMangve.Click += new System.EventHandler(this.btnMangve_Click);
            // 
            // btnTaiquan
            // 
            this.btnTaiquan.BackColor = System.Drawing.Color.Aqua;
            this.btnTaiquan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiquan.Image = global::CoffeeManagement.Properties.Resources.hereas1;
            this.btnTaiquan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTaiquan.Location = new System.Drawing.Point(865, -1);
            this.btnTaiquan.Name = "btnTaiquan";
            this.btnTaiquan.Size = new System.Drawing.Size(132, 118);
            this.btnTaiquan.TabIndex = 23;
            this.btnTaiquan.Text = "Tại quán";
            this.btnTaiquan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTaiquan.UseVisualStyleBackColor = false;
            this.btnTaiquan.Click += new System.EventHandler(this.btnTaiquan_Click);
            // 
            // btnTatca
            // 
            this.btnTatca.BackColor = System.Drawing.Color.LightGray;
            this.btnTatca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatca.Image = global::CoffeeManagement.Properties.Resources.note;
            this.btnTatca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTatca.Location = new System.Drawing.Point(738, -1);
            this.btnTatca.Name = "btnTatca";
            this.btnTatca.Size = new System.Drawing.Size(132, 118);
            this.btnTatca.TabIndex = 22;
            this.btnTatca.Text = "Tất cả";
            this.btnTatca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTatca.UseVisualStyleBackColor = false;
            this.btnTatca.Click += new System.EventHandler(this.btnTatca_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(742, 118);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1254, 757);
            this.ControlBox = false;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panelBaoCao);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnGiaohang);
            this.Controls.Add(this.btnMangve);
            this.Controls.Add(this.btnTaiquan);
            this.Controls.Add(this.btnTatca);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmThongKe";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnTatca;
        private System.Windows.Forms.Button btnTaiquan;
        private System.Windows.Forms.Button btnMangve;
        private System.Windows.Forms.Button btnGiaohang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panelBaoCao;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
    }
}