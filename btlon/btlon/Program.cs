using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace btlon
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SignUp());
            //Application.Run(new Login());
            Application.Run(new Form1());
            //Application.Run(new Form1());
            //Application.Run(new QuanLyKhachHang());
            //Application.Run(new ChangeAdminPassword());
        }
    }
}
