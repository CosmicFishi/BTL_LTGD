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
    public partial class Form1 : Form
    {
        string[] h2 = { "Tài khoản", "Loại sản phẩm", "Giới thiệu", "Dịch vụ"};
        string[] category = { "Điện thoại máy tính bảng", "Điện tử điện lạnh","Phụ kiện thiết bị số", "Mẹ và bé"};
        string[] services = {"Dịch vụ đổi trả", "Dịch vụ bảo hành", "Dịch vụ chăm sóc KH"};
      
        struct SanPham {
            public string img;
            public string ten;
            public string gia;
        }

        List<SanPham> dienThoai = new List<SanPham>();
        List<SanPham> dienTu = new List<SanPham>();
        List<SanPham> phuKien = new List<SanPham>();
        List<SanPham> meBe = new List<SanPham>();

        void loadListSp(int id, List<SanPham> arr) {
            string[] pathPic = Directory.GetFiles(Application.StartupPath + @"\" + id);
        
            for (int i = 0; i < pathPic.Length; i++)
            {
                string f = pathPic[i]; //f là file name khai báo để dùng cho ngắn gọn
                SanPham a = new SanPham();
                a.img = f;
                a.ten = f.Substring(0, f.LastIndexOf("_")).Substring(1 + f.LastIndexOf(@"\"));
                a.gia = f.Substring(0, f.LastIndexOf(".")).Substring(1 + f.LastIndexOf("_")) + "000";
                arr.Add(a);
            }
        }
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbGiaSp.Text = " ";
            lbTenSp.Text = " ";
            loadUser();
            loadMenu();
            loadSpByName(dienThoai);
            loadListSp(1, dienThoai);
            loadListSp(2, dienTu);
            loadListSp(3, phuKien);
            loadListSp(4, meBe);
        }

        void loadMenu()
        {
            //hiển thị danh sách các node ở bậc 1 trong treeview
            Font fh2 = new Font("Microsoft Sans Serif", 14);
            foreach(string s in h2)
                tvMenu.Nodes.Add(new TreeNode() { Text = s, NodeFont = fh2});

            //hiển thị danh sách các node ở bậc 2 trong "Loại sản phẩm"
            Font fh3 = new Font("Microsoft Sans Serif", 13);
            foreach(string s in category)
                tvMenu.Nodes[1].Nodes.Add(new TreeNode() { Text = s, NodeFont = fh3 });
            tvMenu.SelectedNode = tvMenu.Nodes[1];
            tvMenu.Nodes[1].Expand();
           
            //hiển thị danh sách các node ở bậc 2 trong "Services"
            foreach (string s in services)
                tvMenu.Nodes[3].Nodes.Add(new TreeNode() { Text = s, NodeFont = fh3 });
        }

        //đổi icon người dùng thành hình tròn.
        void loadUser(){
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, picAvatar.Width, picAvatar.Height);
            picAvatar.Region = new Region(path);
        }

        //load danh sách sản phẩm theo loại sản phẩm.
        void loadSpByName(List<SanPham> arr) {
            Font fh3 = new Font("Microsoft Sans Serif", 13);
            lvSp.Clear();
            ColumnHeader name = new ColumnHeader() { Text = "Hinh anh", Width = 200 };
            ColumnHeader price = new ColumnHeader() { Text = "Gia SP", Width = 100 };
            lvSp.Columns.AddRange(new ColumnHeader[] { name, price });

            ImageList imageList = new ImageList() { ImageSize = new Size(150, 200) };

            lvSp.LargeImageList = imageList;

            for (int i = 0; i < arr.Count; i++)
            {
                imageList.Images.Add(i.ToString(), Image.FromFile(arr[i].img));

                ListViewItem row = new ListViewItem() { Text = arr[i].ten };
                ListViewItem.ListViewSubItem priceSp = new ListViewItem.ListViewSubItem() { Text = arr[i].gia };
                row.SubItems.Add(priceSp);
                row.ImageKey = i.ToString();
                lvSp.Items.Add(row);
            }   

            //for (int i = 0; i < arr.Count; i++ )
            //{
            //    imageList.Images.Add(i.ToString(), Image.FromFile(arr[i].img));

            //    ListViewItem row = new ListViewItem() { Text = "anh 1" };
            //    ListViewItem.ListViewSubItem nameSP = new ListViewItem.ListViewSubItem() { Text = arr[i].ten };
            //    ListViewItem.ListViewSubItem priceSp = new ListViewItem.ListViewSubItem() { Text = arr[i].gia };
            //    row.SubItems.AddRange(new ListViewItem.ListViewSubItem[] {nameSP, priceSp});
            //    row.ImageKey = i.ToString();
                
            //    lvSp.Items.Add(row);
            //}   
        }
       

        private void lvSp_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvSp.SelectedItems.Count == 0)
                pnDetail.Visible = true;
            else {
                pnDetail.Visible = true;
                lbTenSp.Text = lvSp.SelectedItems[0].SubItems[0].Text;
                lbGiaSp.Text = lvSp.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void numberSp_ValueChanged(object sender, EventArgs e)
        {
            if (numberSp.Value == 0) btnAddCart.Enabled = false;
            else btnAddCart.Enabled = true;
        }

        private void tvMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Điện thoại máy tính bảng":
                    loadSpByName(dienThoai);
                    break;
                case "Điện tử điện lạnh":
                    loadSpByName(dienTu);
                    break;
                case "Phụ kiện thiết bị số":
                    loadSpByName(phuKien);
                    break;
                case "Mẹ và bé":
                    loadSpByName(meBe);
                    break;
                default:
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            gioHang1 g = new gioHang1();
            g.Show();
        }

        private void btnAddCart_Click(object sender, EventArgs e){
            if (lvSp.SelectedItems.Count > 0) {
                string text = lvSp.SelectedItems[0].Text;
                MessageBox.Show(text);
            }
        }

    }
}
