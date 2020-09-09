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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lvSp = new System.Windows.Forms.ListView();
            this.btnView = new System.Windows.Forms.Button();
            this.lbPagination = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnDetail = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTenSp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbGiaSp = new System.Windows.Forms.Label();
            this.numberSp = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberSp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(108)))), ((int)(((byte)(223)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tvMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.MinimumSize = new System.Drawing.Size(300, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 794);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 708);
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
            this.tvMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(108)))), ((int)(((byte)(223)))));
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
            this.tvMenu.Click += new System.EventHandler(this.tvMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(108)))), ((int)(((byte)(223)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.picAvatar);
            this.panel2.Location = new System.Drawing.Point(301, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 69);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::btlon.Properties.Resources._34627;
            this.pictureBox1.Location = new System.Drawing.Point(653, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // picAvatar
            // 
            this.picAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAvatar.Image = global::btlon.Properties.Resources.OIP2MCJIFZB;
            this.picAvatar.InitialImage = null;
            this.picAvatar.Location = new System.Drawing.Point(725, 12);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(53, 50);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // lvSp
            // 
            this.lvSp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(195)))), ((int)(((byte)(219)))));
            this.lvSp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSp.FullRowSelect = true;
            this.lvSp.Location = new System.Drawing.Point(308, 144);
            this.lvSp.Name = "lvSp";
            this.lvSp.Size = new System.Drawing.Size(779, 560);
            this.lvSp.TabIndex = 5;
            this.lvSp.TileSize = new System.Drawing.Size(500, 100);
            this.lvSp.UseCompatibleStateImageBehavior = false;
            this.lvSp.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvSp_ItemSelectionChanged);
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.Location = new System.Drawing.Point(1028, 83);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(50, 45);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "LIST";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbPagination
            // 
            this.lbPagination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPagination.Location = new System.Drawing.Point(317, 91);
            this.lbPagination.Name = "lbPagination";
            this.lbPagination.Size = new System.Drawing.Size(240, 23);
            this.lbPagination.TabIndex = 7;
            this.lbPagination.Text = "Home";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thông tin chi tiết:";
            // 
            // pnDetail
            // 
            this.pnDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDetail.Controls.Add(this.label5);
            this.pnDetail.Controls.Add(this.btnAddCart);
            this.pnDetail.Controls.Add(this.label8);
            this.pnDetail.Controls.Add(this.numberSp);
            this.pnDetail.Controls.Add(this.lbGiaSp);
            this.pnDetail.Controls.Add(this.label6);
            this.pnDetail.Controls.Add(this.lbTenSp);
            this.pnDetail.Controls.Add(this.label3);
            this.pnDetail.Controls.Add(this.label2);
            this.pnDetail.Location = new System.Drawing.Point(301, 710);
            this.pnDetail.Name = "pnDetail";
            this.pnDetail.Size = new System.Drawing.Size(799, 83);
            this.pnDetail.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên sp:";
            // 
            // lbTenSp
            // 
            this.lbTenSp.AutoSize = true;
            this.lbTenSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSp.Location = new System.Drawing.Point(258, 18);
            this.lbTenSp.Name = "lbTenSp";
            this.lbTenSp.Size = new System.Drawing.Size(0, 18);
            this.lbTenSp.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(195, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Giá sp:";
            // 
            // lbGiaSp
            // 
            this.lbGiaSp.AutoSize = true;
            this.lbGiaSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaSp.Location = new System.Drawing.Point(258, 49);
            this.lbGiaSp.Name = "lbGiaSp";
            this.lbGiaSp.Size = new System.Drawing.Size(0, 18);
            this.lbGiaSp.TabIndex = 12;
            // 
            // numberSp
            // 
            this.numberSp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numberSp.Location = new System.Drawing.Point(478, 16);
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
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(392, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Số lượng:";
            // 
            // btnAddCart
            // 
            this.btnAddCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCart.Location = new System.Drawing.Point(395, 43);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(203, 31);
            this.btnAddCart.TabIndex = 15;
            this.btnAddCart.Text = "Thêm vào giỏ";
            this.btnAddCart.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(793, 5);
            this.label5.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(195)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1101, 794);
            this.Controls.Add(this.pnDetail);
            this.Controls.Add(this.lbPagination);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lvSp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnDetail.ResumeLayout(false);
            this.pnDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberSp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tvMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.ListView lvSp;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbPagination;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnDetail;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numberSp;
        private System.Windows.Forms.Label lbGiaSp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTenSp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

