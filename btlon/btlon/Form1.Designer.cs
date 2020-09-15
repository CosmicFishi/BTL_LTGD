namespace btlon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbAccount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lvSp = new System.Windows.Forms.ListView();
            this.lbPagination = new System.Windows.Forms.Label();
            this.pnDetail = new System.Windows.Forms.Panel();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numberSp = new System.Windows.Forms.NumericUpDown();
            this.lbGiaSp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTenSp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangeView = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.lbThem = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberSp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tvMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.MinimumSize = new System.Drawing.Size(300, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 757);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 671);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hostline: 00003333";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-2, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 52);
            this.label4.TabIndex = 1;
            this.label4.Text = "Danh mục";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tvMenu
            // 
            this.tvMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvMenu.BackColor = System.Drawing.Color.Gray;
            this.tvMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.tvMenu.ForeColor = System.Drawing.Color.White;
            this.tvMenu.FullRowSelect = true;
            this.tvMenu.Indent = 18;
            this.tvMenu.ItemHeight = 30;
            this.tvMenu.LineColor = System.Drawing.Color.White;
            this.tvMenu.Location = new System.Drawing.Point(16, 98);
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.Scrollable = false;
            this.tvMenu.ShowLines = false;
            this.tvMenu.Size = new System.Drawing.Size(265, 578);
            this.tvMenu.TabIndex = 0;
            this.tvMenu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvMenu_NodeMouseClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbAccount);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(301, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 69);
            this.panel2.TabIndex = 4;
            // 
            // lbAccount
            // 
            this.lbAccount.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.lbAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccount.Location = new System.Drawing.Point(648, 23);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(158, 24);
            this.lbAccount.TabIndex = 2;
            this.lbAccount.Text = "ADMIN";
            this.lbAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbAccount.Click += new System.EventHandler(this.lbAccount_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::btlon.Properties.Resources._34627;
            this.pictureBox1.Location = new System.Drawing.Point(833, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lvSp
            // 
            this.lvSp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSp.BackColor = System.Drawing.Color.White;
            this.lvSp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSp.FullRowSelect = true;
            this.lvSp.HideSelection = false;
            this.lvSp.Location = new System.Drawing.Point(301, 144);
            this.lvSp.Name = "lvSp";
            this.lvSp.Size = new System.Drawing.Size(891, 492);
            this.lvSp.TabIndex = 5;
            this.lvSp.TileSize = new System.Drawing.Size(500, 200);
            this.lvSp.UseCompatibleStateImageBehavior = false;
            this.lvSp.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvSp_ItemSelectionChanged);
            // 
            // lbPagination
            // 
            this.lbPagination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPagination.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPagination.Location = new System.Drawing.Point(573, 72);
            this.lbPagination.Name = "lbPagination";
            this.lbPagination.Size = new System.Drawing.Size(401, 31);
            this.lbPagination.TabIndex = 7;
            this.lbPagination.Text = "Welcome ";
            this.lbPagination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnDetail
            // 
            this.pnDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnDetail.Controls.Add(this.btnAddCart);
            this.pnDetail.Controls.Add(this.label8);
            this.pnDetail.Controls.Add(this.numberSp);
            this.pnDetail.Controls.Add(this.lbGiaSp);
            this.pnDetail.Controls.Add(this.label6);
            this.pnDetail.Controls.Add(this.lbTenSp);
            this.pnDetail.Controls.Add(this.label3);
            this.pnDetail.Controls.Add(this.label2);
            this.pnDetail.Location = new System.Drawing.Point(301, 642);
            this.pnDetail.Name = "pnDetail";
            this.pnDetail.Size = new System.Drawing.Size(895, 114);
            this.pnDetail.TabIndex = 9;
            // 
            // btnAddCart
            // 
            this.btnAddCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCart.Location = new System.Drawing.Point(466, 71);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(203, 31);
            this.btnAddCart.TabIndex = 15;
            this.btnAddCart.Text = "Thêm vào giỏ";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(470, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Số lượng:";
            // 
            // numberSp
            // 
            this.numberSp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numberSp.Location = new System.Drawing.Point(549, 44);
            this.numberSp.Name = "numberSp";
            this.numberSp.Size = new System.Drawing.Size(120, 23);
            this.numberSp.TabIndex = 13;
            this.numberSp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberSp.ValueChanged += new System.EventHandler(this.numberSp_ValueChanged);
            // 
            // lbGiaSp
            // 
            this.lbGiaSp.AutoSize = true;
            this.lbGiaSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaSp.Location = new System.Drawing.Point(249, 81);
            this.lbGiaSp.Name = "lbGiaSp";
            this.lbGiaSp.Size = new System.Drawing.Size(32, 18);
            this.lbGiaSp.TabIndex = 12;
            this.lbGiaSp.Text = "test";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(189, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Giá sp:";
            // 
            // lbTenSp
            // 
            this.lbTenSp.AutoSize = true;
            this.lbTenSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSp.Location = new System.Drawing.Point(250, 50);
            this.lbTenSp.Name = "lbTenSp";
            this.lbTenSp.Size = new System.Drawing.Size(32, 18);
            this.lbTenSp.TabIndex = 10;
            this.lbTenSp.Text = "test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên sp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thông tin chi tiết:";
            // 
            // btnChangeView
            // 
            this.btnChangeView.Location = new System.Drawing.Point(1134, 75);
            this.btnChangeView.Name = "btnChangeView";
            this.btnChangeView.Size = new System.Drawing.Size(50, 49);
            this.btnChangeView.TabIndex = 10;
            this.btnChangeView.Text = "VIEW";
            this.btnChangeView.UseVisualStyleBackColor = true;
            this.btnChangeView.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.Location = new System.Drawing.Point(329, 166);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtContent.Size = new System.Drawing.Size(844, 456);
            this.txtContent.TabIndex = 11;
            // 
            // lbThem
            // 
            this.lbThem.BackColor = System.Drawing.Color.LightCoral;
            this.lbThem.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbThem.Location = new System.Drawing.Point(1043, 140);
            this.lbThem.Name = "lbThem";
            this.lbThem.Size = new System.Drawing.Size(130, 23);
            this.lbThem.TabIndex = 12;
            this.lbThem.Text = "Thêm thành công";
            this.lbThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbThem.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1196, 757);
            this.Controls.Add(this.lbThem);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnChangeView);
            this.Controls.Add(this.pnDetail);
            this.Controls.Add(this.lbPagination);
            this.Controls.Add(this.lvSp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnDetail.ResumeLayout(false);
            this.pnDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberSp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tvMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvSp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbPagination;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnDetail;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numberSp;
        private System.Windows.Forms.Label lbGiaSp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTenSp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChangeView;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.Label lbThem;
        private System.Windows.Forms.Timer timer1;
    }
}

