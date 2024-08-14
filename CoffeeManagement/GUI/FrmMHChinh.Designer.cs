namespace CoffeeManagement.GUI
{
    partial class FrmMHChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMHChinh));
            this.lableThang = new System.Windows.Forms.Label();
            this.LabDateY = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelVIP = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnCaiDat = new System.Windows.Forms.Button();
            this.btnOutMHC = new System.Windows.Forms.Button();
            this.panelVIP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lableThang
            // 
            this.lableThang.AutoSize = true;
            this.lableThang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lableThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableThang.Location = new System.Drawing.Point(213, 699);
            this.lableThang.Name = "lableThang";
            this.lableThang.Size = new System.Drawing.Size(84, 29);
            this.lableThang.TabIndex = 15;
            this.lableThang.Text = "Month";
            this.lableThang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabDateY
            // 
            this.LabDateY.AutoSize = true;
            this.LabDateY.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabDateY.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LabDateY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDateY.Location = new System.Drawing.Point(214, 730);
            this.LabDateY.Name = "LabDateY";
            this.LabDateY.Size = new System.Drawing.Size(48, 24);
            this.LabDateY.TabIndex = 16;
            this.LabDateY.Text = "Date";
            this.LabDateY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(-3, 703);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(134, 55);
            this.labelTime.TabIndex = 19;
            this.labelTime.Text = "Time";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panelVIP
            // 
            this.panelVIP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelVIP.Controls.Add(this.button3);
            this.panelVIP.Controls.Add(this.pictureBox2);
            this.panelVIP.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.panelVIP.Location = new System.Drawing.Point(-6, 0);
            this.panelVIP.Name = "panelVIP";
            this.panelVIP.Size = new System.Drawing.Size(1266, 623);
            this.panelVIP.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SandyBrown;
            this.button3.Image = global::CoffeeManagement.Properties.Resources.exitt;
            this.button3.Location = new System.Drawing.Point(1093, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 129);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.HideMH_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1260, 129);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHoaDon.Image = global::CoffeeManagement.Properties.Resources.note;
            this.btnHoaDon.Location = new System.Drawing.Point(938, 620);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(161, 143);
            this.btnHoaDon.TabIndex = 21;
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCaiDat.Image = global::CoffeeManagement.Properties.Resources.setting;
            this.btnCaiDat.Location = new System.Drawing.Point(1096, 620);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(161, 143);
            this.btnCaiDat.TabIndex = 20;
            this.btnCaiDat.UseVisualStyleBackColor = true;
            this.btnCaiDat.Click += new System.EventHandler(this.btnCaiDat_Click);
            // 
            // btnOutMHC
            // 
            this.btnOutMHC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOutMHC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOutMHC.FlatAppearance.BorderSize = 0;
            this.btnOutMHC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutMHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutMHC.Image = global::CoffeeManagement.Properties.Resources.power_on;
            this.btnOutMHC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOutMHC.Location = new System.Drawing.Point(27, 629);
            this.btnOutMHC.Name = "btnOutMHC";
            this.btnOutMHC.Size = new System.Drawing.Size(189, 71);
            this.btnOutMHC.TabIndex = 19;
            this.btnOutMHC.Text = "user";
            this.btnOutMHC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOutMHC.UseVisualStyleBackColor = false;
            this.btnOutMHC.Click += new System.EventHandler(this.outForm_Click);
            // 
            // FrmMHChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1254, 757);
            this.ControlBox = false;
            this.Controls.Add(this.btnOutMHC);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.btnCaiDat);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.lableThang);
            this.Controls.Add(this.LabDateY);
            this.Controls.Add(this.panelVIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMHChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMHChinh";
            this.Load += new System.EventHandler(this.FrmMHChinh_Load);
            this.panelVIP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lableThang;
        private System.Windows.Forms.Label LabDateY;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelVIP;
        private System.Windows.Forms.Button btnCaiDat;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnOutMHC;
    }
}