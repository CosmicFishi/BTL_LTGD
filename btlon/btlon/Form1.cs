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
        string[] category = { "Đồ điện", "Quần áo", "Áo khoác"};
        string[] services = {"Dịch vụ đổi trả", "Dịch vụ bảo hành", "Dịch vụ chăm sóc KH"};

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadUser();
            loadMenu();
            loadSp();
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

            //hiển thị danh sách các node ở bậc 2 trong "Services"
            foreach (string s in services)
                tvMenu.Nodes[3].Nodes.Add(new TreeNode() { Text = s, NodeFont = fh3 });
        }
      
        void loadUser(){
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, picAvatar.Width, picAvatar.Height);
            picAvatar.Region = new Region(path);
        }

        void loadSp() { 
            string[] pathPic = Directory.GetFiles(@"C:\Users\Admin\Desktop\BTL_LTGD\btlon\btlon\sanpham");
            Font fh3 = new Font("Microsoft Sans Serif", 13);

            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(150, 150);
            lvSp.LargeImageList = imageList;

            for (int i = 0; i < pathPic.Length; i++)
            {
                imageList.Images.Add(i.ToString(), Image.FromFile(pathPic[i]));
                lvSp.Items.Add(new ListViewItem() { Text = "SP thứ "+i.ToString()+" 300k", ImageKey = i.ToString(), Font = fh3});
            }
            
        }
        private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {

            lbPagination.Text = tvMenu.SelectedNode.FullPath;
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
    }
}
