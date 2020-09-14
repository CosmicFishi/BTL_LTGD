using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace btlon
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
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
            txtbPassword.Text = "Nhập Password của bạn";
            txtbPassword.ForeColor = SystemColors.ControlDark;
            txtbCfPassword.Text = "Xác Nhận Lại Mật Khẩu";
            txtbCfPassword.ForeColor = SystemColors.ControlDark;
            btTaoTaiKhoan.Enabled = false;
            btTaoTaiKhoan.ForeColor = Color.DarkGray;
            btTaoTaiKhoan.BackColor = Color.Gray;
        }

        private void dateTimePickerNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            comboBoxNgay.Text = dateTimePickerNgaySinh.Value.ToString("dd");
            comboBoxThang.Text = dateTimePickerNgaySinh.Value.ToString("MM");
            comboBoxNam.Text = dateTimePickerNgaySinh.Value.ToString("yyyy");
        }

        private void comboBoxNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ngay = int.Parse(comboBoxNgay.Text);
            dateTimePickerNgaySinh.Value = new DateTime(2000,2,ngay);
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
            if(checkEmail() == false)
            {
                btTaoTaiKhoan.Enabled = false;
                MessageBox.Show("Sai Định Dạng Email \r\n abc.@gmail.com hoặc abc.@gmail.com.vn");
            }    
            else
            {
                btTaoTaiKhoan.Enabled = true;
                btTaoTaiKhoan.ForeColor = Color.Red;
                btTaoTaiKhoan.BackColor = Color.Yellow;
            }
            if(txtbEmail.Text=="")
            {
                txtbEmail.Text = "Nhập Email";
                txtbEmail.ForeColor = SystemColors.ControlDark;
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

            }    
        }

        private void radioButtonNam_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btTaoTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerNgaySinh_Enter(object sender, EventArgs e)
        {

        }

        private void txtbHoTen_TextChanged(object sender, EventArgs e)
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
    }
}
