using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace btlon
{
    public partial class gioHang1 : Form
    {
        ImageList IL = new ImageList() { ImageSize = new Size(50, 50) };

        String tenTK;
        String soDT;

        public gioHang1()
        {
            InitializeComponent();
        }

        public String TenTK {
            get { return tenTK; }
            set { tenTK = value; }
        }
        public String SDT {
            get { return soDT; }
            set { soDT = value; }
        }

        public void taoDongTTHangHoa(String[] TT) {
            ImageList IL = new ImageList();
            IL.ImageSize = new Size(1, 20);
            listView1.SmallImageList = IL;
            ListViewItem lvi = new ListViewItem(TT);
            listView1.Items.Add(lvi);
        }

        private void tinhTongTien() {
            //Tính tiền
            int tongTien = 0;
            if (listView1.Items.Count > 0) {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    // đi từ item  -> subitem -> text của subitem thứ 3 (giá)
                    tongTien += int.Parse(listView1.Items[i].SubItems[2].Text.ToString()) * int.Parse(listView1.Items[i].SubItems[1].Text.ToString());
                }
            }

                lbTongTien.Text = " " + tongTien.ToString();
        }

        private void GioHang_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("running");
            lbTen.Text += tenTK;
            lbSoTK.Text += soDT;
            tinhTongTien();

            //MessageBox.Show(listView1.Items[1].SubItems[3].Text.ToString());
            
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
