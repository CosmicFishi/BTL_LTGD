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
    public partial class ChangeAdminPassword : Form
    {
        public ChangeAdminPassword()
        {
            InitializeComponent();
        }
        public static void CheckPassword()
        {

        }
        private void ChangeAdminPassword_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            textBoxConfirmPassword.PasswordChar = '*';
            buttonConfirm.Enabled = false;
        }
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowPassword.Checked)
            {
                textBoxConfirmPassword.PasswordChar = '\0';
                textBoxPassword.PasswordChar = '\0';
            }    
            else
            {
                textBoxConfirmPassword.PasswordChar = '*';
                textBoxPassword.PasswordChar = '*';
            }    
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
        }
    }
}
