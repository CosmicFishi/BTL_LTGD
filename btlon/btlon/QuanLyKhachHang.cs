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
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
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
    }
}
