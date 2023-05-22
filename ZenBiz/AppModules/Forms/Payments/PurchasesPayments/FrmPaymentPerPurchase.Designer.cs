namespace ZenBiz.AppModules.Forms.Payments
{
    partial class FrmPaymentPerPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaymentPerPurchase));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgPayments = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnAddPayment = new ToolStripButton();
            btnEditPayment = new ToolStripButton();
            btnDeletePayment = new ToolStripButton();
            lblTotalPayments = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            txtBalance = new TextBox();
            label5 = new Label();
            txtTotalAmount = new TextBox();
            label4 = new Label();
            txtSupplier = new TextBox();
            label3 = new Label();
            txtTransactionDate = new TextBox();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPayments).BeginInit();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 187);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 262);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgPayments);
            tabPage1.Controls.Add(toolStrip1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 234);
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
            dgPayments.Size = new Size(759, 200);
            dgPayments.TabIndex = 2;
            dgPayments.SelectionChanged += dgPayments_SelectionChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAddPayment, btnEditPayment, btnDeletePayment, lblTotalPayments, toolStripLabel2 });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(762, 25);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 160);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Purchase Transaction Details";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtBalance);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtTotalAmount);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtSupplier);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtTransactionDate);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 138);
            panel1.TabIndex = 0;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(103, 99);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(650, 23);
            txtBalance.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 102);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 8;
            label5.Text = "Balance";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(103, 70);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(650, 23);
            txtTotalAmount.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 73);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 6;
            label4.Text = "Amount Paid";
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(103, 41);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.ReadOnly = true;
            txtSupplier.Size = new Size(650, 23);
            txtSupplier.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 44);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Supplier";
            // 
            // txtTransactionDate
            // 
            txtTransactionDate.Location = new Point(103, 12);
            txtTransactionDate.Name = "txtTransactionDate";
            txtTransactionDate.ReadOnly = true;
            txtTransactionDate.Size = new Size(650, 23);
            txtTransactionDate.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 15);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Date";
            // 
            // FrmPaymentPerPurchase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 461);
            Controls.Add(groupBox1);
            Controls.Add(tabControl1);
            Name = "FrmPaymentPerPurchase";
            Text = "Payments";
            FormClosed += FrmPaymentPerPurchase_FormClosed;
            Load += FrmPaymentPerPurchase_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgPayments).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgPayments;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAddPayment;
        private ToolStripButton btnEditPayment;
        private ToolStripButton btnDeletePayment;
        private ToolStripLabel lblTotalPayments;
        private ToolStripLabel toolStripLabel2;
        private GroupBox groupBox1;
        private Panel panel1;
        private TextBox textBox1;
        private Label label5;
        private TextBox txtBalance;
        private Label label4;
        private TextBox txtCustomer;
        private Label label3;
        private TextBox txtTransactionDate;
        private Label label2;
        private TextBox txtTransactionNo;
        private Label label1;
        private TextBox txtTotalAmount;
        private TextBox txtSupplier;
    }
}