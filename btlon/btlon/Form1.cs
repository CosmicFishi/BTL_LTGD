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
       
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadUser();
            loadMenu();
            loadSpById(1);
            btnView.BackColor = Color.FromArgb(255, 70, 195, 219);
        }

        void loadMenu(){
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
        void loadSpById(int id) {
            string[] pathPic = Directory.GetFiles(@"C:\Users\Admin\Desktop\BTL_LTGD\btlon\btlon\sanpham\" + id);
            Font fh3 = new Font("Microsoft Sans Serif", 13);

            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(150, 150);
            lvSp.Clear();
            lvSp.LargeImageList = imageList;

            for (int i = 0; i < pathPic.Length; i++)
            {
                string f = pathPic[i]; //f là file name khai báo để dùng cho ngắn gọn
                string productName = f.Substring(0, f.LastIndexOf(@"_")).Substring(1 + f.LastIndexOf(@"\"));
                string price = f.Substring(0, f.LastIndexOf(@".")).Substring(1 + f.LastIndexOf(@"_"))+"000";

                imageList.Images.Add(i.ToString(), Image.FromFile(pathPic[i]));
                lvSp.Items.Add(new ListViewItem() {
                    Text = productName + "    " + price + "Đ", 
                    ImageKey = i.ToString(), Font = fh3 
                });
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (lvSp.View == View.List)
            {
                lvSp.View = View.LargeIcon;
                btnView.Text = "BIG";
            }
            else {
                lvSp.View = View.List;
                btnView.Text = "LIST";
            }
        }

        private void tvMenu_Click(object sender, EventArgs e)
        {
            lbPagination.Text = tvMenu.SelectedNode.FullPath;
            for (int i = 0; i < category.Length; i++)
            {
                if (tvMenu.Nodes[1].Nodes[i] == tvMenu.SelectedNode)
                {
                    loadSpById(i+1);
                }
            }
        }

    }
}
