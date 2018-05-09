using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dangNhap
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new QuanLiThongTinBanVeNgay());

           // DangNhap();
           // DangXuat();
        }
        public static void DangNhap()
        {
            dangNhap dn = new dangNhap();

            if (dn.ShowDialog() == DialogResult.OK)
            {
                trangChu tc = new trangChu();
                Application.Run(tc);

            }

        }
        public static void DangXuat()
        {
            trangChu dx = new trangChu();
            if (dx.ShowDialog() == DialogResult.OK)
            {

                dx.Close();
                Application.Run(new dangNhap());

            }

        }
    }
}
