namespace ZenBiz.AppModules.Forms.Purchases
{
    partial class UcPurchaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcPurchaseForm));
            label2 = new Label();
            dtpDatePurchase = new DateTimePicker();
            gbxSupplier = new GroupBox();
            panel1 = new Panel();
            btnClear = new Button();
            btnSearchSuppliers = new Button();
            txtSupplierContactInfo = new TextBox();
            label5 = new Label();
            txtSupplierAddress = new TextBox();
            label4 = new Label();
            txtSupplierName = new TextBox();
            label3 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgItems = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnAddItem = new ToolStripButton();
            btnEditItem = new ToolStripButton();
            btnDeleteItem = new ToolStripButton();
            lblTotalSales = new ToolStripLabel();
            toolStripLabel1 = new ToolStripLabel();
            chkPayment = new CheckBox();
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
            gbxSupplier.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgItems).BeginInit();
            toolStrip1.SuspendLayout();
            groupBoxPayments.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmountPaid).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 15);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 29;
            label2.Text = "Date";
            // 
            // dtpDatePurchase
            // 
            dtpDatePurchase.Location = new Point(119, 11);
            dtpDatePurchase.Name = "dtpDatePurchase";
            dtpDatePurchase.Size = new Size(689, 23);
            dtpDatePurchase.TabIndex = 28;
            // 
            // gbxSupplier
            // 
            gbxSupplier.Controls.Add(panel1);
            gbxSupplier.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbxSupplier.Location = new Point(6, 49);
            gbxSupplier.Name = "gbxSupplier";
            gbxSupplier.Size = new Size(805, 144);
            gbxSupplier.TabIndex = 30;
            gbxSupplier.TabStop = false;
            gbxSupplier.Text = "Supplier";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnSearchSuppliers);
            panel1.Controls.Add(txtSupplierContactInfo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtSupplierAddress);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtSupplierName);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 122);
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
            // btnSearchSuppliers
            // 
            btnSearchSuppliers.Location = new Point(619, 90);
            btnSearchSuppliers.Name = "btnSearchSuppliers";
            btnSearchSuppliers.Size = new Size(75, 23);
            btnSearchSuppliers.TabIndex = 3;
            btnSearchSuppliers.Text = "Search...";
            btnSearchSuppliers.UseVisualStyleBackColor = true;
            btnSearchSuppliers.Click += btnSearchSuppliers_Click;
            // 
            // txtSupplierContactInfo
            // 
            txtSupplierContactInfo.Location = new Point(110, 61);
            txtSupplierContactInfo.Name = "txtSupplierContactInfo";
            txtSupplierContactInfo.ReadOnly = true;
            txtSupplierContactInfo.Size = new Size(665, 23);
            txtSupplierContactInfo.TabIndex = 2;
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
            // txtSupplierAddress
            // 
            txtSupplierAddress.Location = new Point(110, 32);
            txtSupplierAddress.Name = "txtSupplierAddress";
            txtSupplierAddress.ReadOnly = true;
            txtSupplierAddress.Size = new Size(665, 23);
            txtSupplierAddress.TabIndex = 1;
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
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(110, 3);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.ReadOnly = true;
            txtSupplierName.Size = new Size(665, 23);
            txtSupplierName.TabIndex = 0;
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(6, 206);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(806, 173);
            tabControl1.TabIndex = 31;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgItems);
            tabPage1.Controls.Add(toolStrip1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(798, 145);
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
            dgItems.Size = new Size(792, 114);
            dgItems.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAddItem, btnEditItem, btnDeleteItem, lblTotalSales, toolStripLabel1 });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(792, 25);
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
            // 
            // lblTotalSales
            // 
            lblTotalSales.Alignment = ToolStripItemAlignment.Right;
            lblTotalSales.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(31, 22);
            lblTotalSales.Text = "0.00";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(35, 22);
            toolStripLabel1.Text = "Total:";
            // 
            // chkPayment
            // 
            chkPayment.AutoSize = true;
            chkPayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chkPayment.Location = new Point(9, 394);
            chkPayment.Name = "chkPayment";
            chkPayment.Size = new Size(75, 19);
            chkPayment.TabIndex = 32;
            chkPayment.Text = "Payment";
            chkPayment.UseVisualStyleBackColor = true;
            chkPayment.CheckedChanged += chkPayment_CheckedChanged;
            // 
            // groupBoxPayments
            // 
            groupBoxPayments.Controls.Add(panel2);
            groupBoxPayments.Enabled = false;
            groupBoxPayments.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxPayments.Location = new Point(6, 411);
            groupBoxPayments.Name = "groupBoxPayments";
            groupBoxPayments.Size = new Size(805, 146);
            groupBoxPayments.TabIndex = 33;
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
            // UcPurchaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chkPayment);
            Controls.Add(groupBoxPayments);
            Controls.Add(tabControl1);
            Controls.Add(gbxSupplier);
            Controls.Add(label2);
            Controls.Add(dtpDatePurchase);
            Name = "UcPurchaseForm";
            Size = new Size(820, 583);
            Load += UcPurchaseForm_Load;
            gbxSupplier.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgItems).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBoxPayments.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmountPaid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        internal DateTimePicker dtpDatePurchase;
        private GroupBox gbxSupplier;
        private Panel panel1;
        private Button btnClear;
        private Button btnSearchSuppliers;
        internal TextBox txtSupplierContactInfo;
        private Label label5;
        internal TextBox txtSupplierAddress;
        private Label label4;
        internal TextBox txtSupplierName;
        private Label label3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        internal DataGridView dgItems;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAddItem;
        private ToolStripButton btnEditItem;
        private ToolStripButton btnDeleteItem;
        private ToolStripLabel lblTotalSales;
        private ToolStripLabel toolStripLabel1;
        internal CheckBox chkPayment;
        internal GroupBox groupBoxPayments;
        private Panel panel2;
        internal DateTimePicker dtpDatePaid;
        private Label label9;
        private Label label8;
        internal ComboBox cmbPaymentType;
        private Label label7;
        internal NumericUpDown nudAmountPaid;
        internal TextBox txtRefCode;
        private Label label6;
    }
}
