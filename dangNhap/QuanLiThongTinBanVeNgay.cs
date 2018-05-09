using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dangNhap
{
    public partial class QuanLiThongTinBanVeNgay : Form
    {
        int thaotac = 0;
        string connectionString = @"Data Source=DESKTOP-8U00IH5;Initial Catalog=QLTX;Integrated Security=True";
        public QuanLiThongTinBanVeNgay()
        {
            InitializeComponent();
            dgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void QuanLiThongTinBanVeNgay_Load(object sender, EventArgs e)
        {
            txtMaGD.ReadOnly = true;
            txtNgay.ReadOnly = true;
            txtMaTX.ReadOnly = true;
            txttenTX.ReadOnly = true;
            txtMaVeNgay.ReadOnly = true;
            txtDG.ReadOnly = true;
            txtBanRa.ReadOnly = true;
            txtThuVao.ReadOnly = true;
            txtBanDuoc.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            laydanhsach();
            dgvDanhSach.Enabled = true;

        }
        private void laydanhsach()
        {
            string query = "Select * from ThongTinBanVe";
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "ThongTinBanVe");
            dgvDanhSach.DataSource = ds.Tables["ThongTinBanVe"];
        }


        private void txtMaGD_TextChanged(object sender, EventArgs e)
        {
           
        }

        private bool kiemtratontai()
        {
            bool tatkt = false;
            string maGD = txtMaGD.Text;
            SqlConnection con = new SqlConnection(connectionString);
            string query = "SELECT MaGD FROM ThongTinBanVe";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (maGD == dr.GetString(0))
                {
                    tatkt = true;
                    break;
                }
            }
            con.Close();
            return tatkt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaGD.ReadOnly = false;
            txtNgay.ReadOnly = false;
            txtMaTX.ReadOnly = false;
            txttenTX.ReadOnly = false;
            txtMaVeNgay.ReadOnly = false;
            txtDG.ReadOnly = false;
            txtBanRa.ReadOnly = false;
            txtThuVao.ReadOnly = false;
            txtBanDuoc.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            dgvDanhSach.Enabled = true;
            thaotac = 1;

            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            string MaGD = txtMaGD.Text;
            string Ngay = txtNgay.Text;
            string MaTX = txtMaTX.Text;
            string TenTX = txttenTX.Text;
            string MaVeNgay = txtMaVeNgay.Text;
            int donGia = int.Parse(txtDG.Text);
            int phatRa = int.Parse(txtBanRa.Text);
            int thuVao = int.Parse(txtThuVao.Text);
            int banDuoc = int.Parse(txtBanDuoc.Text);
            int thanhTien = int.Parse(txtThanhTien.Text);
            //kiem tra co trung ma giao dich trong database hay khong ?
            if (MaGD == null || Ngay == null || MaTX == null || TenTX == null || lbMaVeNgay == null || DG == null || VePhatRa == null || VeThuVao == null || VeBanDuoc == null || ThanhTien == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
            }
            else
            {
                switch (thaotac)
                {
                    case 1:

                        QuanLi(MaGD, Ngay, MaTX, TenTX, MaVeNgay, donGia, phatRa, thuVao, banDuoc, thanhTien);
                        laydanhsach();
                        hienthi();
                        break;
                    case 2:
                        suaThongTinBanVeNgay(MaGD,Ngay,MaTX,TenTX,MaVeNgay,donGia,phatRa,thuVao,banDuoc,thanhTien);
                        laydanhsach();
                        hienthi();
                        break;
                }


            }
        }
        private void QuanLi(string maGD, string Ngay, string MaTX, string TenTX, string MaVeNgay, int DG, int VePhatRa, int VeThuVao, int VeBanDuoc, int ThanhTien)
        {

            //string query = string.Format("insert into ThongTinBanVe values('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",maGD, Ngay, MaTX, TenTX, MaVeNgay, DG, VePhatRa, VeThuVao, VeBanDuoc, ThanhTien);
            string query = "insert into ThongTinBanVe values('" + maGD + "','" + Ngay + "','" + MaTX + "',N'" + TenTX + "','" + MaVeNgay + "','" + DG + "','" + VePhatRa + "','" + VeThuVao + "','" + VeBanDuoc + "','" + ThanhTien + "')";
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                int kq1 = cmd.ExecuteNonQuery();
                if (kq1 > 0)
                {
                    MessageBox.Show("Đã thêm thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra",ex.ToString());
            }
            finally
            {
                if (con != null)
                    con.Close();
            }


        }
        private void suaThongTinBanVeNgay(string MaGD, string Ngay, string MaTX, string TenTX, string MaVeNgay, int DG, int VePhatRa, int VeThuVao, int VeBanDuoc, int ThanhTien)
        {

            //string query = string.Format("insert into ThongTinBanVe values('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",maGD, Ngay, MaTX, TenTX, MaVeNgay, DG, VePhatRa, VeThuVao, VeBanDuoc, ThanhTien);
            string query = "UPDATE ThongTinBanVe SET Ngay = @Ngay, MaTX = @MaTX, TenTX = @TenTX, MaVeNgay = @MaVeNgay, DG = @DG, VePhatRa = @VePhatRa, VeThuVao = @VeThuVao, VeBanDuoc = @VeBanDuoc, ThanhTien = @ThanhTien WHERE MaGD = @MaGD";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using(SqlCommand cmd = new SqlCommand(query, con))
                {
                        cmd.Parameters.AddWithValue("@Ngay", Ngay);
                        cmd.Parameters.AddWithValue("@MaTX", MaTX);
                        cmd.Parameters.AddWithValue("@TenTX", TenTX);
                        cmd.Parameters.AddWithValue("@MaVeNgay", MaVeNgay);
                        cmd.Parameters.AddWithValue("@DG", DG);
                        cmd.Parameters.AddWithValue("@VePhatRa", VePhatRa);
                        cmd.Parameters.AddWithValue("@VeThuVao", VeThuVao);
                        cmd.Parameters.AddWithValue("@VeBanDuoc", VeBanDuoc);
                        cmd.Parameters.AddWithValue("@ThanhTien", ThanhTien);
                        cmd.Parameters.AddWithValue("@MaGD", MaGD);
                    try
                    {
                        con.Open();

                        int kq = cmd.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            MessageBox.Show("Đã sửa thành công", "Thông báo");
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Có lỗi khi sửa",ex.ToString());
                    }
                    }
                   
                }
            }
      
        private void hienthi()
        {
            if (dgvDanhSach.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDanhSach.SelectedRows[0];
                string MaGD = row.Cells[0].Value.ToString();
                string Ngay = row.Cells[1].Value.ToString();
                string MaTX = row.Cells[2].Value.ToString();
                string TenTX = row.Cells[3].Value.ToString();
                string MaVeNgay = row.Cells[4].Value.ToString();
                string DG = row.Cells[5].Value.ToString();
                string VePhatRa = row.Cells[6].Value.ToString();
                string VeThuVao = row.Cells[7].Value.ToString();
                string VeBanDuoc = row.Cells[8].Value.ToString();
                string ThanhTien = row.Cells[9].Value.ToString();
                txtMaGD.Text = MaGD;
                txtNgay.Text = Ngay;
                txtMaTX.Text = MaTX;
                txttenTX.Text = TenTX;
                txtMaVeNgay.Text = MaVeNgay;
                txtDG.Text = DG;
                txtBanRa.Text = VePhatRa;
                txtThuVao.Text = VeThuVao;
                txtBanDuoc.Text = VeBanDuoc;
                txtThanhTien.Text = ThanhTien;
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int donGia = Convert.ToInt32(txtDG.Text);
            int phatRa = Convert.ToInt32(txtBanRa.Text);
            int thuVao = Convert.ToInt32(txtThuVao.Text);
            if (phatRa > thuVao)
            {
                int kq1 = phatRa - thuVao;
                int kq2 = kq1 * donGia;
                txtBanDuoc.Text = kq1.ToString();
                txtThanhTien.Text = kq2.ToString();
            }
            else
            {
                MessageBox.Show("vui lòng nhập lại đơn giá, số vé phát ra, hoặc số thu vào", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaGD.ReadOnly = true;
            txtNgay.ReadOnly = false;
            txtMaTX.ReadOnly = false;
            txttenTX.ReadOnly = false;
            txtMaVeNgay.ReadOnly = false;
            txtDG.ReadOnly = false;
            txtBanRa.ReadOnly = false;
            txtThuVao.ReadOnly = false;
            txtBanDuoc.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            dgvDanhSach.Enabled = true;
            thaotac = 2;

        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string maDG = dgvDanhSach.Rows[e.RowIndex].Cells[0].Value.ToString();
                string ngay = dgvDanhSach.Rows[e.RowIndex].Cells[1].Value.ToString();
                string maTX = dgvDanhSach.Rows[e.RowIndex].Cells[2].Value.ToString();
                string tenTX = dgvDanhSach.Rows[e.RowIndex].Cells[3].Value.ToString();
                string maVeNgay = dgvDanhSach.Rows[e.RowIndex].Cells[4].Value.ToString();
                string DG = dgvDanhSach.Rows[e.RowIndex].Cells[5].Value.ToString();
                string vePhatRa = dgvDanhSach.Rows[e.RowIndex].Cells[6].Value.ToString();
                string veThuVao = dgvDanhSach.Rows[e.RowIndex].Cells[7].Value.ToString();
                string veBanDuoc = dgvDanhSach.Rows[e.RowIndex].Cells[8].Value.ToString();
                string thanhTien = dgvDanhSach.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtMaGD.Text = maDG;
                txtNgay.Text = ngay;
                txtMaTX.Text = maTX;
                txttenTX.Text = tenTX;
                txtMaVeNgay.Text = maVeNgay;
                txtDG.Text = DG;
                txtThuVao.Text = veThuVao;
                txtBanRa.Text = vePhatRa;
                txtBanDuoc.Text = veBanDuoc;
                txtThanhTien.Text = thanhTien;              
            }
            catch (Exception ex)
            {
                MessageBox.Show("thao tác lỗi !!",ex.ToString());
            }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (kiemtratontai())
            {
                txtMaGD.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Trùng mã");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaGD = txtMaGD.Text;
            if(MessageBox.Show("Bạn có muốn xòa giao dịch này","Xác nhận ?",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                XoaGD(MaGD);
                laydanhsach();
                hienthi();
            }
        }

        private void XoaGD(string MaGD)
        {
            string query = "DELETE FROM ThongTinBanVe WHERE MaGD = @MaGD";
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                using(SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("MaGD", SqlDbType.NVarChar);
                    cmd.Parameters["MaGD"].Value = MaGD;
                    try
                    {
                        con.Open();
                        int kq3 = cmd.ExecuteNonQuery();
                        if(kq3 > 0)
                        {
                            MessageBox.Show("Đã xóa thành công");
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Có lỗi khi xóa", ex.ToString());
                    }
                }
            }
        }
    }
}
