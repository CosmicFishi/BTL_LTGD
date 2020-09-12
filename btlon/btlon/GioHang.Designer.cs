namespace btlon
{
    partial class gioHang1
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
            this.TTKH = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbSoTK = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colPicture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbTongTien = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TTKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TTKH
            // 
            this.TTKH.Controls.Add(this.pictureBox1);
            this.TTKH.Controls.Add(this.lbSoTK);
            this.TTKH.Controls.Add(this.lbTen);
            this.TTKH.Location = new System.Drawing.Point(14, 8);
            this.TTKH.Name = "TTKH";
            this.TTKH.Size = new System.Drawing.Size(522, 102);
            this.TTKH.TabIndex = 0;
            this.TTKH.TabStop = false;
            this.TTKH.Text = "Thông tin khách hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 72);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbSoTK
            // 
            this.lbSoTK.AutoSize = true;
            this.lbSoTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTK.Location = new System.Drawing.Point(209, 61);
            this.lbSoTK.Name = "lbSoTK";
            this.lbSoTK.Size = new System.Drawing.Size(91, 17);
            this.lbSoTK.TabIndex = 0;
            this.lbSoTK.Text = "Số tài khoản:";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(209, 30);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(37, 17);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "Tên:";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(390, 445);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(146, 36);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPicture,
            this.colName,
            this.colAmount,
            this.colPrice});
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(15, 121);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(521, 311);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
            this.listView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView1_ItemChecked);
            // 
            // colPicture
            // 
            this.colPicture.Text = "Picture";
            this.colPicture.Width = 154;
            // 
            // colName
            // 
            this.colName.Text = "Tên";
            this.colName.Width = 136;
            // 
            // colAmount
            // 
            this.colAmount.Text = "Số lượng";
            this.colAmount.Width = 71;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Giá";
            this.colPrice.Width = 125;
            // 
            // lbTongTien
            // 
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(110, 446);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(189, 32);
            this.lbTongTien.TabIndex = 4;
            this.lbTongTien.Text = ".";
            this.lbTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tổng tiền:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gioHang1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(548, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.TTKH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "gioHang1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GioHang";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GioHang_Load);
            this.TTKH.ResumeLayout(false);
            this.TTKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TTKH;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbSoTK;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colPicture;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colAmount;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}