namespace ZenBiz.AppModules.Forms.Sales
{
    partial class UcSalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcSalesForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgItems = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnAddItem = new ToolStripButton();
            btnEditItem = new ToolStripButton();
            btnDeleteItem = new ToolStripButton();
            lblTotalItemSales = new ToolStripLabel();
            toolStripLabel1 = new ToolStripLabel();
            tabPageServices = new TabPage();
            dgServices = new DataGridView();
            lblTotalServiceFee = new ToolStrip();
            btnAddServices = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            btnDeleteServices = new ToolStripButton();
            lblTotalServicesFee = new ToolStripLabel();
            toolStripLabel3 = new ToolStripLabel();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            btnClear = new Button();
            btnSearchCustomer = new Button();
            txtCustomerContactInfo = new TextBox();
            label5 = new Label();
            txtCustomerAddress = new TextBox();
            label4 = new Label();
            txtCustomerName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dtpTransactionDate = new DateTimePicker();
            txtTransactionNo = new TextBox();
            label1 = new Label();
            epCustomer = new ErrorProvider(components);
            groupBoxPayments = new GroupBox();
            panel2 = new Panel();
            dtpDatePaid = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            cmbPaymentType = new ComboBox();
            label7 = new Label();
            nudAmountPaid = new NumericUpDown();
            txtRefCode = new TextBox();
            label6 = new Label();
            chkPayment = new CheckBox();
            label10 = new Label();
            lblTotalSales = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgItems).BeginInit();
            toolStrip1.SuspendLayout();
            tabPageServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgServices).BeginInit();
            lblTotalServiceFee.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epCustomer).BeginInit();
            groupBoxPayments.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmountPaid).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPageServices);
            tabControl1.Location = new Point(3, 213);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(809, 173);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgItems);
            tabPage1.Controls.Add(toolStrip1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(801, 145);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Items";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgItems
            // 
            dgItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgItems.Dock = DockStyle.Fill;
            dgItems.Location = new Point(3, 28);
            dgItems.Name = "dgItems";
            dgItems.RowTemplate.Height = 25;
            dgItems.Size = new Size(795, 114);
            dgItems.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAddItem, btnEditItem, btnDeleteItem, lblTotalItemSales, toolStripLabel1 });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(795, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAddItem
            // 
            btnAddItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAddItem.Image = (Image)resources.GetObject("btnAddItem.Image");
            btnAddItem.ImageTransparentColor = Color.Magenta;
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(23, 22);
            btnAddItem.Text = "Add";
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnEditItem
            // 
            btnEditItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditItem.Image = (Image)resources.GetObject("btnEditItem.Image");
            btnEditItem.ImageTransparentColor = Color.Magenta;
            btnEditItem.Name = "btnEditItem";
            btnEditItem.Size = new Size(23, 22);
            btnEditItem.Text = "Edit";
            btnEditItem.Visible = false;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDeleteItem.Image = (Image)resources.GetObject("btnDeleteItem.Image");
            btnDeleteItem.ImageTransparentColor = Color.Magenta;
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(23, 22);
            btnDeleteItem.Text = "Delete";
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // lblTotalItemSales
            // 
            lblTotalItemSales.Alignment = ToolStripItemAlignment.Right;
            lblTotalItemSales.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalItemSales.Name = "lblTotalItemSales";
            lblTotalItemSales.Size = new Size(31, 22);
            lblTotalItemSales.Text = "0.00";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(114, 22);
            toolStripLabel1.Text = "Total Items Amount:";
            // 
            // tabPageServices
            // 
            tabPageServices.Controls.Add(dgServices);
            tabPageServices.Controls.Add(lblTotalServiceFee);
            tabPageServices.Location = new Point(4, 24);
            tabPageServices.Name = "tabPageServices";
            tabPageServices.Padding = new Padding(3);
            tabPageServices.Size = new Size(801, 145);
            tabPageServices.TabIndex = 1;
            tabPageServices.Text = "Services";
            tabPageServices.UseVisualStyleBackColor = true;
            // 
            // dgServices
            // 
            dgServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgServices.Dock = DockStyle.Fill;
            dgServices.Location = new Point(3, 28);
            dgServices.Name = "dgServices";
            dgServices.RowTemplate.Height = 25;
            dgServices.Size = new Size(795, 114);
            dgServices.TabIndex = 3;
            // 
            // lblTotalServiceFee
            // 
            lblTotalServiceFee.GripStyle = ToolStripGripStyle.Hidden;
            lblTotalServiceFee.Items.AddRange(new ToolStripItem[] { btnAddServices, toolStripButton2, btnDeleteServices, lblTotalServicesFee, toolStripLabel3 });
            lblTotalServiceFee.Location = new Point(3, 3);
            lblTotalServiceFee.Name = "lblTotalServiceFee";
            lblTotalServiceFee.Size = new Size(795, 25);
            lblTotalServiceFee.TabIndex = 2;
            lblTotalServiceFee.Text = "toolStrip2";
            // 
            // btnAddServices
            // 
            btnAddServices.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAddServices.Image = (Image)resources.GetObject("btnAddServices.Image");
            btnAddServices.ImageTransparentColor = Color.Magenta;
            btnAddServices.Name = "btnAddServices";
            btnAddServices.Size = new Size(23, 22);
            btnAddServices.Text = "Add";
            btnAddServices.Click += btnAddServices_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "Edit";
            toolStripButton2.Visible = false;
            // 
            // btnDeleteServices
            // 
            btnDeleteServices.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDeleteServices.Image = (Image)resources.GetObject("btnDeleteServices.Image");
            btnDeleteServices.ImageTransparentColor = Color.Magenta;
            btnDeleteServices.Name = "btnDeleteServices";
            btnDeleteServices.Size = new Size(23, 22);
            btnDeleteServices.Text = "Delete";
            btnDeleteServices.Click += btnDeleteServices_Click;
            // 
            // lblTotalServicesFee
            // 
            lblTotalServicesFee.Alignment = ToolStripItemAlignment.Right;
            lblTotalServicesFee.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalServicesFee.Name = "lblTotalServicesFee";
            lblTotalServicesFee.Size = new Size(31, 22);
            lblTotalServicesFee.Text = "0.00";
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(101, 22);
            toolStripLabel3.Text = "Total Services Fee:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(805, 148);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnSearchCustomer);
            panel1.Controls.Add(txtCustomerContactInfo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtCustomerAddress);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCustomerName);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 126);
            panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(700, 90);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.Location = new Point(619, 90);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(75, 23);
            btnSearchCustomer.TabIndex = 3;
            btnSearchCustomer.Text = "Search...";
            btnSearchCustomer.UseVisualStyleBackColor = true;
            btnSearchCustomer.Click += btnSearchCustomer_Click;
            // 
            // txtCustomerContactInfo
            // 
            txtCustomerContactInfo.Location = new Point(110, 61);
            txtCustomerContactInfo.Name = "txtCustomerContactInfo";
            txtCustomerContactInfo.ReadOnly = true;
            txtCustomerContactInfo.Size = new Size(665, 23);
            txtCustomerContactInfo.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 64);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 6;
            label5.Text = "Contact Info";
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.Location = new Point(110, 32);
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.ReadOnly = true;
            txtCustomerAddress.Size = new Size(665, 23);
            txtCustomerAddress.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 35);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 4;
            label4.Text = "Address";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(110, 3);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(665, 23);
            txtCustomerName.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 6);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 38);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 27;
            label2.Text = "Date";
            // 
            // dtpTransactionDate
            // 
            dtpTransactionDate.Location = new Point(116, 32);
            dtpTransactionDate.Name = "dtpTransactionDate";
            dtpTransactionDate.Size = new Size(689, 23);
            dtpTransactionDate.TabIndex = 1;
            // 
            // txtTransactionNo
            // 
            txtTransactionNo.Location = new Point(116, 3);
            txtTransactionNo.Name = "txtTransactionNo";
            txtTransactionNo.ReadOnly = true;
            txtTransactionNo.Size = new Size(689, 23);
            txtTransactionNo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 24;
            label1.Text = "Transaction No.";
            // 
            // epCustomer
            // 
            epCustomer.ContainerControl = this;
            // 
            // groupBoxPayments
            // 
            groupBoxPayments.Controls.Add(panel2);
            groupBoxPayments.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxPayments.Location = new Point(3, 410);
            groupBoxPayments.Name = "groupBoxPayments";
            groupBoxPayments.Size = new Size(805, 146);
            groupBoxPayments.TabIndex = 29;
            groupBoxPayments.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtpDatePaid);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(cmbPaymentType);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(nudAmountPaid);
            panel2.Controls.Add(txtRefCode);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(3, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(799, 124);
            panel2.TabIndex = 0;
            // 
            // dtpDatePaid
            // 
            dtpDatePaid.Location = new Point(110, 90);
            dtpDatePaid.Name = "dtpDatePaid";
            dtpDatePaid.Size = new Size(665, 23);
            dtpDatePaid.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(4, 89);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 7;
            label9.Text = "Date Paid";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 6);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 5;
            label8.Text = "Payment Type";
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Location = new Point(110, 3);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(665, 23);
            cmbPaymentType.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 60);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 3;
            label7.Text = "Amount";
            // 
            // nudAmountPaid
            // 
            nudAmountPaid.DecimalPlaces = 2;
            nudAmountPaid.Location = new Point(110, 61);
            nudAmountPaid.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudAmountPaid.Name = "nudAmountPaid";
            nudAmountPaid.Size = new Size(665, 23);
            nudAmountPaid.TabIndex = 2;
            // 
            // txtRefCode
            // 
            txtRefCode.Location = new Point(110, 32);
            txtRefCode.MaxLength = 45;
            txtRefCode.Name = "txtRefCode";
            txtRefCode.Size = new Size(665, 23);
            txtRefCode.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 32);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 0;
            label6.Text = "Reference Code";
            // 
            // chkPayment
            // 
            chkPayment.AutoSize = true;
            chkPayment.BackColor = Color.Transparent;
            chkPayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chkPayment.Location = new Point(4, 399);
            chkPayment.Name = "chkPayment";
            chkPayment.Size = new Size(75, 19);
            chkPayment.TabIndex = 1;
            chkPayment.Text = "Payment";
            chkPayment.UseVisualStyleBackColor = false;
            chkPayment.CheckedChanged += chkPayment_CheckedChanged;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(665, 388);
            label10.Name = "label10";
            label10.Size = new Size(64, 15);
            label10.TabIndex = 6;
            label10.Text = "Total Sales:";
            label10.Click += label10_Click;
            // 
            // lblTotalSales
            // 
            lblTotalSales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalSales.BackColor = SystemColors.Control;
            lblTotalSales.BorderStyle = BorderStyle.None;
            lblTotalSales.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalSales.Location = new Point(727, 388);
            lblTotalSales.MaxLength = 45;
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(78, 16);
            lblTotalSales.TabIndex = 1;
            lblTotalSales.Text = "0.00";
            lblTotalSales.TextAlign = HorizontalAlignment.Right;
            lblTotalSales.TextChanged += lblTotalSales_TextChanged;
            // 
            // UcSalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chkPayment);
            Controls.Add(lblTotalSales);
            Controls.Add(label10);
            Controls.Add(groupBoxPayments);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(dtpTransactionDate);
            Controls.Add(txtTransactionNo);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "UcSalesForm";
            Size = new Size(820, 583);
            Load += UcSalesForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgItems).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabPageServices.ResumeLayout(false);
            tabPageServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgServices).EndInit();
            lblTotalServiceFee.ResumeLayout(false);
            lblTotalServiceFee.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epCustomer).EndInit();
            groupBoxPayments.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmountPaid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAddItem;
        private ToolStripButton btnEditItem;
        private ToolStripButton btnDeleteItem;
        private GroupBox groupBox1;
        private Panel panel1;
        private Button btnSearchCustomer;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        internal DataGridView dgItems;
        private ErrorProvider epCustomer;
        internal DateTimePicker dtpTransactionDate;
        internal TextBox txtTransactionNo;
        private ToolStripLabel lblTotalItemSales;
        private ToolStripLabel toolStripLabel1;
        internal TextBox txtCustomerContactInfo;
        internal TextBox txtCustomerAddress;
        internal TextBox txtCustomerName;
        private Button btnClear;
        private Panel panel2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        internal GroupBox groupBoxPayments;
        internal DateTimePicker dtpDatePaid;
        internal ComboBox cmbPaymentType;
        internal NumericUpDown nudAmountPaid;
        internal TextBox txtRefCode;
        internal CheckBox chkPayment;
        private TabPage tabPageServices;
        private ToolStrip lblTotalServiceFee;
        private ToolStripButton btnAddServices;
        private ToolStripButton toolStripButton2;
        private ToolStripButton btnDeleteServices;
        private ToolStripLabel lblTotalServicesFee;
        private ToolStripLabel toolStripLabel3;
        internal DataGridView dgServices;
        private Label label10;
        internal TextBox lblTotalSales;
    }
}
