namespace ZenBiz
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnSales = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            btnPurchases = new ToolStripButton();
            btnServices = new ToolStripButton();
            btnInventory = new ToolStripButton();
            btnCustomers = new ToolStripButton();
            btnPersonnel = new ToolStripButton();
            btnUsers = new ToolStripButton();
            btnLoggedInUser = new ToolStripDropDownButton();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            btnReport = new ToolStripButton();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            btnRetrieve = new Button();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            lblProductCount = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lblGrossSales = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            panel6 = new Panel();
            pictureBox6 = new PictureBox();
            label13 = new Label();
            lblCustomerCount = new Label();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            label11 = new Label();
            lblCollectibles = new Label();
            dgTopSellingProducts = new DataGridView();
            dgSalesHistory = new DataGridView();
            label8 = new Label();
            dgPayingCustomers = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel8 = new Panel();
            label7 = new Label();
            panel3 = new Panel();
            panel7 = new Panel();
            label15 = new Label();
            toolStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgTopSellingProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgSalesHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgPayingCustomers).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // btnSales
            // 
            btnSales.Image = (Image)resources.GetObject("btnSales.Image");
            btnSales.ImageScaling = ToolStripItemImageScaling.None;
            btnSales.ImageTransparentColor = Color.Magenta;
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(61, 28);
            btnSales.Text = "Sales";
            btnSales.Visible = false;
            btnSales.Click += btnSales_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnSales, btnPurchases, btnServices, btnInventory, btnCustomers, btnPersonnel, btnUsers, btnLoggedInUser, btnReport });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 5, 1, 5);
            toolStrip1.Size = new Size(1270, 41);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnPurchases
            // 
            btnPurchases.Image = (Image)resources.GetObject("btnPurchases.Image");
            btnPurchases.ImageScaling = ToolStripItemImageScaling.None;
            btnPurchases.ImageTransparentColor = Color.Magenta;
            btnPurchases.Name = "btnPurchases";
            btnPurchases.Size = new Size(88, 28);
            btnPurchases.Text = "Purchases";
            btnPurchases.Visible = false;
            btnPurchases.Click += btnPurchases_Click;
            // 
            // btnServices
            // 
            btnServices.Image = (Image)resources.GetObject("btnServices.Image");
            btnServices.ImageScaling = ToolStripItemImageScaling.None;
            btnServices.ImageTransparentColor = Color.Magenta;
            btnServices.Name = "btnServices";
            btnServices.Size = new Size(77, 28);
            btnServices.Text = "Services";
            btnServices.Visible = false;
            // 
            // btnInventory
            // 
            btnInventory.Image = (Image)resources.GetObject("btnInventory.Image");
            btnInventory.ImageScaling = ToolStripItemImageScaling.None;
            btnInventory.ImageTransparentColor = Color.Magenta;
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(85, 28);
            btnInventory.Text = "Inventory";
            btnInventory.Click += btnInventory_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.Image = (Image)resources.GetObject("btnCustomers.Image");
            btnCustomers.ImageScaling = ToolStripItemImageScaling.None;
            btnCustomers.ImageTransparentColor = Color.Magenta;
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(92, 28);
            btnCustomers.Text = "Customers";
            btnCustomers.Visible = false;
            // 
            // btnPersonnel
            // 
            btnPersonnel.Image = (Image)resources.GetObject("btnPersonnel.Image");
            btnPersonnel.ImageScaling = ToolStripItemImageScaling.None;
            btnPersonnel.ImageTransparentColor = Color.Magenta;
            btnPersonnel.Name = "btnPersonnel";
            btnPersonnel.Size = new Size(87, 28);
            btnPersonnel.Text = "Personnel";
            btnPersonnel.Visible = false;
            btnPersonnel.Click += btnPersonnel_Click;
            // 
            // btnUsers
            // 
            btnUsers.Image = (Image)resources.GetObject("btnUsers.Image");
            btnUsers.ImageScaling = ToolStripItemImageScaling.None;
            btnUsers.ImageTransparentColor = Color.Magenta;
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(63, 28);
            btnUsers.Text = "Users";
            btnUsers.Visible = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnLoggedInUser
            // 
            btnLoggedInUser.Alignment = ToolStripItemAlignment.Right;
            btnLoggedInUser.DropDownItems.AddRange(new ToolStripItem[] { changePasswordToolStripMenuItem, logOutToolStripMenuItem });
            btnLoggedInUser.Image = (Image)resources.GetObject("btnLoggedInUser.Image");
            btnLoggedInUser.ImageTransparentColor = Color.Magenta;
            btnLoggedInUser.Name = "btnLoggedInUser";
            btnLoggedInUser.Size = new Size(59, 28);
            btnLoggedInUser.Text = "User";
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(177, 22);
            changePasswordToolStripMenuItem.Text = "Change Password...";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(177, 22);
            logOutToolStripMenuItem.Text = "Log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // btnReport
            // 
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.ImageScaling = ToolStripItemImageScaling.None;
            btnReport.ImageTransparentColor = Color.Magenta;
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(75, 28);
            btnReport.Text = "Reports";
            btnReport.Click += btnReport_Click;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(54, 50);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(200, 23);
            dtpFrom.TabIndex = 4;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(292, 50);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(200, 23);
            dtpTo.TabIndex = 5;
            // 
            // btnRetrieve
            // 
            btnRetrieve.Location = new Point(498, 50);
            btnRetrieve.Name = "btnRetrieve";
            btnRetrieve.Size = new Size(75, 23);
            btnRetrieve.TabIndex = 6;
            btnRetrieve.Text = "Retrieve";
            btnRetrieve.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 54);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 7;
            label5.Text = "From";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(267, 54);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 8;
            label6.Text = "To";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblProductCount);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(7, 7);
            panel2.Margin = new Padding(7);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 116);
            panel2.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(20, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(50, 68);
            label3.Name = "label3";
            label3.Size = new Size(39, 17);
            label3.TabIndex = 1;
            label3.Text = "Items";
            // 
            // lblProductCount
            // 
            lblProductCount.AutoSize = true;
            lblProductCount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductCount.Location = new Point(50, 28);
            lblProductCount.Name = "lblProductCount";
            lblProductCount.Size = new Size(40, 32);
            lblProductCount.TabIndex = 0;
            lblProductCount.Text = "54";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblGrossSales);
            panel1.Location = new Point(754, 7);
            panel1.Margin = new Padding(7);
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 116);
            panel1.TabIndex = 0;
            panel1.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(50, 68);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 1;
            label2.Text = "Gross sales";
            // 
            // lblGrossSales
            // 
            lblGrossSales.AutoSize = true;
            lblGrossSales.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblGrossSales.Location = new Point(50, 28);
            lblGrossSales.Name = "lblGrossSales";
            lblGrossSales.Size = new Size(72, 32);
            lblGrossSales.TabIndex = 0;
            lblGrossSales.Text = "₱0.00";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Controls.Add(panel6, 4, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 3, 0);
            tableLayoutPanel1.Controls.Add(panel5, 2, 0);
            tableLayoutPanel1.Location = new Point(12, 76);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1246, 130);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(256, 7);
            panel4.Margin = new Padding(7);
            panel4.Name = "panel4";
            panel4.Size = new Size(235, 116);
            panel4.TabIndex = 11;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(20, 39);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(50, 68);
            label9.Name = "label9";
            label9.Size = new Size(101, 17);
            label9.TabIndex = 1;
            label9.Text = "Low Stock Items";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(50, 28);
            label10.Name = "label10";
            label10.Size = new Size(27, 32);
            label10.TabIndex = 0;
            label10.Text = "0";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(pictureBox6);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(lblCustomerCount);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(1003, 7);
            panel6.Margin = new Padding(7);
            panel6.Name = "panel6";
            panel6.Size = new Size(236, 116);
            panel6.TabIndex = 11;
            panel6.Visible = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(20, 39);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(24, 24);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ControlDarkDark;
            label13.Location = new Point(50, 68);
            label13.Name = "label13";
            label13.Size = new Size(70, 17);
            label13.TabIndex = 1;
            label13.Text = "Customers";
            // 
            // lblCustomerCount
            // 
            lblCustomerCount.AutoSize = true;
            lblCustomerCount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerCount.Location = new Point(50, 28);
            lblCustomerCount.Name = "lblCustomerCount";
            lblCustomerCount.Size = new Size(27, 32);
            lblCustomerCount.TabIndex = 0;
            lblCustomerCount.Text = "9";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(lblCollectibles);
            panel5.Location = new Point(505, 7);
            panel5.Margin = new Padding(7);
            panel5.Name = "panel5";
            panel5.Size = new Size(235, 116);
            panel5.TabIndex = 11;
            panel5.Visible = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(20, 39);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(50, 68);
            label11.Name = "label11";
            label11.Size = new Size(74, 17);
            label11.TabIndex = 1;
            label11.Text = "Collectibles";
            // 
            // lblCollectibles
            // 
            lblCollectibles.AutoSize = true;
            lblCollectibles.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblCollectibles.Location = new Point(50, 28);
            lblCollectibles.Name = "lblCollectibles";
            lblCollectibles.Size = new Size(72, 32);
            lblCollectibles.TabIndex = 0;
            lblCollectibles.Text = "₱0.00";
            // 
            // dgTopSellingProducts
            // 
            dgTopSellingProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgTopSellingProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTopSellingProducts.Location = new Point(3, 18);
            dgTopSellingProducts.Name = "dgTopSellingProducts";
            dgTopSellingProducts.RowTemplate.Height = 25;
            dgTopSellingProducts.Size = new Size(403, 335);
            dgTopSellingProducts.TabIndex = 9;
            // 
            // dgSalesHistory
            // 
            dgSalesHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgSalesHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSalesHistory.Location = new Point(3, 18);
            dgSalesHistory.Name = "dgSalesHistory";
            dgSalesHistory.RowTemplate.Height = 25;
            dgSalesHistory.Size = new Size(403, 335);
            dgSalesHistory.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 12;
            label8.Text = "Sales History";
            // 
            // dgPayingCustomers
            // 
            dgPayingCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgPayingCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPayingCustomers.Location = new Point(3, 18);
            dgPayingCustomers.Name = "dgPayingCustomers";
            dgPayingCustomers.RowTemplate.Height = 25;
            dgPayingCustomers.Size = new Size(404, 335);
            dgPayingCustomers.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(panel8, 0, 0);
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Controls.Add(panel7, 1, 0);
            tableLayoutPanel2.Location = new Point(12, 212);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1246, 362);
            tableLayoutPanel2.TabIndex = 15;
            tableLayoutPanel2.Visible = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(label7);
            panel8.Controls.Add(dgTopSellingProducts);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(418, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(409, 356);
            panel8.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(115, 15);
            label7.TabIndex = 10;
            label7.Text = "Top Selling Products";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgSalesHistory);
            panel3.Controls.Add(label8);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(409, 356);
            panel3.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(label15);
            panel7.Controls.Add(dgPayingCustomers);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(833, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(410, 356);
            panel7.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 0);
            label15.Name = "label15";
            label15.Size = new Size(126, 15);
            label15.TabIndex = 14;
            label15.Text = "Top Paying Customers";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 611);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnRetrieve);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(toolStrip1);
            MinimumSize = new Size(1000, 650);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pamana Inventory";
            WindowState = FormWindowState.Maximized;
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgTopSellingProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgSalesHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgPayingCustomers).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripButton btnSales;
        private ToolStrip toolStrip1;
        private ToolStripButton btnInventory;
        private ToolStripButton btnPurchases;
        private ToolStripButton btnCustomers;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Button btnRetrieve;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label3;
        private Label lblProductCount;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lblGrossSales;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Label label9;
        private Label label10;
        private Panel panel5;
        private PictureBox pictureBox5;
        private Label label11;
        private Label lblCollectibles;
        private Panel panel6;
        private PictureBox pictureBox6;
        private Label label13;
        private Label lblCustomerCount;
        private DataGridView dgTopSellingProducts;
        private DataGridView dgSalesHistory;
        private Label label8;
        private DataGridView dgPayingCustomers;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Panel panel7;
        private Panel panel8;
        private Label label7;
        private Label label15;
        private ToolStripButton btnUsers;
        private ToolStripDropDownButton btnLoggedInUser;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripButton btnReport;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripButton btnPersonnel;
        private ToolStripButton btnServices;
    }
}