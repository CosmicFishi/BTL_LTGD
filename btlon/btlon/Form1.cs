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
        private gioHang1 gh = new gioHang1();

        string tenTK = "nope";
        string soDT = "";
        string gioithieu;
        string baohanh;
        string doitra;
        string chamsockh;

        string[] h2 = { "Loại sản phẩm", "Giới thiệu", "Dịch vụ"};
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
       
        //check open forms
        private bool checkFormOpen(String formName) {
            bool open = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc) {
                if (f.Name == formName)
                    open = true;
            }
            return open;
        }

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Form callingForm) {
            gh = callingForm as gioHang1;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load UI
            loadMenu();
            loadSpByName(dienThoai);
            loadListSp(1, dienThoai);
            loadListSp(2, dienTu);
            loadListSp(3, phuKien);
            loadListSp(4, meBe);
            
            //set default
            lbGiaSp.Text = " ";
            lbTenSp.Text = " ";
            gioithieu = getFileContent("gioithieu.txt");
            baohanh = getFileContent("baohanh.txt");
            doitra = getFileContent("doitra.txt");
            chamsockh = getFileContent("chamsockh.txt");
            
            //set UI default
            //tvMenu.SelectedNode = tvMenu.Nodes[0].Nodes[0];
            tvMenu.Nodes[1].Expand();
        }

        public void getProp(string ten, string sdt){
            tenTK = ten;
            soDT = sdt;
            //MessageBox.Show(sdt.ToString());
            if (tenTK == "")
                lbAccount.Text = "Nope Account";
            else lbAccount.Text = tenTK;
        }
        //---------------------Function---------------------
        void loadListSp(int id, List<SanPham> arr)
        {
            string[] pathPic = Directory.GetFiles(Application.StartupPath + @"\" + id);
            //MessageBox.Show(Application.StartupPath);

            for (int i = 0; i < pathPic.Length; i++)
            {
                //MessageBox.Show(pathPic[i].ToString());
                string f = pathPic[i];
                SanPham a = new SanPham();
                a.img = f;
                a.ten = f.Substring(0, f.LastIndexOf("_")).Substring(1 + f.LastIndexOf(@"\"));
                a.gia = f.Substring(0, f.LastIndexOf(".")).Substring(1 + f.LastIndexOf("_")) +"000";
                arr.Add(a);
            }
        }

        string getFileContent(string fileName) {
            string path = Application.StartupPath+@"\"+fileName;
            return File.ReadAllText(path);
        }

        void loadMenu()
        {
            Font fh2 = new Font("Microsoft Sans Serif", 14);
            Font fh3 = new Font("Microsoft Sans Serif", 13);

            //hiển thị danh sách các node ở bậc 1 trong treeview
            foreach(string s in h2)
                tvMenu.Nodes.Add(new TreeNode() { Text = s, NodeFont = fh2});

            //hiển thị danh sách các node ở bậc 2 trong "Loại sản phẩm"
            foreach(string s in category)
                tvMenu.Nodes[0].Nodes.Add(new TreeNode() { Text = s, NodeFont = fh3 });
           
            //hiển thị danh sách các node ở bậc 2 trong "Services"
            foreach (string s in services)
                tvMenu.Nodes[2].Nodes.Add(new TreeNode() { Text = s, NodeFont = fh3 });
        }

        //load danh sách sản phẩm theo loại sản phẩm.
        void loadSpByName(List<SanPham> arr) {

            Font fh3 = new Font("Microsoft Sans Serif", 13);
            
            lvSp.Clear();
            lvSp.Visible = true;
            txtContent.Visible = false;
            pnDetail.Visible = true;

            ColumnHeader name = new ColumnHeader() { Text = "Hinh anh", Width = 200 };
            ColumnHeader price = new ColumnHeader() { Text = "Gia SP", Width = 100 };
            ImageList imageList = new ImageList() { ImageSize = new Size(150, 200) };

            lvSp.Columns.AddRange(new ColumnHeader[] { name, price });
            lvSp.LargeImageList = imageList;

            for (int i = 0; i < arr.Count; i++)
            {
                imageList.Images.Add(i.ToString(), Image.FromFile(arr[i].img));
                //MessageBox.Show(arr[i].img);
                

                ListViewItem row = new ListViewItem() { Text = arr[i].ten };
                ListViewItem.ListViewSubItem priceSp = new ListViewItem.ListViewSubItem() { Text = arr[i].gia };
                row.SubItems.Add(priceSp);
                row.ImageKey = i.ToString();
                //MessageBox.Show(row.ImageKey);
                lvSp.Items.Add(row);
            }   
        }

        void loadContent(string s)
        {
            lvSp.Visible = false;
            pnDetail.Visible = false;
            txtContent.Visible = true;
            txtContent.Text = s;
        }


        //-----------------Event----------------------------
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

        //event value changed of numbericUpDown to show/hidden btn addToCart
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
                case "Giới thiệu":
                    loadContent(gioithieu);
                    break;
                case "Dịch vụ bảo hành":
                    loadContent(baohanh);
                    break;
                case "Dịch vụ chăm sóc KH":
                    loadContent(chamsockh);
                    break;
                case "Dịch vụ đổi trả":
                    loadContent(doitra);
                    break;
                default:
                    break;
            }
        }
        
        //click btn gio hang
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            gh.TenTK = lbAccount.Text;
            gh.SDT = soDT.ToString();
            gh.ShowDialog();
        }

        private void btnAddCart_Click(object sender, EventArgs e){
            if (lvSp.SelectedItems.Count > 0) {
                
                string ten = lvSp.SelectedItems[0].SubItems[0].Text;
                string gia = lvSp.SelectedItems[0].SubItems[1].Text;
                string sl = numberSp.Value.ToString();
                string TG = (int.Parse(gia) * int.Parse(sl)).ToString();

                string[] s = new string[] {ten,sl,gia,TG};

                gh.taoDongTTHangHoa(s);
                lbThem.Visible = true;

                //MessageBox.Show("Đã thêm", "Thêm sản phẩm");
            }
        }

        //change list view
        private void button1_Click(object sender, EventArgs e)
        {
            if (lvSp.View != View.Tile)
            {
                lvSp.View = View.Tile;
                lvSp.TileSize = new Size(700, 200);
                btnChangeView.Text = "TILE";
            }
            else {
                lvSp.View = View.LargeIcon;
                btnChangeView.Text = "BIG";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ban co chac muon dong??", "Dong form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbThem.Visible = false;
        }

        private void lbAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
