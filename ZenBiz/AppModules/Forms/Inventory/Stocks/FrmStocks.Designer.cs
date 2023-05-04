namespace ZenBiz.AppModules.Forms.Inventory.Stocks
{
    partial class FrmStocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStocks));
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            txtMinStockThreshold = new TextBox();
            label7 = new Label();
            txtSpecialPrice = new TextBox();
            label8 = new Label();
            txtWholesalePrice = new TextBox();
            label9 = new Label();
            txtRetailPrice = new TextBox();
            label10 = new Label();
            txtUnitCost = new TextBox();
            label5 = new Label();
            txtUnit = new TextBox();
            label4 = new Label();
            txtCategory = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtCode = new TextBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabStores = new TabPage();
            dgStoreStocks = new DataGridView();
            toolStrip2 = new ToolStrip();
            btnStoreStockAdd = new ToolStripButton();
            btnStoreStockEdit = new ToolStripButton();
            btnStoreStockDelete = new ToolStripButton();
            lblTotalStoreStocks = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            cmbStores = new ToolStripComboBox();
            tabWarehouses = new TabPage();
            dgWarehouseStocks = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnWarehouseStockAdd = new ToolStripButton();
            btnWarehouseStockEdit = new ToolStripButton();
            btnWarehouseStockDelete = new ToolStripButton();
            lblTotalWarehouseStocks = new ToolStripLabel();
            toolStripLabel3 = new ToolStripLabel();
            cmbWarehouses = new ToolStripComboBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabStores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgStoreStocks).BeginInit();
            toolStrip2.SuspendLayout();
            tabWarehouses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgWarehouseStocks).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(841, 182);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item Details";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtMinStockThreshold);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtSpecialPrice);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtWholesalePrice);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtRetailPrice);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtUnitCost);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtUnit);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCategory);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtCode);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(835, 160);
            panel1.TabIndex = 1;
            // 
            // txtMinStockThreshold
            // 
            txtMinStockThreshold.Location = new Point(516, 90);
            txtMinStockThreshold.Name = "txtMinStockThreshold";
            txtMinStockThreshold.ReadOnly = true;
            txtMinStockThreshold.Size = new Size(297, 23);
            txtMinStockThreshold.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(392, 93);
            label7.Name = "label7";
            label7.Size = new Size(118, 15);
            label7.TabIndex = 16;
            label7.Text = "Min. Stock Threshold";
            // 
            // txtSpecialPrice
            // 
            txtSpecialPrice.Location = new Point(516, 61);
            txtSpecialPrice.Name = "txtSpecialPrice";
            txtSpecialPrice.ReadOnly = true;
            txtSpecialPrice.Size = new Size(297, 23);
            txtSpecialPrice.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(392, 64);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 14;
            label8.Text = "Special Price";
            // 
            // txtWholesalePrice
            // 
            txtWholesalePrice.Location = new Point(516, 32);
            txtWholesalePrice.Name = "txtWholesalePrice";
            txtWholesalePrice.ReadOnly = true;
            txtWholesalePrice.Size = new Size(297, 23);
            txtWholesalePrice.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(392, 35);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 12;
            label9.Text = "Wholesale Price";
            // 
            // txtRetailPrice
            // 
            txtRetailPrice.Location = new Point(516, 3);
            txtRetailPrice.Name = "txtRetailPrice";
            txtRetailPrice.ReadOnly = true;
            txtRetailPrice.Size = new Size(297, 23);
            txtRetailPrice.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(392, 6);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 10;
            label10.Text = "Retail Price";
            // 
            // txtUnitCost
            // 
            txtUnitCost.Location = new Point(65, 119);
            txtUnitCost.Name = "txtUnitCost";
            txtUnitCost.ReadOnly = true;
            txtUnitCost.Size = new Size(297, 23);
            txtUnitCost.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 122);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 8;
            label5.Text = "Unit Cost";
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(65, 90);
            txtUnit.Name = "txtUnit";
            txtUnit.ReadOnly = true;
            txtUnit.Size = new Size(297, 23);
            txtUnit.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 93);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 6;
            label4.Text = "Unit";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(65, 61);
            txtCategory.Name = "txtCategory";
            txtCategory.ReadOnly = true;
            txtCategory.Size = new Size(297, 23);
            txtCategory.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 64);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "Category";
            // 
            // txtName
            // 
            txtName.Location = new Point(65, 32);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(297, 23);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(65, 3);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(297, 23);
            txtCode.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Code";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabStores);
            tabControl1.Controls.Add(tabWarehouses);
            tabControl1.Location = new Point(14, 200);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(841, 300);
            tabControl1.TabIndex = 1;
            // 
            // tabStores
            // 
            tabStores.Controls.Add(dgStoreStocks);
            tabStores.Controls.Add(toolStrip2);
            tabStores.Location = new Point(4, 24);
            tabStores.Name = "tabStores";
            tabStores.Padding = new Padding(3);
            tabStores.Size = new Size(833, 272);
            tabStores.TabIndex = 0;
            tabStores.Text = "Stores";
            tabStores.UseVisualStyleBackColor = true;
            // 
            // dgStoreStocks
            // 
            dgStoreStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStoreStocks.Dock = DockStyle.Fill;
            dgStoreStocks.Location = new Point(3, 28);
            dgStoreStocks.Name = "dgStoreStocks";
            dgStoreStocks.RowTemplate.Height = 25;
            dgStoreStocks.Size = new Size(827, 241);
            dgStoreStocks.TabIndex = 3;
            dgStoreStocks.SelectionChanged += dgStoreStocks_SelectionChanged;
            // 
            // toolStrip2
            // 
            toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip2.Items.AddRange(new ToolStripItem[] { btnStoreStockAdd, btnStoreStockEdit, btnStoreStockDelete, lblTotalStoreStocks, toolStripLabel2, cmbStores });
            toolStrip2.Location = new Point(3, 3);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(827, 25);
            toolStrip2.TabIndex = 2;
            toolStrip2.Text = "toolStrip2";
            // 
            // btnStoreStockAdd
            // 
            btnStoreStockAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnStoreStockAdd.Image = (Image)resources.GetObject("btnStoreStockAdd.Image");
            btnStoreStockAdd.ImageTransparentColor = Color.Magenta;
            btnStoreStockAdd.Name = "btnStoreStockAdd";
            btnStoreStockAdd.Size = new Size(23, 22);
            btnStoreStockAdd.Text = "Add";
            btnStoreStockAdd.Click += btnStoreStockAdd_Click;
            // 
            // btnStoreStockEdit
            // 
            btnStoreStockEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnStoreStockEdit.Image = (Image)resources.GetObject("btnStoreStockEdit.Image");
            btnStoreStockEdit.ImageTransparentColor = Color.Magenta;
            btnStoreStockEdit.Name = "btnStoreStockEdit";
            btnStoreStockEdit.Size = new Size(23, 22);
            btnStoreStockEdit.Text = "Edit";
            btnStoreStockEdit.Click += btnStoreStockEdit_Click;
            // 
            // btnStoreStockDelete
            // 
            btnStoreStockDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnStoreStockDelete.Image = (Image)resources.GetObject("btnStoreStockDelete.Image");
            btnStoreStockDelete.ImageTransparentColor = Color.Magenta;
            btnStoreStockDelete.Name = "btnStoreStockDelete";
            btnStoreStockDelete.Size = new Size(23, 22);
            btnStoreStockDelete.Text = "Delete";
            btnStoreStockDelete.Click += btnStoreStockDelete_Click;
            // 
            // lblTotalStoreStocks
            // 
            lblTotalStoreStocks.Alignment = ToolStripItemAlignment.Right;
            lblTotalStoreStocks.Name = "lblTotalStoreStocks";
            lblTotalStoreStocks.Size = new Size(28, 22);
            lblTotalStoreStocks.Text = "0.00";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(35, 22);
            toolStripLabel2.Text = "Total:";
            // 
            // cmbStores
            // 
            cmbStores.Alignment = ToolStripItemAlignment.Right;
            cmbStores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStores.Name = "cmbStores";
            cmbStores.Size = new Size(121, 25);
            // 
            // tabWarehouses
            // 
            tabWarehouses.Controls.Add(dgWarehouseStocks);
            tabWarehouses.Controls.Add(toolStrip1);
            tabWarehouses.Location = new Point(4, 24);
            tabWarehouses.Name = "tabWarehouses";
            tabWarehouses.Padding = new Padding(3);
            tabWarehouses.Size = new Size(833, 272);
            tabWarehouses.TabIndex = 1;
            tabWarehouses.Text = "Warehouses";
            tabWarehouses.UseVisualStyleBackColor = true;
            // 
            // dgWarehouseStocks
            // 
            dgWarehouseStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgWarehouseStocks.Dock = DockStyle.Fill;
            dgWarehouseStocks.Location = new Point(3, 28);
            dgWarehouseStocks.Name = "dgWarehouseStocks";
            dgWarehouseStocks.RowTemplate.Height = 25;
            dgWarehouseStocks.Size = new Size(827, 241);
            dgWarehouseStocks.TabIndex = 2;
            dgWarehouseStocks.SelectionChanged += dgWarehouseStocks_SelectionChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnWarehouseStockAdd, btnWarehouseStockEdit, btnWarehouseStockDelete, lblTotalWarehouseStocks, toolStripLabel3, cmbWarehouses });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(827, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnWarehouseStockAdd
            // 
            btnWarehouseStockAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnWarehouseStockAdd.Image = (Image)resources.GetObject("btnWarehouseStockAdd.Image");
            btnWarehouseStockAdd.ImageTransparentColor = Color.Magenta;
            btnWarehouseStockAdd.Name = "btnWarehouseStockAdd";
            btnWarehouseStockAdd.Size = new Size(23, 22);
            btnWarehouseStockAdd.Text = "Add";
            btnWarehouseStockAdd.Click += btnWarehouseStockAdd_Click;
            // 
            // btnWarehouseStockEdit
            // 
            btnWarehouseStockEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnWarehouseStockEdit.Image = (Image)resources.GetObject("btnWarehouseStockEdit.Image");
            btnWarehouseStockEdit.ImageTransparentColor = Color.Magenta;
            btnWarehouseStockEdit.Name = "btnWarehouseStockEdit";
            btnWarehouseStockEdit.Size = new Size(23, 22);
            btnWarehouseStockEdit.Text = "Edit";
            btnWarehouseStockEdit.Click += btnWarehouseStockEdit_Click;
            // 
            // btnWarehouseStockDelete
            // 
            btnWarehouseStockDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnWarehouseStockDelete.Image = (Image)resources.GetObject("btnWarehouseStockDelete.Image");
            btnWarehouseStockDelete.ImageTransparentColor = Color.Magenta;
            btnWarehouseStockDelete.Name = "btnWarehouseStockDelete";
            btnWarehouseStockDelete.Size = new Size(23, 22);
            btnWarehouseStockDelete.Text = "Delete";
            btnWarehouseStockDelete.Click += btnWarehouseStockDelete_Click;
            // 
            // lblTotalWarehouseStocks
            // 
            lblTotalWarehouseStocks.Alignment = ToolStripItemAlignment.Right;
            lblTotalWarehouseStocks.Name = "lblTotalWarehouseStocks";
            lblTotalWarehouseStocks.Size = new Size(28, 22);
            lblTotalWarehouseStocks.Text = "0.00";
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(35, 22);
            toolStripLabel3.Text = "Total:";
            // 
            // cmbWarehouses
            // 
            cmbWarehouses.Alignment = ToolStripItemAlignment.Right;
            cmbWarehouses.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWarehouses.Name = "cmbWarehouses";
            cmbWarehouses.Size = new Size(121, 25);
            // 
            // FrmStocks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 510);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmStocks";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Stocks";
            FormClosed += FrmStocks_FormClosed;
            Load += FrmStocks_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabStores.ResumeLayout(false);
            tabStores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgStoreStocks).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            tabWarehouses.ResumeLayout(false);
            tabWarehouses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgWarehouseStocks).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private TextBox txtCode;
        private Label label1;
        private TextBox txtMinStockThreshold;
        private Label label7;
        private TextBox txtSpecialPrice;
        private Label label8;
        private TextBox txtWholesalePrice;
        private Label label9;
        private TextBox txtRetailPrice;
        private Label label10;
        private TextBox txtUnitCost;
        private Label label5;
        private TextBox txtUnit;
        private Label label4;
        private TextBox txtCategory;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabStores;
        private TabPage tabWarehouses;
        private ToolStrip toolStrip1;
        private ToolStripButton btnWarehouseStockAdd;
        private ToolStripButton btnWarehouseStockEdit;
        private ToolStripButton btnWarehouseStockDelete;
        private DataGridView dgStoreStocks;
        private ToolStrip toolStrip2;
        private ToolStripButton btnStoreStockAdd;
        private ToolStripButton btnStoreStockEdit;
        private ToolStripButton btnStoreStockDelete;
        private DataGridView dgWarehouseStocks;
        private ToolStripLabel lblTotalStoreStocks;
        private ToolStripLabel toolStripLabel2;
        private ToolStripComboBox cmbStores;
        private ToolStripLabel lblTotalWarehouseStocks;
        private ToolStripLabel toolStripLabel3;
        private ToolStripComboBox cmbWarehouses;
    }
}