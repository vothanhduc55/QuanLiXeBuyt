namespace dangNhap
{
    partial class trangChu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trangChu));
            this.bnt_danhThu = new System.Windows.Forms.Button();
            this.bnt_timKiemTaiXe = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bnt_ThongTinTuyen = new System.Windows.Forms.Button();
            this.bntDangXuat = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bnt_danhThu
            // 
            this.bnt_danhThu.Location = new System.Drawing.Point(37, 12);
            this.bnt_danhThu.Name = "bnt_danhThu";
            this.bnt_danhThu.Size = new System.Drawing.Size(105, 68);
            this.bnt_danhThu.TabIndex = 0;
            this.bnt_danhThu.Text = "Cập nhập thông tin tài xế";
            this.bnt_danhThu.UseVisualStyleBackColor = true;
            this.bnt_danhThu.Click += new System.EventHandler(this.button1_Click);
            // 
            // bnt_timKiemTaiXe
            // 
            this.bnt_timKiemTaiXe.Location = new System.Drawing.Point(196, 12);
            this.bnt_timKiemTaiXe.Name = "bnt_timKiemTaiXe";
            this.bnt_timKiemTaiXe.Size = new System.Drawing.Size(102, 68);
            this.bnt_timKiemTaiXe.TabIndex = 1;
            this.bnt_timKiemTaiXe.Text = "Tìm kiếm thông tin tài xế";
            this.bnt_timKiemTaiXe.UseVisualStyleBackColor = true;
            this.bnt_timKiemTaiXe.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(362, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 68);
            this.button3.TabIndex = 2;
            this.button3.Text = "Quản lý thông tin bán vé ngày";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bnt_ThongTinTuyen
            // 
            this.bnt_ThongTinTuyen.Location = new System.Drawing.Point(530, 12);
            this.bnt_ThongTinTuyen.Name = "bnt_ThongTinTuyen";
            this.bnt_ThongTinTuyen.Size = new System.Drawing.Size(96, 68);
            this.bnt_ThongTinTuyen.TabIndex = 3;
            this.bnt_ThongTinTuyen.Text = "quản lý thông tin tuyến xe buýt";
            this.bnt_ThongTinTuyen.UseVisualStyleBackColor = true;
            this.bnt_ThongTinTuyen.Click += new System.EventHandler(this.button4_Click);
            // 
            // bntDangXuat
            // 
            this.bntDangXuat.Location = new System.Drawing.Point(573, 268);
            this.bntDangXuat.Name = "bntDangXuat";
            this.bntDangXuat.Size = new System.Drawing.Size(89, 41);
            this.bntDangXuat.TabIndex = 4;
            this.bntDangXuat.Text = "Đăng xuất";
            this.bntDangXuat.UseVisualStyleBackColor = true;
            this.bntDangXuat.Click += new System.EventHandler(this.bntDangXuat_Click);
            // 
            // trangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 321);
            this.Controls.Add(this.bntDangXuat);
            this.Controls.Add(this.bnt_ThongTinTuyen);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bnt_timKiemTaiXe);
            this.Controls.Add(this.bnt_danhThu);
            this.Name = "trangChu";
            this.Text = "Chuong trinh quan ly he thong xe buyt";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button bnt_danhThu;
        private System.Windows.Forms.Button bnt_timKiemTaiXe;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bnt_ThongTinTuyen;
        private System.Windows.Forms.Button bntDangXuat;
    }
}