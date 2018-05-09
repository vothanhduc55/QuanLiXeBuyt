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
    public partial class dangNhap : Form
    {
        string con = @"Data Source=DESKTOP-8U00IH5;Initial Catalog=QLTX;Integrated Security=True";
        public dangNhap()
        {
            InitializeComponent();
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            if (txt_matKhau.Text == "" || txt_tenDN.Text == "")
            {
                label4.Visible = true;
                label4.Text = "Vui lòng nhập đầy đủ thông tin!!";
            }
            else
            {
                string user = (txt_tenDN.Text);
                user = user.Trim();
                string pass = txt_matKhau.Text;
                pass = pass.Trim();

                SqlConnection conn = new SqlConnection(con);

                conn.Open();
                String query = String.Format("Select * from TaiKhoan where taiKhoan ='{0}' and matKhau = '{1}'", user, pass);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {

                    trangChu tc = new trangChu();
                    this.Hide();
                    tc.ShowDialog();
                    this.Show();
                   // DialogResult = DialogResult.OK;
                   
                }
                else
                {
                    label4.Visible = true;
                    label4.Text = "Tên đăng nhập hoặc mật khẩu không đúng!!";
                    txt_matKhau.Text = "";
                }
            }

                  
        }

        private void btn_huyBo_Click(object sender, EventArgs e)
        {
            txt_matKhau.Text = "";
            txt_tenDN.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label4.Visible = false;

        }
    }
}
