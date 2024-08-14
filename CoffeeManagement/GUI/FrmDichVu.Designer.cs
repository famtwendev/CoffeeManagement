namespace CoffeeManagement.GUI
{
    partial class FrmDichVu
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
            this.btnTaiQuan = new System.Windows.Forms.Button();
            this.btnMangVe = new System.Windows.Forms.Button();
            this.btnGiaoHang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTaiQuan
            // 
            this.btnTaiQuan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTaiQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiQuan.Image = global::CoffeeManagement.Properties.Resources.here1;
            this.btnTaiQuan.Location = new System.Drawing.Point(551, 44);
            this.btnTaiQuan.Name = "btnTaiQuan";
            this.btnTaiQuan.Size = new System.Drawing.Size(224, 265);
            this.btnTaiQuan.TabIndex = 4;
            this.btnTaiQuan.Text = "Tại Quán";
            this.btnTaiQuan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTaiQuan.UseVisualStyleBackColor = true;
            this.btnTaiQuan.Click += new System.EventHandler(this.btnTaiQuan_Click);
            // 
            // btnMangVe
            // 
            this.btnMangVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMangVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMangVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangVe.Image = global::CoffeeManagement.Properties.Resources.takeout_bag1;
            this.btnMangVe.Location = new System.Drawing.Point(293, 44);
            this.btnMangVe.Name = "btnMangVe";
            this.btnMangVe.Size = new System.Drawing.Size(224, 265);
            this.btnMangVe.TabIndex = 3;
            this.btnMangVe.Text = "Mang Về";
            this.btnMangVe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMangVe.UseVisualStyleBackColor = true;
            this.btnMangVe.Click += new System.EventHandler(this.btnMangVe_Click);
            // 
            // btnGiaoHang
            // 
            this.btnGiaoHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGiaoHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaoHang.Image = global::CoffeeManagement.Properties.Resources.delivery;
            this.btnGiaoHang.Location = new System.Drawing.Point(35, 44);
            this.btnGiaoHang.Name = "btnGiaoHang";
            this.btnGiaoHang.Size = new System.Drawing.Size(224, 265);
            this.btnGiaoHang.TabIndex = 2;
            this.btnGiaoHang.Text = "Giao Hàng";
            this.btnGiaoHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGiaoHang.UseVisualStyleBackColor = true;
            this.btnGiaoHang.Click += new System.EventHandler(this.btnGiaoHang_Click);
            // 
            // FrmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(810, 352);
            this.ControlBox = false;
            this.Controls.Add(this.btnTaiQuan);
            this.Controls.Add(this.btnMangVe);
            this.Controls.Add(this.btnGiaoHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDichVu";
            this.Load += new System.EventHandler(this.FrmDichVu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGiaoHang;
        private System.Windows.Forms.Button btnMangVe;
        private System.Windows.Forms.Button btnTaiQuan;
    }
}