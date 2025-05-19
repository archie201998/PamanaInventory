namespace ZenBiz
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            btnVerify = new Button();
            label6 = new Label();
            label7 = new Label();
            lblVersion = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(349, 130);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(436, 127);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(274, 29);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(436, 162);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(274, 29);
            txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(349, 170);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(92, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 161);
            label3.Name = "label3";
            label3.Size = new Size(265, 36);
            label3.TabIndex = 5;
            label3.Text = "Pamana Water Corp.";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(55, 66, 81);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-4, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 361);
            panel1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(82, 252);
            label5.Name = "label5";
            label5.Size = new Size(141, 17);
            label5.TabIndex = 7;
            label5.Text = "Short Description Here";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(69, 196);
            label4.Name = "label4";
            label4.Size = new Size(172, 15);
            label4.TabIndex = 6;
            label4.Text = "Inventory Management System";
            // 
            // btnVerify
            // 
            btnVerify.AutoSize = true;
            btnVerify.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerify.Image = (Image)resources.GetObject("btnVerify.Image");
            btnVerify.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerify.Location = new Point(589, 197);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(121, 31);
            btnVerify.TabIndex = 7;
            btnVerify.Text = "Log In";
            btnVerify.UseVisualStyleBackColor = true;
            btnVerify.Click += btnVerify_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(349, 49);
            label6.Name = "label6";
            label6.Size = new Size(59, 23);
            label6.TabIndex = 8;
            label6.Text = "Log In";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(349, 74);
            label7.Name = "label7";
            label7.Size = new Size(163, 15);
            label7.TabIndex = 9;
            label7.Text = "Enter your login details below";
            // 
            // lblVersion
            // 
            lblVersion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblVersion.ForeColor = SystemColors.ControlText;
            lblVersion.Location = new Point(589, 328);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(121, 15);
            lblVersion.TabIndex = 10;
            lblVersion.Text = "Version 1.0.0.0";
            lblVersion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LoginForm
            // 
            AcceptButton = btnVerify;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 352);
            Controls.Add(lblVersion);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnVerify);
            Controls.Add(panel1);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Button btnVerify;
        private Label label6;
        private Label label7;
        private Label lblVersion;
    }
}