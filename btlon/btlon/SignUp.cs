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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
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

            for (int i = 1990; i <= 2020; i++)
            {
                comboBoxNam.Items.Add(i);
            }
        }
    }
}
