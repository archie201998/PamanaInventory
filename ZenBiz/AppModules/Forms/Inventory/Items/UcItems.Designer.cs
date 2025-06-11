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
            label1 = new Label();
            txtCode = new TextBox();
            cmbCategory = new ComboBox();
            txtName = new TextBox();
            label2 = new Label();
            label8 = new Label();
            label9 = new Label();
            cmbUnit = new ComboBox();
            btnAddCategory = new Button();
            btnAddUnit = new Button();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            dgBranchStocks = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnAddStoreStock = new ToolStripButton();
            btnEditStoreStock = new ToolStripButton();
            btnDeleteStoreStock = new ToolStripButton();
            epName = new ErrorProvider(components);
            epCode = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgBranchStocks).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epCode).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 80);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Code";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(135, 77);
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
            cmbCategory.Location = new Point(135, 19);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(300, 23);
            cmbCategory.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(135, 106);
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
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 22);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 15;
            label8.Text = "Category";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 51);
            label9.Name = "label9";
            label9.Size = new Size(29, 15);
            label9.TabIndex = 17;
            label9.Text = "Unit";
            // 
            // cmbUnit
            // 
            cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(135, 48);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(300, 23);
            cmbUnit.TabIndex = 7;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Image = (Image)resources.GetObject("btnAddCategory.Image");
            btnAddCategory.Location = new Point(441, 19);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(23, 23);
            btnAddCategory.TabIndex = 18;
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // btnAddUnit
            // 
            btnAddUnit.Image = (Image)resources.GetObject("btnAddUnit.Image");
            btnAddUnit.Location = new Point(441, 48);
            btnAddUnit.Name = "btnAddUnit";
            btnAddUnit.Size = new Size(23, 23);
            btnAddUnit.TabIndex = 19;
            btnAddUnit.UseVisualStyleBackColor = true;
            btnAddUnit.Click += btnAddUnit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(9, 152);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(959, 338);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Branch Stocks";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgBranchStocks);
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(953, 316);
            panel1.TabIndex = 21;
            // 
            // dgBranchStocks
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgBranchStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgBranchStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgBranchStocks.DefaultCellStyle = dataGridViewCellStyle2;
            dgBranchStocks.Dock = DockStyle.Fill;
            dgBranchStocks.Location = new Point(0, 25);
            dgBranchStocks.Name = "dgBranchStocks";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgBranchStocks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgBranchStocks.RowTemplate.Height = 25;
            dgBranchStocks.Size = new Size(953, 291);
            dgBranchStocks.TabIndex = 1;
            dgBranchStocks.SelectionChanged += dgStoreStocks_SelectionChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAddStoreStock, btnEditStoreStock, btnDeleteStoreStock });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(953, 25);
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
            Controls.Add(groupBox1);
            Controls.Add(btnAddUnit);
            Controls.Add(btnAddCategory);
            Controls.Add(label9);
            Controls.Add(cmbUnit);
            Controls.Add(label8);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(cmbCategory);
            Controls.Add(txtCode);
            Controls.Add(label1);
            Name = "UcItems";
            Size = new Size(971, 503);
            Load += UcItems_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgBranchStocks).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epName).EndInit();
            ((System.ComponentModel.ISupportInitialize)epCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label8;
        private Label label9;
        private Button btnAddCategory;
        private Button btnAddUnit;
        private GroupBox groupBox1;
        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAddStoreStock;
        private ToolStripButton btnDeleteStoreStock;
        private ErrorProvider epName;
        public TextBox txtCode;
        public ComboBox cmbCategory;
        public TextBox txtName;
        public ComboBox cmbUnit;
        public DataGridView dgBranchStocks;
        private ToolStripButton btnEditStoreStock;
        private ErrorProvider epCode;
    }
}
