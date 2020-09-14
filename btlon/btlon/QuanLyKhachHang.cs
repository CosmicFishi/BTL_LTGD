using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace btlon
{
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommandBuilder cmmd;
        SqlDataAdapter dtad;
        DataTable dttb;
        String string_conn = @"Data Source=MAYTINH-B85D1NU\SQLEXPRESS;Initial Catalog=QuanLyKhachHang;Integrated Security=True";
        public String taoID()
        {
           String qr = "Select * from KhachHang";
            dtad = new SqlDataAdapter(qr, conn);
            cmmd = new SqlCommandBuilder(dtad);
            dttb = new DataTable();
            dtad.Fill(dttb);
            dataGridView1.DataSource = dttb;
           int tam = dataGridView1.Rows.Count-1;
           var iDCuoi  = dataGridView1.Rows[tam].Cells[0].Value.ToString().Substring(2);
           String iD = String.Format("KH" + (int.Parse(iDCuoi)+1));
           return iD;
        }
        public void Loaddata()
        {
            String qr = "Select * from KhachHang";
            dtad = new SqlDataAdapter(qr, conn);
            cmmd = new SqlCommandBuilder(dtad);
            dttb = new DataTable();
            dtad.Fill(dttb);
            dataGridView1.DataSource = dttb;
        }
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeAdminPassword changePassword = new ChangeAdminPassword();
            changePassword.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.ShowDialog();
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(string_conn);
            conn.Open();
            Loaddata();
            MessageBox.Show(taoID());
        }

        private void QuanLyKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
    }
}
