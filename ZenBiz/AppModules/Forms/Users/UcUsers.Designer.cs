namespace ZenBiz.AppModules.Forms.Users
{
    partial class UcUsers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label2 = new Label();
            cmbRoles = new ComboBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            txtConfirmPassword = new TextBox();
            label6 = new Label();
            epFirstName = new ErrorProvider(components);
            epLastName = new ErrorProvider(components);
            epUsername = new ErrorProvider(components);
            epPassword = new ErrorProvider(components);
            epConfirmPassword = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)epFirstName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epLastName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epConfirmPassword).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 6);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(112, 3);
            txtFirstName.MaxLength = 99;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(300, 23);
            txtFirstName.TabIndex = 0;
            txtFirstName.Validating += txtFirstName_Validating;
            txtFirstName.Validated += txtFirstName_Validated;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(112, 32);
            txtLastName.MaxLength = 99;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(300, 23);
            txtLastName.TabIndex = 1;
            txtLastName.Validating += txtLastName_Validating;
            txtLastName.Validated += txtLastName_Validated;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 35);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // cmbRoles
            // 
            cmbRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(112, 75);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(300, 23);
            cmbRoles.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 78);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 5;
            label3.Text = "Role";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(112, 104);
            txtUsername.MaxLength = 45;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 23);
            txtUsername.TabIndex = 3;
            txtUsername.Validating += txtUsername_Validating;
            txtUsername.Validated += txtUsername_Validated;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 107);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 6;
            label4.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(112, 133);
            txtPassword.MaxLength = 60;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(300, 23);
            txtPassword.TabIndex = 4;
            txtPassword.Validating += txtPassword_Validating;
            txtPassword.Validated += txtPassword_Validated;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 136);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(112, 162);
            txtConfirmPassword.MaxLength = 60;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.Size = new Size(300, 23);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating;
            txtConfirmPassword.Validated += txtConfirmPassword_Validated;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 165);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 10;
            label6.Text = "Confirm Password";
            // 
            // epFirstName
            // 
            epFirstName.ContainerControl = this;
            // 
            // epLastName
            // 
            epLastName.ContainerControl = this;
            // 
            // epUsername
            // 
            epUsername.ContainerControl = this;
            // 
            // epPassword
            // 
            epPassword.ContainerControl = this;
            // 
            // epConfirmPassword
            // 
            epConfirmPassword.ContainerControl = this;
            // 
            // UcUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtConfirmPassword);
            Controls.Add(label6);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbRoles);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Name = "UcUsers";
            Size = new Size(442, 199);
            Load += UcUsers_Load;
            ((System.ComponentModel.ISupportInitialize)epFirstName).EndInit();
            ((System.ComponentModel.ISupportInitialize)epLastName).EndInit();
            ((System.ComponentModel.ISupportInitialize)epUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)epPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)epConfirmPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ErrorProvider epFirstName;
        private ErrorProvider epLastName;
        private ErrorProvider epUsername;
        private ErrorProvider epPassword;
        private ErrorProvider epConfirmPassword;
        internal TextBox txtFirstName;
        internal TextBox txtLastName;
        internal ComboBox cmbRoles;
        internal TextBox txtUsername;
        internal TextBox txtPassword;
        internal TextBox txtConfirmPassword;
    }
}
