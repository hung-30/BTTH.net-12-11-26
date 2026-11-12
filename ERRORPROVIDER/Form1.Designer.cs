namespace ERRORPROVIDER
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblUsername = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            lblBirthDate = new Label();
            lblGender = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            dtpBirthDate = new DateTimePicker();
            radMale = new RadioButton();
            radFemale = new RadioButton();
            chkTerms = new CheckBox();
            btnRegister = new Button();
            btnReset = new Button();
            epCheck = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)epCheck).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(40, 50);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(110, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Tên đăng nhập:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(40, 100);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Mật khẩu:";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(40, 150);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(137, 20);
            lblConfirmPassword.TabIndex = 4;
            lblConfirmPassword.Text = "Xác nhận mật khẩu:";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(40, 200);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(77, 20);
            lblBirthDate.TabIndex = 6;
            lblBirthDate.Text = "Ngày sinh:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(40, 250);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(68, 20);
            lblGender.TabIndex = 8;
            lblGender.Text = "Giới tính:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(180, 46);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(180, 96);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(180, 146);
            txtConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(200, 27);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(180, 194);
            dtpBirthDate.Margin = new Padding(3, 4, 3, 4);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(200, 27);
            dtpBirthDate.TabIndex = 7;
            // 
            // radMale
            // 
            radMale.AutoSize = true;
            radMale.Checked = true;
            radMale.Location = new Point(180, 248);
            radMale.Margin = new Padding(3, 4, 3, 4);
            radMale.Name = "radMale";
            radMale.Size = new Size(62, 24);
            radMale.TabIndex = 9;
            radMale.TabStop = true;
            radMale.Text = "Nam";
            radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            radFemale.AutoSize = true;
            radFemale.Location = new Point(260, 248);
            radFemale.Margin = new Padding(3, 4, 3, 4);
            radFemale.Name = "radFemale";
            radFemale.Size = new Size(50, 24);
            radFemale.TabIndex = 10;
            radFemale.Text = "Nữ";
            radFemale.UseVisualStyleBackColor = true;
            // 
            // chkTerms
            // 
            chkTerms.AutoSize = true;
            chkTerms.Location = new Point(180, 300);
            chkTerms.Margin = new Padding(3, 4, 3, 4);
            chkTerms.Name = "chkTerms";
            chkTerms.Size = new Size(207, 24);
            chkTerms.TabIndex = 11;
            chkTerms.Text = "Đồng ý điều khoản dịch vụ";
            chkTerms.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(180, 350);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(90, 44);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Đăng Ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(290, 350);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(90, 44);
            btnReset.TabIndex = 13;
            btnReset.Text = "Làm Mới";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // epCheck
            // 
            epCheck.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 450);
            Controls.Add(btnReset);
            Controls.Add(btnRegister);
            Controls.Add(chkTerms);
            Controls.Add(radFemale);
            Controls.Add(radMale);
            Controls.Add(lblGender);
            Controls.Add(dtpBirthDate);
            Controls.Add(lblBirthDate);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Đăng Ký";
            ((System.ComponentModel.ISupportInitialize)epCheck).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblGender;

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;

        private System.Windows.Forms.DateTimePicker dtpBirthDate;

        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;

        private System.Windows.Forms.CheckBox chkTerms;

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnReset;

        private System.Windows.Forms.ErrorProvider epCheck;
    }
}