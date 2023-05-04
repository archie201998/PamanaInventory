namespace ZenBiz.AppModules.Forms
{
    partial class FrmChangePassword
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
            label1 = new Label();
            txtCurrentPassword = new TextBox();
            txtNewPassword = new TextBox();
            label2 = new Label();
            txtConfirmNewPassword = new TextBox();
            label3 = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Current Password";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(149, 12);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PasswordChar = '●';
            txtCurrentPassword.Size = new Size(250, 23);
            txtCurrentPassword.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(149, 41);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '●';
            txtNewPassword.Size = new Size(250, 23);
            txtNewPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "New Password";
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.Location = new Point(149, 70);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.PasswordChar = '●';
            txtConfirmNewPassword.Size = new Size(250, 23);
            txtConfirmNewPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 4;
            label3.Text = "Confirm New Password";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(242, 99);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(323, 99);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmChangePassword
            // 
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(426, 134);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(txtConfirmNewPassword);
            Controls.Add(label3);
            Controls.Add(txtNewPassword);
            Controls.Add(label2);
            Controls.Add(txtCurrentPassword);
            Controls.Add(label1);
            Name = "FrmChangePassword";
            Text = "Change Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCurrentPassword;
        private TextBox txtNewPassword;
        private Label label2;
        private TextBox txtConfirmNewPassword;
        private Label label3;
        private Button btnConfirm;
        private Button btnCancel;
    }
}