namespace ZenBiz.AppModules.Forms.Payments
{
    partial class FrmPaymentsPerSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaymentsPerSale));
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label5 = new Label();
            txtBalance = new TextBox();
            label4 = new Label();
            txtCustomer = new TextBox();
            label3 = new Label();
            txtTransactionDate = new TextBox();
            label2 = new Label();
            txtTransactionNo = new TextBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgPayments = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnAddPayment = new ToolStripButton();
            btnEditPayment = new ToolStripButton();
            btnDeletePayment = new ToolStripButton();
            lblTotalPayments = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPayments).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 190);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sales Transaction Details";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtBalance);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCustomer);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtTransactionDate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTransactionNo);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 168);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 119);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(650, 23);
            textBox1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 122);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 8;
            label5.Text = "Balance";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(97, 90);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(650, 23);
            txtBalance.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 93);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 6;
            label4.Text = "Balance";
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(97, 61);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.ReadOnly = true;
            txtCustomer.Size = new Size(650, 23);
            txtCustomer.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 64);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 4;
            label3.Text = "Customer";
            // 
            // txtTransactionDate
            // 
            txtTransactionDate.Location = new Point(97, 32);
            txtTransactionDate.Name = "txtTransactionDate";
            txtTransactionDate.ReadOnly = true;
            txtTransactionDate.Size = new Size(650, 23);
            txtTransactionDate.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 35);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Date";
            // 
            // txtTransactionNo
            // 
            txtTransactionNo.Location = new Point(97, 3);
            txtTransactionNo.Name = "txtTransactionNo";
            txtTransactionNo.ReadOnly = true;
            txtTransactionNo.Size = new Size(650, 23);
            txtTransactionNo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 6);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Transaction No.";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 208);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(773, 241);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgPayments);
            tabPage1.Controls.Add(toolStrip1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(765, 213);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Payments";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgPayments
            // 
            dgPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPayments.Location = new Point(3, 31);
            dgPayments.Name = "dgPayments";
            dgPayments.RowTemplate.Height = 25;
            dgPayments.Size = new Size(759, 176);
            dgPayments.TabIndex = 2;
            dgPayments.SelectionChanged += dgPayments_SelectionChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAddPayment, btnEditPayment, btnDeletePayment, lblTotalPayments, toolStripLabel2 });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(759, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAddPayment
            // 
            btnAddPayment.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAddPayment.Image = (Image)resources.GetObject("btnAddPayment.Image");
            btnAddPayment.ImageTransparentColor = Color.Magenta;
            btnAddPayment.Name = "btnAddPayment";
            btnAddPayment.Size = new Size(23, 22);
            btnAddPayment.Text = "Add";
            btnAddPayment.Click += btnAddPayment_Click;
            // 
            // btnEditPayment
            // 
            btnEditPayment.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditPayment.Image = (Image)resources.GetObject("btnEditPayment.Image");
            btnEditPayment.ImageTransparentColor = Color.Magenta;
            btnEditPayment.Name = "btnEditPayment";
            btnEditPayment.Size = new Size(23, 22);
            btnEditPayment.Text = "Edit";
            btnEditPayment.Click += btnEditPayment_Click;
            // 
            // btnDeletePayment
            // 
            btnDeletePayment.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDeletePayment.Image = (Image)resources.GetObject("btnDeletePayment.Image");
            btnDeletePayment.ImageTransparentColor = Color.Magenta;
            btnDeletePayment.Name = "btnDeletePayment";
            btnDeletePayment.Size = new Size(23, 22);
            btnDeletePayment.Text = "Delete";
            btnDeletePayment.Click += btnDeletePayment_Click;
            // 
            // lblTotalPayments
            // 
            lblTotalPayments.Alignment = ToolStripItemAlignment.Right;
            lblTotalPayments.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPayments.Name = "lblTotalPayments";
            lblTotalPayments.Size = new Size(31, 22);
            lblTotalPayments.Text = "0.00";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(35, 22);
            toolStripLabel2.Text = "Total:";
            // 
            // FrmPaymentsPerSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 461);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            Name = "FrmPaymentsPerSale";
            Text = "Payments";
            FormClosed += FrmPaymentsPerSale_FormClosed;
            Load += FrmPaymentsPerSale_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgPayments).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Panel panel1;
        private TextBox txtCustomer;
        private Label label3;
        private TextBox txtTransactionDate;
        private Label label2;
        private TextBox txtTransactionNo;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgPayments;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAddPayment;
        private ToolStripButton btnEditPayment;
        private ToolStripButton btnDeletePayment;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripLabel lblTotalPayments;
        private TextBox txtBalance;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
    }
}