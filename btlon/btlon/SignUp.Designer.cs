namespace btlon
{
    partial class SignUp
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
            this.btTaoTaiKhoan = new System.Windows.Forms.Button();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.comboBoxNam = new System.Windows.Forms.ComboBox();
            this.comboBoxThang = new System.Windows.Forms.ComboBox();
            this.comboBoxNgay = new System.Windows.Forms.ComboBox();
            this.radioButtonNu = new System.Windows.Forms.RadioButton();
            this.radioButtonNam = new System.Windows.Forms.RadioButton();
            this.txtbCfPassword = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.txtbSĐT = new System.Windows.Forms.TextBox();
            this.txtbHoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSĐT = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // btTaoTaiKhoan
            // 
            this.btTaoTaiKhoan.BackColor = System.Drawing.Color.Gold;
            this.btTaoTaiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btTaoTaiKhoan.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTaoTaiKhoan.ForeColor = System.Drawing.Color.Olive;
            this.btTaoTaiKhoan.Location = new System.Drawing.Point(76, 407);
            this.btTaoTaiKhoan.Name = "btTaoTaiKhoan";
            this.btTaoTaiKhoan.Size = new System.Drawing.Size(248, 31);
            this.btTaoTaiKhoan.TabIndex = 27;
            this.btTaoTaiKhoan.Text = "Tạo Tài Khoản";
            this.btTaoTaiKhoan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btTaoTaiKhoan.UseVisualStyleBackColor = false;
            this.btTaoTaiKhoan.Click += new System.EventHandler(this.btTaoTaiKhoan_Click);
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBoxShowPassword.Location = new System.Drawing.Point(11, 378);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(130, 23);
            this.checkBoxShowPassword.TabIndex = 26;
            this.checkBoxShowPassword.Text = "Hiện Mật Khẩu";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // comboBoxNam
            // 
            this.comboBoxNam.DisplayMember = "1";
            this.comboBoxNam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxNam.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxNam.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxNam.FormattingEnabled = true;
            this.comboBoxNam.IntegralHeight = false;
            this.comboBoxNam.Location = new System.Drawing.Point(313, 325);
            this.comboBoxNam.Name = "comboBoxNam";
            this.comboBoxNam.Size = new System.Drawing.Size(83, 25);
            this.comboBoxNam.TabIndex = 25;
            this.comboBoxNam.Text = "Năm";
            this.comboBoxNam.SelectedIndexChanged += new System.EventHandler(this.comboBoxNam_SelectedIndexChanged);
            // 
            // comboBoxThang
            // 
            this.comboBoxThang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxThang.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxThang.FormattingEnabled = true;
            this.comboBoxThang.IntegralHeight = false;
            this.comboBoxThang.Location = new System.Drawing.Point(224, 325);
            this.comboBoxThang.Name = "comboBoxThang";
            this.comboBoxThang.Size = new System.Drawing.Size(83, 25);
            this.comboBoxThang.TabIndex = 24;
            this.comboBoxThang.Text = "Tháng";
            this.comboBoxThang.SelectedIndexChanged += new System.EventHandler(this.comboBoxThang_SelectedIndexChanged);
            // 
            // comboBoxNgay
            // 
            this.comboBoxNgay.DisplayMember = "12";
            this.comboBoxNgay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxNgay.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxNgay.FormattingEnabled = true;
            this.comboBoxNgay.IntegralHeight = false;
            this.comboBoxNgay.Location = new System.Drawing.Point(135, 325);
            this.comboBoxNgay.Name = "comboBoxNgay";
            this.comboBoxNgay.Size = new System.Drawing.Size(83, 25);
            this.comboBoxNgay.TabIndex = 23;
            this.comboBoxNgay.Text = "Ngày";
            this.comboBoxNgay.ValueMember = "none";
            this.comboBoxNgay.SelectedIndexChanged += new System.EventHandler(this.comboBoxNgay_SelectedIndexChanged);
            // 
            // radioButtonNu
            // 
            this.radioButtonNu.AutoSize = true;
            this.radioButtonNu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButtonNu.Location = new System.Drawing.Point(251, 287);
            this.radioButtonNu.Name = "radioButtonNu";
            this.radioButtonNu.Size = new System.Drawing.Size(48, 23);
            this.radioButtonNu.TabIndex = 22;
            this.radioButtonNu.TabStop = true;
            this.radioButtonNu.Text = "Nữ";
            this.radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // radioButtonNam
            // 
            this.radioButtonNam.AutoSize = true;
            this.radioButtonNam.Checked = true;
            this.radioButtonNam.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButtonNam.Location = new System.Drawing.Point(146, 287);
            this.radioButtonNam.Name = "radioButtonNam";
            this.radioButtonNam.Size = new System.Drawing.Size(55, 21);
            this.radioButtonNam.TabIndex = 21;
            this.radioButtonNam.TabStop = true;
            this.radioButtonNam.Text = "Nam";
            this.radioButtonNam.UseVisualStyleBackColor = true;
            this.radioButtonNam.CheckedChanged += new System.EventHandler(this.radioButtonNam_CheckedChanged);
            // 
            // txtbCfPassword
            // 
            this.txtbCfPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCfPassword.Location = new System.Drawing.Point(148, 237);
            this.txtbCfPassword.Name = "txtbCfPassword";
            this.txtbCfPassword.Size = new System.Drawing.Size(248, 26);
            this.txtbCfPassword.TabIndex = 19;
            this.txtbCfPassword.Enter += new System.EventHandler(this.txtbCfPassword_Enter);
            this.txtbCfPassword.Leave += new System.EventHandler(this.txtbCfPassword_Leave);
            // 
            // txtbPassword
            // 
            this.txtbPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPassword.Location = new System.Drawing.Point(148, 192);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(248, 26);
            this.txtbPassword.TabIndex = 20;
            this.txtbPassword.Enter += new System.EventHandler(this.txtbPassword_Enter);
            this.txtbPassword.Leave += new System.EventHandler(this.txtbPassword_Leave);
            // 
            // txtbEmail
            // 
            this.txtbEmail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEmail.Location = new System.Drawing.Point(148, 151);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(248, 26);
            this.txtbEmail.TabIndex = 18;
            this.txtbEmail.Enter += new System.EventHandler(this.txtbEmail_Enter);
            this.txtbEmail.Leave += new System.EventHandler(this.txtbEmail_Leave);
            // 
            // txtbSĐT
            // 
            this.txtbSĐT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSĐT.Location = new System.Drawing.Point(148, 117);
            this.txtbSĐT.Name = "txtbSĐT";
            this.txtbSĐT.Size = new System.Drawing.Size(248, 26);
            this.txtbSĐT.TabIndex = 17;
            this.txtbSĐT.Enter += new System.EventHandler(this.txtbSĐT_Enter);
            this.txtbSĐT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbSĐT_KeyPress);
            this.txtbSĐT.Leave += new System.EventHandler(this.txtbSĐT_Leave);
            // 
            // txtbHoTen
            // 
            this.txtbHoTen.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbHoTen.Location = new System.Drawing.Point(148, 79);
            this.txtbHoTen.Name = "txtbHoTen";
            this.txtbHoTen.Size = new System.Drawing.Size(248, 26);
            this.txtbHoTen.TabIndex = 16;
            this.txtbHoTen.TextChanged += new System.EventHandler(this.txtbHoTen_TextChanged);
            this.txtbHoTen.Enter += new System.EventHandler(this.txtbHoTen_Enter);
            this.txtbHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbHoTen_KeyPress);
            this.txtbHoTen.Leave += new System.EventHandler(this.txtbHoTen_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(8, 328);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ngày Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(8, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nhập lại Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(8, 287);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(8, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(8, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email";
            // 
            // lbSĐT
            // 
            this.lbSĐT.AutoSize = true;
            this.lbSĐT.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSĐT.Location = new System.Drawing.Point(8, 120);
            this.lbSĐT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSĐT.Name = "lbSĐT";
            this.lbSĐT.Size = new System.Drawing.Size(37, 17);
            this.lbSĐT.TabIndex = 9;
            this.lbSĐT.Text = "SĐT";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHoTen.Location = new System.Drawing.Point(8, 79);
            this.lbHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(57, 17);
            this.lbHoTen.TabIndex = 15;
            this.lbHoTen.Text = "Họ Tên";
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTitle.Location = new System.Drawing.Point(111, 16);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(187, 34);
            this.lbTitle.TabIndex = 8;
            this.lbTitle.Text = "Tạo Tài Khoản";
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.CalendarFont = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePickerNgaySinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(132, 356);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(166, 20);
            this.dateTimePickerNgaySinh.TabIndex = 28;
            this.dateTimePickerNgaySinh.TabStop = false;
            this.dateTimePickerNgaySinh.Value = new System.DateTime(2020, 9, 12, 10, 3, 17, 0);
            this.dateTimePickerNgaySinh.ValueChanged += new System.EventHandler(this.dateTimePickerNgaySinh_ValueChanged);
            this.dateTimePickerNgaySinh.Enter += new System.EventHandler(this.dateTimePickerNgaySinh_Enter);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.dateTimePickerNgaySinh);
            this.Controls.Add(this.btTaoTaiKhoan);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.comboBoxNam);
            this.Controls.Add(this.comboBoxThang);
            this.Controls.Add(this.comboBoxNgay);
            this.Controls.Add(this.radioButtonNu);
            this.Controls.Add(this.radioButtonNam);
            this.Controls.Add(this.txtbCfPassword);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.txtbSĐT);
            this.Controls.Add(this.txtbHoTen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSĐT);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.lbTitle);
            this.MaximizeBox = false;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTaoTaiKhoan;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.ComboBox comboBoxNam;
        private System.Windows.Forms.ComboBox comboBoxThang;
        private System.Windows.Forms.ComboBox comboBoxNgay;
        private System.Windows.Forms.RadioButton radioButtonNu;
        private System.Windows.Forms.RadioButton radioButtonNam;
        private System.Windows.Forms.TextBox txtbCfPassword;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.TextBox txtbSĐT;
        private System.Windows.Forms.TextBox txtbHoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSĐT;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.ErrorProvider error;
    }
}