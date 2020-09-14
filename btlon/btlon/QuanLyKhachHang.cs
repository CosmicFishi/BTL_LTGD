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
        DateTime dt;
        String gt = ""; // giới tính
        SqlConnection conn;
        SqlCommandBuilder cmmbd;
        SqlDataAdapter dtad;
        DataTable dttb;
       
        String string_conn = @"Data Source=MAYTINH-B85D1NU\SQLEXPRESS;Initial Catalog=QuanLyKhachHang;Integrated Security=True";
        //public String taoID()
        //{
        //   String qr = "Select * from KhachHang";
        //    dtad = new SqlDataAdapter(qr, conn);
        //    cmmbd = new SqlCommandBuilder(dtad);
        //    dttb = new DataTable();
        //    dtad.Fill(dttb);
        //    dataGridView1.DataSource = dttb;
        //   int tam = dataGridView1.Rows.Count-1;
        //   var iDCuoi  = dataGridView1.Rows[tam].Cells[0].Value.ToString().Substring(2);
        //   String iD = String.Format("KH" + (int.Parse(iDCuoi)+1));
        //   return iD;
        //}
        public void Loaddata()
        {
            String qr = "SELECT*FROM[dbo].[KhachHang]";
            dtad = new SqlDataAdapter(qr, conn);
            cmmbd = new SqlCommandBuilder(dtad);
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

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(string_conn);
            conn.Open();
            Loaddata();
        }

        private void QuanLyKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows.Count>1)
            {
                int i;
                i = dataGridView1.CurrentRow.Index;
                textBoxEmail.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txtbHoTen.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBoxSDT.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                textBoxDc.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                gt = dataGridView1.Rows[i].Cells[4].Value.ToString();
                textBoxPassword.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                dateTimePickerNgaySinh.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                if (gt.IndexOf("Nam") > -1)
                {
                    radioButtonNam.Checked = true;
                }
                else
                {
                    radioButtonNu.Checked = true;
                }
            }    
            
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            String delete_String = "delete from KhachHang where Email='"+textBoxEmail.Text+"'";
            try
            {
                SqlCommand cmmd = new SqlCommand(delete_String, conn);
                cmmd.ExecuteNonQuery();
                Loaddata();
                MessageBox.Show("Xóa Thành Công");
            }
            catch (SqlException err)
            {

                MessageBox.Show(err.ToString());
            }
            
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            dt = dateTimePickerNgaySinh.Value;
            try
            {
                String update_String = "UPDATE [dbo].[KhachHang] SET hoTen=N'"+txtbHoTen.Text +"',Sdt =N'"+textBoxSDT.Text+"',DiaChi =N'"+textBoxDc.Text+"',gioiTinh =N'"+gt+"' ,ngaySinh ='"+dt.ToString("dd/MM/yyyy")+"' ,password = '"+textBoxPassword.Text+"' where Email=N'"+textBoxEmail.Text+"';";
                SqlCommand cmmd = new SqlCommand(update_String, conn);
                cmmd.ExecuteNonQuery();
                Loaddata();
            }
            catch (SqlException err)
            {

                MessageBox.Show(err.ToString());
            }
        }

        private void radioButtonNam_CheckedChanged(object sender, EventArgs e)
        {
            
            if(radioButtonNam.Checked)
            {
                gt = "Nam";
            } 
            else
            {
                gt = "Nữ";
            }    
        }

        private void dateTimePickerNgaySinh_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            textBoxDc.Text = "";
            textBoxPassword.Text = "";
            textBoxSDT.Text = "";
            String sreachQuery = "Select * From KhachHang where Email like '%" + textBoxEmail.Text + "%';";
            dtad = new SqlDataAdapter(sreachQuery, conn);
            cmmbd = new SqlCommandBuilder(dtad);
            dttb = new DataTable();
            dtad.Fill(dttb);
            dataGridView1.DataSource = dttb;
        }

        private void buttonLoadLai_Click(object sender, EventArgs e)
        {
            Loaddata();
            textBoxEmail.Text = "";
        }

        private void QuanLyKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ban co chac muon dong??", "Dong form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
