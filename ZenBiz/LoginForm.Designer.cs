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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(399, 209);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(498, 205);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(313, 34);
            txtUsername.TabIndex = 1;
            txtUsername.Text = "archie";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(498, 252);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(313, 34);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "123123123";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(399, 263);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(105, 49);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(34, 215);
            label3.Name = "label3";
            label3.Size = new Size(339, 45);
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
            panel1.Location = new Point(-5, -3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 461);
            panel1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(105, 417);
            label5.Name = "label5";
            label5.Size = new Size(165, 23);
            label5.TabIndex = 7;
            label5.Text = "TEST VERSION - 001";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(79, 261);
            label4.Name = "label4";
            label4.Size = new Size(213, 20);
            label4.TabIndex = 6;
            label4.Text = "Inventory Management System";
            // 
            // btnVerify
            // 
            btnVerify.AutoSize = true;
            btnVerify.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerify.Image = (Image)resources.GetObject("btnVerify.Image");
            btnVerify.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerify.Location = new Point(673, 299);
            btnVerify.Margin = new Padding(3, 4, 3, 4);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(138, 41);
            btnVerify.TabIndex = 7;
            btnVerify.Text = "Log In";
            btnVerify.UseVisualStyleBackColor = true;
            btnVerify.Click += btnVerify_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(399, 126);
            label6.Name = "label6";
            label6.Size = new Size(76, 29);
            label6.TabIndex = 8;
            label6.Text = "Log In";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(399, 135);
            label7.Name = "label7";
            label7.Size = new Size(207, 20);
            label7.TabIndex = 9;
            label7.Text = "Enter your login details below";
            // 
            // LoginForm
            // 
            AcceptButton = btnVerify;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 449);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnVerify);
            Controls.Add(panel1);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}