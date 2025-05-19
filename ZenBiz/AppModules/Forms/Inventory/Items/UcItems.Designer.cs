namespace ZenBiz.AppModules.Inventory.Items
{
    partial class UcItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcItems));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            txtCode = new TextBox();
            cmbCategory = new ComboBox();
            txtName = new TextBox();
            label2 = new Label();
            nudUnitCost = new NumericUpDown();
            lblUnitCost = new Label();
            label7 = new Label();
            nudMinStockThreshold = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            cmbUnit = new ComboBox();
            btnAddCategory = new Button();
            btnAddUnit = new Button();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            dgStoreStocks = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnAddStoreStock = new ToolStripButton();
            btnEditStoreStock = new ToolStripButton();
            btnDeleteStoreStock = new ToolStripButton();
            groupBox2 = new GroupBox();
            panel2 = new Panel();
            dgWarehouseStocks = new DataGridView();
            toolStrip2 = new ToolStrip();
            btnAddWarehouseStock = new ToolStripButton();
            btnEditWarehouseStock = new ToolStripButton();
            btnDeleteWarehouseStock = new ToolStripButton();
            epName = new ErrorProvider(components);
            epCode = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudUnitCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinStockThreshold).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgStoreStocks).BeginInit();
            toolStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgWarehouseStocks).BeginInit();
            toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epCode).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 6);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Code";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(132, 3);
            txtCode.MaxLength = 20;
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(300, 23);
            txtCode.TabIndex = 0;
            txtCode.Validating += txtCode_Validating;
            txtCode.Validated += txtCode_Validated;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(132, 90);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(300, 23);
            cmbCategory.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(132, 32);
            txtName.MaxLength = 99;
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 23);
            txtName.TabIndex = 1;
            txtName.Validating += txtName_Validating;
            txtName.Validated += txtName_Validated;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 35);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // nudUnitCost
            // 
            nudUnitCost.DecimalPlaces = 2;
            nudUnitCost.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudUnitCost.Location = new Point(132, 148);
            nudUnitCost.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudUnitCost.Name = "nudUnitCost";
            nudUnitCost.Size = new Size(300, 23);
            nudUnitCost.TabIndex = 8;
            // 
            // lblUnitCost
            // 
            lblUnitCost.AutoSize = true;
            lblUnitCost.Location = new Point(5, 150);
            lblUnitCost.Name = "lblUnitCost";
            lblUnitCost.Size = new Size(56, 15);
            lblUnitCost.TabIndex = 6;
            lblUnitCost.Text = "Unit Cost";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 63);
            label7.Name = "label7";
            label7.Size = new Size(119, 15);
            label7.TabIndex = 14;
            label7.Text = "Min. Stock Threshold";
            // 
            // nudMinStockThreshold
            // 
            nudMinStockThreshold.DecimalPlaces = 2;
            nudMinStockThreshold.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudMinStockThreshold.Location = new Point(132, 61);
            nudMinStockThreshold.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudMinStockThreshold.Name = "nudMinStockThreshold";
            nudMinStockThreshold.Size = new Size(300, 23);
            nudMinStockThreshold.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 93);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 15;
            label8.Text = "Category";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 122);
            label9.Name = "label9";
            label9.Size = new Size(29, 15);
            label9.TabIndex = 17;
            label9.Text = "Unit";
            // 
            // cmbUnit
            // 
            cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(132, 119);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(300, 23);
            cmbUnit.TabIndex = 7;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Image = (Image)resources.GetObject("btnAddCategory.Image");
            btnAddCategory.Location = new Point(438, 90);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(23, 23);
            btnAddCategory.TabIndex = 18;
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // btnAddUnit
            // 
            btnAddUnit.Image = (Image)resources.GetObject("btnAddUnit.Image");
            btnAddUnit.Location = new Point(438, 119);
            btnAddUnit.Name = "btnAddUnit";
            btnAddUnit.Size = new Size(23, 23);
            btnAddUnit.TabIndex = 19;
            btnAddUnit.UseVisualStyleBackColor = true;
            btnAddUnit.Click += btnAddUnit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(476, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(492, 136);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Store Stocks";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgStoreStocks);
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 114);
            panel1.TabIndex = 21;
            // 
            // dgStoreStocks
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgStoreStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgStoreStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgStoreStocks.DefaultCellStyle = dataGridViewCellStyle2;
            dgStoreStocks.Dock = DockStyle.Fill;
            dgStoreStocks.Location = new Point(0, 25);
            dgStoreStocks.Name = "dgStoreStocks";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgStoreStocks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgStoreStocks.RowTemplate.Height = 25;
            dgStoreStocks.Size = new Size(486, 89);
            dgStoreStocks.TabIndex = 1;
            dgStoreStocks.SelectionChanged += dgStoreStocks_SelectionChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAddStoreStock, btnEditStoreStock, btnDeleteStoreStock });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(486, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAddStoreStock
            // 
            btnAddStoreStock.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAddStoreStock.Image = (Image)resources.GetObject("btnAddStoreStock.Image");
            btnAddStoreStock.ImageTransparentColor = Color.Magenta;
            btnAddStoreStock.Name = "btnAddStoreStock";
            btnAddStoreStock.Size = new Size(23, 22);
            btnAddStoreStock.Text = "Add";
            btnAddStoreStock.Click += btnAddStoreStock_Click;
            // 
            // btnEditStoreStock
            // 
            btnEditStoreStock.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditStoreStock.Image = (Image)resources.GetObject("btnEditStoreStock.Image");
            btnEditStoreStock.ImageTransparentColor = Color.Magenta;
            btnEditStoreStock.Name = "btnEditStoreStock";
            btnEditStoreStock.Size = new Size(23, 22);
            btnEditStoreStock.Text = "Edit";
            btnEditStoreStock.Click += btnEditStoreStock_Click;
            // 
            // btnDeleteStoreStock
            // 
            btnDeleteStoreStock.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDeleteStoreStock.Image = (Image)resources.GetObject("btnDeleteStoreStock.Image");
            btnDeleteStoreStock.ImageTransparentColor = Color.Magenta;
            btnDeleteStoreStock.Name = "btnDeleteStoreStock";
            btnDeleteStoreStock.Size = new Size(23, 22);
            btnDeleteStoreStock.Text = "Delete";
            btnDeleteStoreStock.Click += btnDeleteStoreStock_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel2);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(479, 147);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(492, 136);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Warehouse Stocks";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgWarehouseStocks);
            panel2.Controls.Add(toolStrip2);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(3, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(486, 114);
            panel2.TabIndex = 21;
            // 
            // dgWarehouseStocks
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgWarehouseStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgWarehouseStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgWarehouseStocks.DefaultCellStyle = dataGridViewCellStyle5;
            dgWarehouseStocks.Dock = DockStyle.Fill;
            dgWarehouseStocks.Location = new Point(0, 25);
            dgWarehouseStocks.Name = "dgWarehouseStocks";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgWarehouseStocks.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgWarehouseStocks.RowTemplate.Height = 25;
            dgWarehouseStocks.Size = new Size(486, 89);
            dgWarehouseStocks.TabIndex = 1;
            // 
            // toolStrip2
            // 
            toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip2.Items.AddRange(new ToolStripItem[] { btnAddWarehouseStock, btnEditWarehouseStock, btnDeleteWarehouseStock });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(486, 25);
            toolStrip2.TabIndex = 0;
            toolStrip2.Text = "toolStrip2";
            // 
            // btnAddWarehouseStock
            // 
            btnAddWarehouseStock.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAddWarehouseStock.Image = (Image)resources.GetObject("btnAddWarehouseStock.Image");
            btnAddWarehouseStock.ImageTransparentColor = Color.Magenta;
            btnAddWarehouseStock.Name = "btnAddWarehouseStock";
            btnAddWarehouseStock.Size = new Size(23, 22);
            btnAddWarehouseStock.Text = "Add";
            btnAddWarehouseStock.Click += btnAddWarehouseStock_Click;
            // 
            // btnEditWarehouseStock
            // 
            btnEditWarehouseStock.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditWarehouseStock.Image = (Image)resources.GetObject("btnEditWarehouseStock.Image");
            btnEditWarehouseStock.ImageTransparentColor = Color.Magenta;
            btnEditWarehouseStock.Name = "btnEditWarehouseStock";
            btnEditWarehouseStock.Size = new Size(23, 22);
            btnEditWarehouseStock.Text = "Edit";
            btnEditWarehouseStock.Click += btnEditWarehouseStock_Click;
            // 
            // btnDeleteWarehouseStock
            // 
            btnDeleteWarehouseStock.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDeleteWarehouseStock.Image = (Image)resources.GetObject("btnDeleteWarehouseStock.Image");
            btnDeleteWarehouseStock.ImageTransparentColor = Color.Magenta;
            btnDeleteWarehouseStock.Name = "btnDeleteWarehouseStock";
            btnDeleteWarehouseStock.Size = new Size(23, 22);
            btnDeleteWarehouseStock.Text = "Delete";
            btnDeleteWarehouseStock.Click += btnDeleteWarehouseStock_Click;
            // 
            // epName
            // 
            epName.ContainerControl = this;
            // 
            // epCode
            // 
            epCode.ContainerControl = this;
            // 
            // UcItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnAddUnit);
            Controls.Add(btnAddCategory);
            Controls.Add(label9);
            Controls.Add(cmbUnit);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(nudMinStockThreshold);
            Controls.Add(lblUnitCost);
            Controls.Add(nudUnitCost);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(cmbCategory);
            Controls.Add(txtCode);
            Controls.Add(label1);
            Name = "UcItems";
            Size = new Size(971, 294);
            Load += UcItems_Load;
            ((System.ComponentModel.ISupportInitialize)nudUnitCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinStockThreshold).EndInit();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgStoreStocks).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgWarehouseStocks).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epName).EndInit();
            ((System.ComponentModel.ISupportInitialize)epCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblUnitCost;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnAddCategory;
        private Button btnAddUnit;
        private GroupBox groupBox1;
        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAddStoreStock;
        private ToolStripButton btnDeleteStoreStock;
        private GroupBox groupBox2;
        private Panel panel2;
        private ToolStrip toolStrip2;
        private ToolStripButton btnAddWarehouseStock;
        private ToolStripButton btnDeleteWarehouseStock;
        private ErrorProvider epName;
        public TextBox txtCode;
        public ComboBox cmbCategory;
        public TextBox txtName;
        public NumericUpDown nudUnitCost;
        public NumericUpDown nudMinStockThreshold;
        public ComboBox cmbUnit;
        public DataGridView dgStoreStocks;
        public DataGridView dgWarehouseStocks;
        private ToolStripButton btnEditStoreStock;
        private ToolStripButton btnEditWarehouseStock;
        private ErrorProvider epCode;
    }
}
