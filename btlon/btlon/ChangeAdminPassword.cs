﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace btlon
{
    public partial class ChangeAdminPassword : Form
    {
        public ChangeAdminPassword()
        {
            InitializeComponent();
        }
        void CheckPassword()
        {
            if (textBoxPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Mật Khẩu Chưa Khớp"); 
            }
        }
        private void ChangeAdminPassword_Load(object sender, EventArgs e)
        {  
            textBoxConfirmPassword.PasswordChar = '*';
            textBoxPassword.PasswordChar = '*';
            buttonConfirm.Enabled = false;
        }
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxConfirmPassword.PasswordChar = '\0';
            }    
            else
            {
                textBoxPassword.PasswordChar = '*';
                textBoxConfirmPassword.PasswordChar = '*';
            }
           
        }
        private void buttonConfirm_Click(object sender, EventArgs e)
        {

        }

        private void textBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if(textBoxConfirmPassword.Text==textBoxPassword.Text)
            {
                buttonConfirm.Enabled = true;
            }
            else
            {
                buttonConfirm.Enabled = false;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if(textBoxConfirmPassword.Text!="")
            {
                buttonConfirm.Enabled = false;
            }
        }

        private void textBoxConfirmPassword_Leave(object sender, EventArgs e)
        {
            CheckPassword();
        }
    }
}
