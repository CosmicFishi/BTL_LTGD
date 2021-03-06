﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace btlon
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        String gt= "Nam";
        SqlConnection conn;
        String string_conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+Application.StartupPath + @"\" + "QLKH.mdf"+";Integrated Security=True";
        public Boolean checkEmail()
        {

           
            String s = txtbEmail.Text;
            int id = s.IndexOf("@gmail.com");
            if(id==-1)
            {
                return false;
            }    
            return true;
        }
        public Boolean IsEmailHaved()
        {
            String string_conn =
               @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\" + "QLKH.mdf" + ";Integrated Security=True";
            SqlConnection conn = new SqlConnection(string_conn);
            conn.Open();
            String qr = "Select * from KhachHang where Email='" + txtbEmail.Text + "';";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(qr, conn);
            DataTable dttb = new DataTable();
            dataAdapter.Fill(dttb);
            if (dttb.Rows.Count == 1)
            {
                return true;
            }
            conn.Close();
            return false;
        }
        private void SignUp_Load(object sender, EventArgs e)
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
            txtbSĐT.Text = "Nhập Số Điện Thoại";
            txtbSĐT.ForeColor = SystemColors.ControlDark;
            txtbHoTen.Text = "Nhập Họ Tên";
            txtbHoTen.ForeColor = SystemColors.ControlDark;
            txtbEmail.Text = "Nhập Email";
            txtbEmail.ForeColor = SystemColors.ControlDark;
            //txtbPassword.Text = "Nhập Password của bạn";
            //txtbPassword.ForeColor = SystemColors.ControlDark;
            txtbCfPassword.Text = "Xác Nhận Lại Mật Khẩu";
            txtbCfPassword.ForeColor = SystemColors.ControlDark;
            btTaoTaiKhoan.Enabled = false;
            btTaoTaiKhoan.ForeColor = Color.DarkGray;
            btTaoTaiKhoan.BackColor = Color.Gray;
            DateTime dt = DateTime.Now;
            dateTimePickerNgaySinh.Text = dt.ToString("dd/MM/yyyy");


        }

        private void dateTimePickerNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            comboBoxNgay.Text = dateTimePickerNgaySinh.Value.ToString("dd");
            comboBoxThang.Text = dateTimePickerNgaySinh.Value.ToString("MM");
            comboBoxNam.Text = dateTimePickerNgaySinh.Value.ToString("yyyy");
        }

        private void comboBoxNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxThang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxNam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbHoTen_Enter(object sender, EventArgs e)
        {
            if(txtbHoTen.Text=="Nhập Họ Tên")
            {
                txtbHoTen.Text = "";
                txtbHoTen.ForeColor = Color.Black;
            }    
        }

        private void txtbHoTen_Leave(object sender, EventArgs e)
        {
            if (txtbHoTen.Text == "")
            {
                txtbHoTen.Text = "Nhập Họ Tên";
                txtbHoTen.ForeColor = SystemColors.ControlDark;
                error.SetError(txtbHoTen, "Không bỏ Trống");
                btTaoTaiKhoan.Enabled = false;
                btTaoTaiKhoan.ForeColor = Color.DarkGray;
                btTaoTaiKhoan.BackColor = Color.Gray;
            }  
            else
            {
                btTaoTaiKhoan.Enabled = true;
                error.Clear();
            }    
        }

        private void txtbSĐT_Enter(object sender, EventArgs e)
        {
            if(txtbSĐT.Text=="Nhập Số Điện Thoại")
            {
                txtbSĐT.Text = "";
                txtbSĐT.ForeColor = Color.Black;
            }    
        }

        private void txtbSĐT_Leave(object sender, EventArgs e)
        {
            if(txtbSĐT.Text == "")
            {
                txtbSĐT.Text = "Nhập Số Điện Thoại";
                txtbSĐT.ForeColor = SystemColors.ControlDark;
                error.SetError(txtbSĐT, "Không bỏ Trống");
                btTaoTaiKhoan.Enabled = false;
                btTaoTaiKhoan.ForeColor = Color.DarkGray;
                btTaoTaiKhoan.BackColor = Color.Gray;
            }
            else
            {
                error.Clear();
                btTaoTaiKhoan.Enabled = true;
            }
        }

        private void txtbEmail_Enter(object sender, EventArgs e)
        {
            if(txtbEmail.Text=="Nhập Email")
            {
                txtbEmail.Text = "";
                txtbEmail.ForeColor = Color.Black;
            }

        }

        private void txtbEmail_Leave(object sender, EventArgs e)
        {
            if(IsEmailHaved()==true)
            {
                MessageBox.Show("Email bị trùng");
                btTaoTaiKhoan.Enabled = false;
                btTaoTaiKhoan.ForeColor = Color.DarkGray;
                btTaoTaiKhoan.BackColor = Color.Gray;
            }
          
            else if (checkEmail() == false || txtbEmail.Text == "")
            {
                btTaoTaiKhoan.Enabled = false;
                MessageBox.Show("Sai Định Dạng Email \r\n abc.@gmail.com hoặc abc.@gmail.com.vn");
                txtbEmail.Text = "Nhập Email";
                txtbEmail.ForeColor = SystemColors.ControlDark;
                error.SetError(txtbEmail, "Không bỏ Trống");
                btTaoTaiKhoan.ForeColor = Color.DarkGray;
                btTaoTaiKhoan.BackColor = Color.Gray;
            }
            else if(txtbPassword.Text=="")
            {
                btTaoTaiKhoan.Enabled = false;
                btTaoTaiKhoan.ForeColor = Color.DarkGray;
                btTaoTaiKhoan.BackColor = Color.Gray;
            }
            else
            {
                error.Clear();
                btTaoTaiKhoan.Enabled = true;
                btTaoTaiKhoan.ForeColor = Color.Red;
                btTaoTaiKhoan.BackColor = Color.Yellow;
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowPassword.Checked==false)
            {
                txtbCfPassword.PasswordChar = '*';
                txtbPassword.PasswordChar = '*';
            }
            else
            {
                txtbCfPassword.PasswordChar = '\0';
                txtbPassword.PasswordChar = '\0';
               
            }
        }

        private void txtbPassword_Enter(object sender, EventArgs e)
        {
           if(txtbPassword.Text=="Nhập Password của bạn")
            {
                txtbPassword.Text = "";
                txtbPassword.PasswordChar = '*';
                txtbPassword.ForeColor = Color.Black;
               
            }
        }

        private void txtbPassword_Leave(object sender, EventArgs e)
        {
            if (txtbPassword.Text == "")
            {
                txtbPassword.Text = "Nhập Password của bạn";
                txtbPassword.ForeColor = SystemColors.ControlDark;
                txtbPassword.PasswordChar = '\0';
                error.SetError(txtbPassword, "Không bỏ trống");
                btTaoTaiKhoan.Enabled = false;
                btTaoTaiKhoan.ForeColor = Color.DarkGray;
                btTaoTaiKhoan.BackColor = Color.Gray;
            }
           else if(txtbPassword.Text!=txtbCfPassword.Text)
            {
                btTaoTaiKhoan.Enabled = false;
                btTaoTaiKhoan.ForeColor = Color.DarkGray;
                btTaoTaiKhoan.BackColor = Color.Gray;
            }
            else if(txtbCfPassword.Text=="")
            {
                btTaoTaiKhoan.Enabled = false;
                btTaoTaiKhoan.ForeColor = Color.DarkGray;
                btTaoTaiKhoan.BackColor = Color.Gray;
            }
            else
            {
                btTaoTaiKhoan.Enabled = true;
                error.Clear();
                btTaoTaiKhoan.ForeColor = Color.Red;
                btTaoTaiKhoan.BackColor = Color.Yellow;
            }
        }

        private void txtbCfPassword_Enter(object sender, EventArgs e)
        {
            if(txtbCfPassword.Text=="Xác Nhận Lại Mật Khẩu")
            {
                txtbCfPassword.Text = "";
                txtbCfPassword.PasswordChar = '*';
                txtbCfPassword.ForeColor = Color.Black;
            }    
        }

        private void txtbCfPassword_Leave(object sender, EventArgs e)
        {
            if(txtbCfPassword.Text=="")
            {
                txtbCfPassword.Text = "Xác Nhận Lại Mật Khẩu";
                txtbCfPassword.ForeColor = SystemColors.ControlDark;
                txtbCfPassword.PasswordChar = '\0';
                error.SetError(txtbCfPassword, "Không bỏ trống");
                btTaoTaiKhoan.Enabled = false;
                btTaoTaiKhoan.ForeColor = Color.DarkGray;
                btTaoTaiKhoan.BackColor = Color.Gray;

            }
            else if(txtbCfPassword.Text!=txtbPassword.Text)
            {
                btTaoTaiKhoan.Enabled = false;
                btTaoTaiKhoan.ForeColor = Color.DarkGray;
                btTaoTaiKhoan.BackColor = Color.Gray;
                MessageBox.Show("Mật Khẩu Không Trùng Khớp");
            }
            else
            {
                btTaoTaiKhoan.Enabled = true;
                error.Clear();
                btTaoTaiKhoan.ForeColor = Color.Red;
                btTaoTaiKhoan.BackColor = Color.Yellow;
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

        private void btTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            if(txtbEmail.Text!="")
            {
                conn = new SqlConnection(string_conn);
                String qr = "INSERT INTO [dbo].[KhachHang]([Email],[hoTen],[Sdt],[DiaChi],[gioiTinh],[ngaySinh],[password]) VALUES" +
                    "(N'" + txtbEmail.Text + "', N'" + txtbHoTen.Text + "', '" + txtbSĐT.Text + "', N'" + textBoxDc.Text + "', N'" + gt + "', '" + dateTimePickerNgaySinh.Value.ToString("dd/MM/yyyy") + "', '" + txtbCfPassword.Text + "')";
                try
                {
                    SqlCommand cmmd = new SqlCommand(qr, conn);
                    conn.Open();
                    cmmd.ExecuteNonQuery();
                }
                catch (SqlException err)
                {

                    MessageBox.Show("Tạo Tài Khoản thất bại" + err.ToString());
                    conn.Close();
                }
                finally
                {
                    conn.Close();
                    ThongTinKhachHang ttkh = new ThongTinKhachHang();
                    ttkh.getEmail(txtbEmail.Text);
                    MessageBox.Show("Tạo tài khoản thành công");
                    Form1 f = new Form1();
                    //f.getProp(txtbHoTen.Text, txtbSĐT.Text);
                    f.ShowDialog();
                    this.Close();
                }
            }    
            else
            {
                MessageBox.Show("Không Được Bỏ Trống Email và Password");
            }    

           
            
        }

        private void dateTimePickerNgaySinh_Enter(object sender, EventArgs e)
        {

        }

   
        private void txtbHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true) {
                e.Handled = true;
                MessageBox.Show("chi duoc nhap chu so");
            }
        }

        private void txtbSĐT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) == true)
            {
                e.Handled = true;
                MessageBox.Show("chi duoc nhap chu so");
            }
        }

        private void SignUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btTaoTaiKhoan_Click(sender, e);
            }
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Close();
            }
        }

        private void textBoxDc_Leave(object sender, EventArgs e)
        {
            if (textBoxDc.Text == "") 
            {
                error.SetError(textBoxDc,"Không được bỏ trống");
                btTaoTaiKhoan.Enabled = false;
            }
            else
            {
                error.Clear();
                btTaoTaiKhoan.Enabled = true;
            }
        }
    }
}
