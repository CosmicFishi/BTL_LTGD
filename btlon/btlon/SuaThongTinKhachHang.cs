using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace btlon
{
    public partial class SuaThongTinKhachHang : Form
    {
        public SuaThongTinKhachHang()
        {
            InitializeComponent();
        }
        String gt;
        private void dateTimePickerNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            comboBoxNgay.Text = dateTimePickerNgaySinh.Value.ToString("dd");
            comboBoxThang.Text = dateTimePickerNgaySinh.Value.ToString("MM");
            comboBoxNam.Text = dateTimePickerNgaySinh.Value.ToString("yyyy");
        }

        private void SuaThongTinKhachHang_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                comboBoxThang.Items.Add(i);
            }
            for (int i = 1; i <= 31; i++)
            {
                comboBoxNgay.Items.Add(i);
            }

            for (int i = 1920; i <= 2020; i++)
            {
                comboBoxNam.Items.Add(i);
            }
            if (Login.gt.IndexOf("Nam") > -1)
            {
                radioButtonNam.Checked = true;
            }
            else
            {
                radioButtonNu.Checked = true;
            }
            gt = ThongTinKhachHang.gt;
            txtbEmail.Text = Login.email;
            txtbHoTen.Text = Login.ten;
            txtbSĐT.Text = Login.sdt;
            dateTimePickerNgaySinh.Text = Login.ngaySinh;
            textBoxDc.Text = Login.diaChi;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
           
           
            if (txtbHoTen.Text == "" || txtbSĐT.Text == "" || textBoxDc.Text == "")
            {
                MessageBox.Show("Không Được để trống");
            }
            else
            {
                String string_conn =
              @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\" + "QLKH.mdf" + ";Integrated Security=True";
                SqlConnection conn = new SqlConnection(string_conn);
                conn.Open();
                try
                {
                    String update_String = "UPDATE [dbo].[KhachHang] SET hoTen=N'" + txtbHoTen.Text + "',Sdt =N'" + txtbSĐT.Text + "',DiaChi =N'" + textBoxDc.Text + "',gioiTinh =N'" + gt + "' ,ngaySinh ='" + dateTimePickerNgaySinh.Value.ToString("dd/MM/yyyy") + "'  where Email=N'" + Login.email + "';";
                    SqlCommand cmmd = new SqlCommand(update_String, conn);
                    cmmd.ExecuteNonQuery();

                }
                catch (SqlException err)
                {
                    conn.Close();
                    MessageBox.Show(err.ToString());
                }
                finally
                {
                    conn.Close();
                    MessageBox.Show("Sửa thông tin thành công");
                }
                this.Close();
            }
           
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
