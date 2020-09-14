using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace btlon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public Boolean checkAccountAdmin()
        {
           if(txtBoxAccount.Text.IndexOf("Admin")>-1)
            {
                return true;
            }
            return false;
        }
        private void txtBoxAccount_TextChanged(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if(txtBoxPassword.Text!="")
            {
                txtBoxPassword.PasswordChar = '*';
            }
            if (txtBoxPassword.Text == "")
            {
                txtBoxPassword.Text = "Nhập Password";
                txtBoxPassword.ForeColor = SystemColors.ControlDark;
                txtBoxPassword.PasswordChar = '\0';
            }
            if (txtBoxAccount.Text == "")
            {
                txtBoxAccount.Text = "Nhập Email hoặc Số Điện Thoại";
                txtBoxAccount.ForeColor = SystemColors.ControlDark;
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowPassword.Checked)
            {
                txtBoxPassword.PasswordChar = '\0';
            }
            else
            {
                txtBoxPassword.PasswordChar = '*';
            }
        }
        private void btLogin_MouseHover(object sender, EventArgs e)
        {
            btLogin.ForeColor = Color.White;
            btLogin.BackColor = Color.Blue;
        }

        private void btLogin_MouseLeave(object sender, EventArgs e)
        {
            btLogin.ForeColor = Color.MediumBlue;
            btLogin.BackColor = Color.Yellow;
        }

        private void txtBoxAccount_Enter(object sender, EventArgs e)
        {
            if (txtBoxAccount.Text == "Nhập Email hoặc Số Điện Thoại")
            {
                txtBoxAccount.Text = "";
                txtBoxAccount.ForeColor = Color.Black;
            }
           
        }

        private void txtBoxAccount_Leave(object sender, EventArgs e)
        {
            if (txtBoxAccount.Text == "")
            {
                txtBoxAccount.Text = "Nhập Email hoặc Số Điện Thoại";
                txtBoxAccount.ForeColor = SystemColors.ControlDark;
            }
        }

        private void txtBoxPassword_Enter(object sender, EventArgs e)
        {
            if(txtBoxPassword.Text=="Nhập Password")
            {
                txtBoxPassword.Text = "";
                txtBoxPassword.ForeColor =Color.Black;
                txtBoxPassword.PasswordChar = '*';
            }    
        }

        private void txtBoxPassword_Leave(object sender, EventArgs e)
        {
            if(txtBoxPassword.Text=="")
            {
                txtBoxPassword.Text = "Nhập Password";
                txtBoxPassword.ForeColor = SystemColors.ControlDark;
                txtBoxPassword.PasswordChar = '\0';
            }    
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if(checkAccountAdmin()==true)
            {
                this.Hide();
                QuanLyKhachHang qlkh = new QuanLyKhachHang();
                qlkh.ShowDialog();
                this.Close();
            }    
            else
            {

                this.Hide();
                Form1 f = new Form1();
                f.ShowDialog();
                this.Close();
            }    
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp sg = new SignUp();
            sg.ShowDialog();
        }
    }
}
