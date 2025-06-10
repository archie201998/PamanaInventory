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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            label1 = new Label();
            txtCode = new TextBox();
            cmbCategory = new ComboBox();
            txtName = new TextBox();
            label2 = new Label();
            nudUnitCost = new NumericUpDown();
            lblUnitCost = new Label();
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
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            label11 = new Label();
            textBox6 = new TextBox();
            label12 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)nudUnitCost).BeginInit();
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
            label1.Location = new Point(9, 73);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Code";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(132, 70);
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
            cmbCategory.Location = new Point(132, 12);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(300, 23);
            cmbCategory.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(132, 99);
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
            label2.Location = new Point(9, 102);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // nudUnitCost
            // 
            nudUnitCost.DecimalPlaces = 2;
            nudUnitCost.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudUnitCost.Location = new Point(132, 279);
            nudUnitCost.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudUnitCost.Name = "nudUnitCost";
            nudUnitCost.Size = new Size(300, 23);
            nudUnitCost.TabIndex = 8;
            // 
            // lblUnitCost
            // 
            lblUnitCost.AutoSize = true;
            lblUnitCost.Location = new Point(9, 281);
            lblUnitCost.Name = "lblUnitCost";
            lblUnitCost.Size = new Size(56, 15);
            lblUnitCost.TabIndex = 6;
            lblUnitCost.Text = "Unit Cost";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 15);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 15;
            label8.Text = "Category";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 44);
            label9.Name = "label9";
            label9.Size = new Size(29, 15);
            label9.TabIndex = 17;
            label9.Text = "Unit";
            // 
            // cmbUnit
            // 
            cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(132, 41);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(300, 23);
            cmbUnit.TabIndex = 7;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Image = (Image)resources.GetObject("btnAddCategory.Image");
            btnAddCategory.Location = new Point(438, 12);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(23, 23);
            btnAddCategory.TabIndex = 18;
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // btnAddUnit
            // 
            btnAddUnit.Image = (Image)resources.GetObject("btnAddUnit.Image");
            btnAddUnit.Location = new Point(438, 41);
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
            groupBox1.Size = new Size(492, 270);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Branch Stocks";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgStoreStocks);
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 248);
            panel1.TabIndex = 21;
            // 
            // dgStoreStocks
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgStoreStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgStoreStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgStoreStocks.DefaultCellStyle = dataGridViewCellStyle8;
            dgStoreStocks.Dock = DockStyle.Fill;
            dgStoreStocks.Location = new Point(0, 25);
            dgStoreStocks.Name = "dgStoreStocks";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgStoreStocks.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgStoreStocks.RowTemplate.Height = 25;
            dgStoreStocks.Size = new Size(486, 223);
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
            groupBox2.Location = new Point(476, 279);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(492, 213);
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
            panel2.Size = new Size(486, 191);
            panel2.TabIndex = 21;
            // 
            // dgWarehouseStocks
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgWarehouseStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgWarehouseStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgWarehouseStocks.DefaultCellStyle = dataGridViewCellStyle11;
            dgWarehouseStocks.Dock = DockStyle.Fill;
            dgWarehouseStocks.Location = new Point(0, 25);
            dgWarehouseStocks.Name = "dgWarehouseStocks";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgWarehouseStocks.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgWarehouseStocks.RowTemplate.Height = 25;
            dgWarehouseStocks.Size = new Size(486, 166);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 311);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 20;
            label3.Text = "Model";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 308);
            textBox1.MaxLength = 99;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 23);
            textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 337);
            textBox2.MaxLength = 99;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 23);
            textBox2.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 340);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 22;
            label4.Text = "Serial Number";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(132, 366);
            textBox3.MaxLength = 99;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 23);
            textBox3.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 369);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 24;
            label5.Text = "Current User";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(132, 395);
            textBox4.MaxLength = 99;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(300, 23);
            textBox4.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 398);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 26;
            label6.Text = "Computer Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 427);
            label11.Name = "label11";
            label11.Size = new Size(89, 15);
            label11.TabIndex = 28;
            label11.Text = "Sophos Tamper";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(132, 424);
            textBox6.MaxLength = 99;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(300, 23);
            textBox6.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(9, 459);
            label12.Name = "label12";
            label12.Size = new Size(82, 15);
            label12.TabIndex = 28;
            label12.Text = "Date Acquired";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(132, 453);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 23);
            dateTimePicker1.TabIndex = 30;
            // 
            // UcItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dateTimePicker1);
            Controls.Add(label12);
            Controls.Add(textBox6);
            Controls.Add(label11);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnAddUnit);
            Controls.Add(btnAddCategory);
            Controls.Add(label9);
            Controls.Add(cmbUnit);
            Controls.Add(label8);
            Controls.Add(lblUnitCost);
            Controls.Add(nudUnitCost);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(cmbCategory);
            Controls.Add(txtCode);
            Controls.Add(label1);
            Name = "UcItems";
            Size = new Size(971, 495);
            Load += UcItems_Load;
            ((System.ComponentModel.ISupportInitialize)nudUnitCost).EndInit();
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
        public ComboBox cmbUnit;
        public DataGridView dgStoreStocks;
        public DataGridView dgWarehouseStocks;
        private ToolStripButton btnEditStoreStock;
        private ToolStripButton btnEditWarehouseStock;
        private ErrorProvider epCode;
        public TextBox textBox1;
        private Label label3;
        public TextBox textBox3;
        private Label label5;
        public TextBox textBox2;
        private Label label4;
        private Label label12;
        public TextBox textBox6;
        private Label label11;
        public TextBox textBox4;
        private Label label6;
        private DateTimePicker dateTimePicker1;
    }
}
