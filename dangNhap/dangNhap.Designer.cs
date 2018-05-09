namespace dangNhap
{
    partial class dangNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_huyBo = new System.Windows.Forms.Button();
            this.btn_dangNhap = new System.Windows.Forms.Button();
            this.txt_matKhau = new System.Windows.Forms.TextBox();
            this.txt_tenDN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_huyBo);
            this.panel1.Controls.Add(this.btn_dangNhap);
            this.panel1.Controls.Add(this.txt_matKhau);
            this.panel1.Controls.Add(this.txt_tenDN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(103, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 273);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(131, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // btn_huyBo
            // 
            this.btn_huyBo.Location = new System.Drawing.Point(207, 193);
            this.btn_huyBo.Name = "btn_huyBo";
            this.btn_huyBo.Size = new System.Drawing.Size(75, 23);
            this.btn_huyBo.TabIndex = 8;
            this.btn_huyBo.Text = "Hủy bỏ";
            this.btn_huyBo.UseVisualStyleBackColor = true;
            this.btn_huyBo.Click += new System.EventHandler(this.btn_huyBo_Click);
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.Location = new System.Drawing.Point(90, 193);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(75, 23);
            this.btn_dangNhap.TabIndex = 7;
            this.btn_dangNhap.Text = "Đăng nhập";
            this.btn_dangNhap.UseVisualStyleBackColor = true;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.Location = new System.Drawing.Point(134, 129);
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.Size = new System.Drawing.Size(148, 20);
            this.txt_matKhau.TabIndex = 6;
            this.txt_matKhau.UseSystemPasswordChar = true;
            // 
            // txt_tenDN
            // 
            this.txt_tenDN.Location = new System.Drawing.Point(134, 89);
            this.txt_tenDN.Name = "txt_tenDN";
            this.txt_tenDN.Size = new System.Drawing.Size(148, 20);
            this.txt_tenDN.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên đăng nhâp :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // dangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 329);
            this.Controls.Add(this.panel1);
            this.Name = "dangNhap";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_huyBo;
        private System.Windows.Forms.Button btn_dangNhap;
        private System.Windows.Forms.TextBox txt_matKhau;
        private System.Windows.Forms.TextBox txt_tenDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

