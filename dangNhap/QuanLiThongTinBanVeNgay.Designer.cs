namespace dangNhap
{
    partial class QuanLiThongTinBanVeNgay
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.MaGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaVeNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VePhatRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VeThuVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VeBanDuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.lbThuVao = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbBanDuoc = new System.Windows.Forms.Label();
            this.lbBanRa = new System.Windows.Forms.Label();
            this.grbThongTinTaiXe = new System.Windows.Forms.GroupBox();
            this.lbTenTX = new System.Windows.Forms.Label();
            this.txttenTX = new System.Windows.Forms.TextBox();
            this.txtMaTX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMaTX = new System.Windows.Forms.Label();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.txtMaGD = new System.Windows.Forms.TextBox();
            this.lbNgay = new System.Windows.Forms.Label();
            this.lbMaGD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpThongTinVeNgay = new System.Windows.Forms.GroupBox();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.txtMaVeNgay = new System.Windows.Forms.TextBox();
            this.lbDG = new System.Windows.Forms.Label();
            this.lbMaVeNgay = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtThuVao = new System.Windows.Forms.TextBox();
            this.txtBanDuoc = new System.Windows.Forms.TextBox();
            this.txtBanRa = new System.Windows.Forms.TextBox();
            this.btnKiemTra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.grbThongTinTaiXe.SuspendLayout();
            this.grpThongTinVeNgay.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(644, 469);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 43;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGD,
            this.Ngay,
            this.MaTX,
            this.TenTX,
            this.MaVeNgay,
            this.DG,
            this.VePhatRa,
            this.VeThuVao,
            this.VeBanDuoc,
            this.ThanhTien});
            this.dgvDanhSach.Location = new System.Drawing.Point(12, 291);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.Size = new System.Drawing.Size(740, 150);
            this.dgvDanhSach.TabIndex = 38;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
            // 
            // MaGD
            // 
            this.MaGD.DataPropertyName = "MaGD";
            this.MaGD.HeaderText = "Mã GD";
            this.MaGD.Name = "MaGD";
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "ngay";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            // 
            // MaTX
            // 
            this.MaTX.DataPropertyName = "MaTX";
            this.MaTX.HeaderText = "Mã TX";
            this.MaTX.Name = "MaTX";
            // 
            // TenTX
            // 
            this.TenTX.DataPropertyName = "TenTX";
            this.TenTX.HeaderText = "Tên TX";
            this.TenTX.Name = "TenTX";
            // 
            // MaVeNgay
            // 
            this.MaVeNgay.DataPropertyName = "MaVeNgay";
            this.MaVeNgay.HeaderText = "Mã vé ngày";
            this.MaVeNgay.Name = "MaVeNgay";
            // 
            // DG
            // 
            this.DG.DataPropertyName = "DG";
            this.DG.HeaderText = "DG";
            this.DG.Name = "DG";
            // 
            // VePhatRa
            // 
            this.VePhatRa.DataPropertyName = "VePhatRa";
            this.VePhatRa.HeaderText = "Phát ra";
            this.VePhatRa.Name = "VePhatRa";
            // 
            // VeThuVao
            // 
            this.VeThuVao.DataPropertyName = "VeThuVao";
            this.VeThuVao.HeaderText = "ThuVao";
            this.VeThuVao.Name = "VeThuVao";
            // 
            // VeBanDuoc
            // 
            this.VeBanDuoc.DataPropertyName = "VeBanDuoc";
            this.VeBanDuoc.HeaderText = "Bán Được";
            this.VeBanDuoc.Name = "VeBanDuoc";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Location = new System.Drawing.Point(430, 265);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(62, 13);
            this.lbThanhTien.TabIndex = 37;
            this.lbThanhTien.Text = "Thành Tiền";
            // 
            // lbThuVao
            // 
            this.lbThuVao.AutoSize = true;
            this.lbThuVao.Location = new System.Drawing.Point(430, 230);
            this.lbThuVao.Name = "lbThuVao";
            this.lbThuVao.Size = new System.Drawing.Size(74, 13);
            this.lbThuVao.TabIndex = 36;
            this.lbThuVao.Text = "Số vé thu vào";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(636, 265);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 21);
            this.btnTinh.TabIndex = 44;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(474, 469);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 42;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(308, 469);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 41;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(168, 469);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 40;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(14, 469);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbBanDuoc
            // 
            this.lbBanDuoc.AutoSize = true;
            this.lbBanDuoc.Location = new System.Drawing.Point(87, 261);
            this.lbBanDuoc.Name = "lbBanDuoc";
            this.lbBanDuoc.Size = new System.Drawing.Size(84, 13);
            this.lbBanDuoc.TabIndex = 35;
            this.lbBanDuoc.Text = "Số vé bán được";
            // 
            // lbBanRa
            // 
            this.lbBanRa.AutoSize = true;
            this.lbBanRa.Location = new System.Drawing.Point(90, 226);
            this.lbBanRa.Name = "lbBanRa";
            this.lbBanRa.Size = new System.Drawing.Size(68, 13);
            this.lbBanRa.TabIndex = 34;
            this.lbBanRa.Text = "Số vé bán ra";
            // 
            // grbThongTinTaiXe
            // 
            this.grbThongTinTaiXe.Controls.Add(this.lbTenTX);
            this.grbThongTinTaiXe.Controls.Add(this.txttenTX);
            this.grbThongTinTaiXe.Controls.Add(this.txtMaTX);
            this.grbThongTinTaiXe.Controls.Add(this.label5);
            this.grbThongTinTaiXe.Controls.Add(this.lbMaTX);
            this.grbThongTinTaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinTaiXe.Location = new System.Drawing.Point(29, 95);
            this.grbThongTinTaiXe.Name = "grbThongTinTaiXe";
            this.grbThongTinTaiXe.Size = new System.Drawing.Size(685, 53);
            this.grbThongTinTaiXe.TabIndex = 28;
            this.grbThongTinTaiXe.TabStop = false;
            this.grbThongTinTaiXe.Text = "Thông tin tài xế";
            // 
            // lbTenTX
            // 
            this.lbTenTX.AutoSize = true;
            this.lbTenTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTX.Location = new System.Drawing.Point(404, 19);
            this.lbTenTX.Name = "lbTenTX";
            this.lbTenTX.Size = new System.Drawing.Size(54, 13);
            this.lbTenTX.TabIndex = 4;
            this.lbTenTX.Text = "Tên tài xế";
            // 
            // txttenTX
            // 
            this.txttenTX.Location = new System.Drawing.Point(483, 19);
            this.txttenTX.Name = "txttenTX";
            this.txttenTX.Size = new System.Drawing.Size(145, 20);
            this.txttenTX.TabIndex = 3;
            // 
            // txtMaTX
            // 
            this.txtMaTX.Location = new System.Drawing.Point(64, 16);
            this.txtMaTX.Name = "txtMaTX";
            this.txtMaTX.Size = new System.Drawing.Size(170, 20);
            this.txtMaTX.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 1;
            // 
            // lbMaTX
            // 
            this.lbMaTX.AutoSize = true;
            this.lbMaTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaTX.Location = new System.Drawing.Point(6, 16);
            this.lbMaTX.Name = "lbMaTX";
            this.lbMaTX.Size = new System.Drawing.Size(54, 13);
            this.lbMaTX.TabIndex = 0;
            this.lbMaTX.Text = "Mã Tài xế";
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(93, 60);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(212, 20);
            this.txtNgay.TabIndex = 27;
            // 
            // txtMaGD
            // 
            this.txtMaGD.Location = new System.Drawing.Point(93, 32);
            this.txtMaGD.Name = "txtMaGD";
            this.txtMaGD.Size = new System.Drawing.Size(212, 20);
            this.txtMaGD.TabIndex = 26;
            this.txtMaGD.TextChanged += new System.EventHandler(this.txtMaGD_TextChanged);
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Location = new System.Drawing.Point(26, 63);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(32, 13);
            this.lbNgay.TabIndex = 25;
            this.lbNgay.Text = "Ngày";
            // 
            // lbMaGD
            // 
            this.lbMaGD.AutoSize = true;
            this.lbMaGD.Location = new System.Drawing.Point(12, 34);
            this.lbMaGD.Name = "lbMaGD";
            this.lbMaGD.Size = new System.Drawing.Size(72, 13);
            this.lbMaGD.TabIndex = 24;
            this.lbMaGD.Text = "Mã Giao Dịch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Quản lí thông tin bán vé ngày";
            // 
            // grpThongTinVeNgay
            // 
            this.grpThongTinVeNgay.Controls.Add(this.txtDG);
            this.grpThongTinVeNgay.Controls.Add(this.txtMaVeNgay);
            this.grpThongTinVeNgay.Controls.Add(this.lbDG);
            this.grpThongTinVeNgay.Controls.Add(this.lbMaVeNgay);
            this.grpThongTinVeNgay.Location = new System.Drawing.Point(29, 154);
            this.grpThongTinVeNgay.Name = "grpThongTinVeNgay";
            this.grpThongTinVeNgay.Size = new System.Drawing.Size(685, 63);
            this.grpThongTinVeNgay.TabIndex = 29;
            this.grpThongTinVeNgay.TabStop = false;
            this.grpThongTinVeNgay.Text = "Thông tin vé ngày";
            // 
            // txtDG
            // 
            this.txtDG.Location = new System.Drawing.Point(483, 13);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(145, 20);
            this.txtDG.TabIndex = 3;
            // 
            // txtMaVeNgay
            // 
            this.txtMaVeNgay.Location = new System.Drawing.Point(67, 16);
            this.txtMaVeNgay.Name = "txtMaVeNgay";
            this.txtMaVeNgay.Size = new System.Drawing.Size(170, 20);
            this.txtMaVeNgay.TabIndex = 2;
            // 
            // lbDG
            // 
            this.lbDG.AutoSize = true;
            this.lbDG.Location = new System.Drawing.Point(404, 16);
            this.lbDG.Name = "lbDG";
            this.lbDG.Size = new System.Drawing.Size(44, 13);
            this.lbDG.TabIndex = 1;
            this.lbDG.Text = "Đơn giá";
            // 
            // lbMaVeNgay
            // 
            this.lbMaVeNgay.AutoSize = true;
            this.lbMaVeNgay.Location = new System.Drawing.Point(6, 20);
            this.lbMaVeNgay.Name = "lbMaVeNgay";
            this.lbMaVeNgay.Size = new System.Drawing.Size(63, 13);
            this.lbMaVeNgay.TabIndex = 0;
            this.lbMaVeNgay.Text = "Mã vé ngày";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(509, 265);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(100, 20);
            this.txtThanhTien.TabIndex = 33;
            // 
            // txtThuVao
            // 
            this.txtThuVao.Location = new System.Drawing.Point(510, 226);
            this.txtThuVao.Name = "txtThuVao";
            this.txtThuVao.Size = new System.Drawing.Size(100, 20);
            this.txtThuVao.TabIndex = 32;
            // 
            // txtBanDuoc
            // 
            this.txtBanDuoc.Location = new System.Drawing.Point(185, 258);
            this.txtBanDuoc.Name = "txtBanDuoc";
            this.txtBanDuoc.Size = new System.Drawing.Size(100, 20);
            this.txtBanDuoc.TabIndex = 31;
            // 
            // txtBanRa
            // 
            this.txtBanRa.Location = new System.Drawing.Point(185, 223);
            this.txtBanRa.Name = "txtBanRa";
            this.txtBanRa.Size = new System.Drawing.Size(100, 20);
            this.txtBanRa.TabIndex = 30;
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(332, 32);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(75, 23);
            this.btnKiemTra.TabIndex = 45;
            this.btnKiemTra.Text = "Kiểm tra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // QuanLiThongTinBanVeNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 499);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.lbThanhTien);
            this.Controls.Add(this.lbThuVao);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbBanDuoc);
            this.Controls.Add(this.lbBanRa);
            this.Controls.Add(this.grbThongTinTaiXe);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.txtMaGD);
            this.Controls.Add(this.lbNgay);
            this.Controls.Add(this.lbMaGD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpThongTinVeNgay);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtThuVao);
            this.Controls.Add(this.txtBanDuoc);
            this.Controls.Add(this.txtBanRa);
            this.Name = "QuanLiThongTinBanVeNgay";
            this.Text = "QuanLiThongTinBanVeNgay";
            this.Load += new System.EventHandler(this.QuanLiThongTinBanVeNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.grbThongTinTaiXe.ResumeLayout(false);
            this.grbThongTinTaiXe.PerformLayout();
            this.grpThongTinVeNgay.ResumeLayout(false);
            this.grpThongTinVeNgay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVeNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG;
        private System.Windows.Forms.DataGridViewTextBoxColumn VePhatRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn VeThuVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn VeBanDuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.Label lbThuVao;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbBanDuoc;
        private System.Windows.Forms.Label lbBanRa;
        private System.Windows.Forms.GroupBox grbThongTinTaiXe;
        private System.Windows.Forms.Label lbTenTX;
        private System.Windows.Forms.TextBox txttenTX;
        private System.Windows.Forms.TextBox txtMaTX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMaTX;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.TextBox txtMaGD;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Label lbMaGD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpThongTinVeNgay;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.TextBox txtMaVeNgay;
        private System.Windows.Forms.Label lbDG;
        private System.Windows.Forms.Label lbMaVeNgay;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtThuVao;
        private System.Windows.Forms.TextBox txtBanDuoc;
        private System.Windows.Forms.TextBox txtBanRa;
        private System.Windows.Forms.Button btnKiemTra;
    }
}