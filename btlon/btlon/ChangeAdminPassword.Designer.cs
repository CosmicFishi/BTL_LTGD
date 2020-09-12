namespace btlon
{
    partial class ChangeAdminPassword
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
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(181, 87);
            this.textBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(234, 30);
            this.textBoxConfirmPassword.TabIndex = 0;
            this.textBoxConfirmPassword.TextChanged += new System.EventHandler(this.textBoxConfirmPassword_TextChanged);
            this.textBoxConfirmPassword.Leave += new System.EventHandler(this.textBoxConfirmPassword_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(181, 34);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(234, 30);
            this.textBoxPassword.TabIndex = 0;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(12, 53);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(90, 22);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirm Password";
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(16, 146);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(157, 26);
            this.checkBoxShowPassword.TabIndex = 2;
            this.checkBoxShowPassword.Text = "Show Password";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(193, 174);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(122, 32);
            this.buttonConfirm.TabIndex = 3;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // ChangeAdminPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 218);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ChangeAdminPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeAdminPassword";
            this.Load += new System.EventHandler(this.ChangeAdminPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Button buttonConfirm;
    }
}