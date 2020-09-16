using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace btlon
{
    public partial class ThongTinKhachHang : Form
    {
        public ThongTinKhachHang()
        {
            InitializeComponent();
        }
        public static String gt;
        public static String ten;
        public static String std;
        public static String dc;
        public static String ns;
        private void ThongTinKhachHang_Load(object sender, EventArgs e)
        {
            String string_conn =
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\" + "QLKH.mdf" + ";Integrated Security=True";
            SqlConnection conn = new SqlConnection(string_conn);
            try
            {
                conn.Open();
                String qr = "Select * from KhachHang where Email='" + Login.email + "';";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(qr, conn);
                DataTable dttb = new DataTable();
                dataAdapter.Fill(dttb);
                if (dttb.Rows.Count == 1)
                {
                    //MessageBox.Show(sdt.ToString());
                    foreach (DataRow dr in dttb.Rows)
                    {
                        lbSdt.Text = dr["Sdt"].ToString();
                        lbHT.Text = dr["hoTen"].ToString();
                        lbNs.Text = dr["ngaySinh"].ToString();
                        lbDc.Text = dr["DiaChi"].ToString();
                        gt = dr["gioiTinh"].ToString();
                    }
                }
                conn.Close();
                lbE.Text = Login.email;
                lbGt.Text = gt;

            }
            catch(SqlException err)
            {
                MessageBox.Show(err.ToString());
            }
            ten = lbHT.Text;
            ns = lbNs.Text;
            dc = lbDc.Text;
            std = lbSĐT.Text;

        }

        private void btChinhSuaThongTin_Click(object sender, EventArgs e)
        {
            SuaThongTinKhachHang stt = new SuaThongTinKhachHang();
            stt.ShowDialog();
            this.Close();
        }
    }
}
