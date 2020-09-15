using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace btlon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string email; // sdt dùng để gán qua form1
        public static string sdt;// email dùng để gán qua form 1
        public Boolean checkDangNhap()
        {
            String string_conn =
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+Application.StartupPath + @"\" + "QLKH.mdf"+";Integrated Security=True";
            SqlConnection conn = new SqlConnection(string_conn);
            conn.Open();
            String qr = "Select * from KhachHang where Email='" + txtBoxAccount.Text + "' and password = '" + txtBoxPassword.Text + "';";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(qr, conn);
            DataTable dttb = new DataTable();
            dataAdapter.Fill(dttb);
            if (dttb.Rows.Count == 1)
            {
                foreach (DataRow dr in dttb.Rows)
                {
                    sdt = dr["Sdt"].ToString();
                    //MessageBox.Show(sdt.ToString());
                }
                return true;
            }
            conn.Close();
            return false;
        }
        public Boolean checkAccountAdmin()
        {
            String string_conn =
               @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\" + "QLKH.mdf" + ";Integrated Security=True";
            //MessageBox.Show(string_conn);
            SqlConnection conn = new SqlConnection(string_conn);
            conn.Open();
            String qr = "Select * from Admin  where tk='" + txtBoxAccount.Text + "' and pass = '" + txtBoxPassword.Text + "';";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(qr, conn);
            DataTable dttb = new DataTable();
            dataAdapter.Fill(dttb);

            if (txtBoxAccount.Text.IndexOf("Admin") > -1 && dttb.Rows.Count == 1)
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
            if (txtBoxPassword.Text != "")
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
            if (checkBoxShowPassword.Checked)
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
            if (txtBoxPassword.Text == "Nhập Password")
            {
                txtBoxPassword.Text = "";
                txtBoxPassword.ForeColor = Color.Black;
                txtBoxPassword.PasswordChar = '*';
            }
        }

        private void txtBoxPassword_Leave(object sender, EventArgs e)
        {
            if (txtBoxPassword.Text == "")
            {
                txtBoxPassword.Text = "Nhập Password";
                txtBoxPassword.ForeColor = SystemColors.ControlDark;
                txtBoxPassword.PasswordChar = '\0';
            }
        }


        private void btLogin_Click(object sender, EventArgs e)
        {
            if (checkAccountAdmin() == true)
            {
                this.Hide();
                QuanLyKhachHang qlkh = new QuanLyKhachHang();
                qlkh.ShowDialog();
                this.Close();
            }
            else if (checkDangNhap() == true)
            {
                email = txtBoxAccount.Text;
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                Form1 f = new Form1();

                //tạo ra connection
                String string_conn =
               @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\" + "QLKH.mdf" + ";Integrated Security=True";
                SqlConnection conn = new SqlConnection(string_conn);
                conn.Open();
                String qr = "Select * from KhachHang where Email='" + txtBoxAccount.Text + "' and password = '" + txtBoxPassword.Text + "';";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(qr, conn);
                DataTable dttb = new DataTable();
                dataAdapter.Fill(dttb);

                if (dttb.Rows.Count == 1)
                {
                    foreach (DataRow dr in dttb.Rows)
                    {
                        f.getProp(dr["hoTen"].ToString(), sdt);
                    }
                }

                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Của Bạn Đã Sai");
            }

        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if(keyData == Keys.Enter)
            {
                if (checkAccountAdmin() == true)
                {
                    this.Hide();
                    QuanLyKhachHang qlkh = new QuanLyKhachHang();
                    qlkh.ShowDialog();
                    this.Close();
                }
                else if (checkDangNhap() == true)
                {
                    email = txtBoxAccount.Text;
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    Form1 f = new Form1();

                    //tạo ra connection
                    String string_conn =
                   @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\" + "QLKH.mdf" + ";Integrated Security=True";
                    SqlConnection conn = new SqlConnection(string_conn);
                    conn.Open();
                    String qr = "Select * from KhachHang where Email='" + txtBoxAccount.Text + "' and password = '" + txtBoxPassword.Text + "';";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(qr, conn);
                    DataTable dttb = new DataTable();
                    dataAdapter.Fill(dttb);

                    if (dttb.Rows.Count == 1)
                    {
                        foreach (DataRow dr in dttb.Rows)
                        {
                            f.getProp(dr["hoTen"].ToString(), sdt);
                        }
                    }

                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Của Bạn Đã Sai");
                }
                return true;
            }
            if(keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp sg = new SignUp();
            sg.ShowDialog();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        { 

        }
    }
}
