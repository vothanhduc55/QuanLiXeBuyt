using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dangNhap
{
    public partial class trangChu : Form
    {
      
        public trangChu()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bntDangXuat_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
          //  DialogResult = DialogResult.OK;
      
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyLuuThong tc = new QuanLyLuuThong();
            this.Hide();
            tc.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThongTinTuyenXE tc = new ThongTinTuyenXE();
            this.Hide();
            tc.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timKiemTaiXe tx = new timKiemTaiXe();
            this.Hide();
            tx.ShowDialog();
            this.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuanLiThongTinBanVeNgay tc = new QuanLiThongTinBanVeNgay();
            this.Hide();
            tc.ShowDialog();
            this.Show();
        }
    }
}
