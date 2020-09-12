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
    public partial class gioHang1 : Form
    {
        String[,] ttGioHang = {{"hình", "tên", "Số lượng", "9"}, {"4","5", "6", "7"}};
        String soTK;
        String tenTK;

        public gioHang1()
        {
            InitializeComponent();
        }

        public String TenTK
        {
            get { return tenTK; }
            set { tenTK = value; }
        }
        public String SoTK {
            get { return soTK; }
            set { soTK = value; }
        }

        public String[,] setTTGioHang {
            set { ttGioHang = value; }
        }

        private void taoDongTTHangHoa(String[,] TT) {

            for (int i = 0; i < TT.GetLength(0); i++ )
            {
                string[] row = { TT[i, 0], TT[i, 1], TT[i, 2], TT[i,3] };
                ListViewItem lvi = new ListViewItem(row);
                lvi.Checked = true;
                listView1.Items.Add(lvi);
            }
            //gb.Controls.Add();
        }

        private void tinhTongTien() {
            //Tính tiền
            int tongTien = 0;
            for (int i = 0; i < listView1.Items.Count; i++) {
                if (listView1.Items[i].Checked == true) {
                    // đi từ item  -> subitem -> text của subitem thứ 4 (giá)
                    tongTien += int.Parse(listView1.Items[i].SubItems[3].Text.ToString());
                    //MessageBox.Show(listView1.Items[i].SubItems[1].Text.ToString());
                }
            }

                lbTongTien.Text = " " + tongTien.ToString();
        }

        private void GioHang_Load(object sender, EventArgs e)
        {
            lbTen.Text += tenTK;
            lbSoTK.Text += soTK;
            taoDongTTHangHoa(ttGioHang);
            tinhTongTien();

            //MessageBox.Show(listView1.Items[1].SubItems[3].Text.ToString());
            
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            tinhTongTien();
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
        }
    }
}
