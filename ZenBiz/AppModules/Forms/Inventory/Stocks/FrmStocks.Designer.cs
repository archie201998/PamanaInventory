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
            dgBranchStocks = new DataGridView();
            toolStrip2 = new ToolStrip();
            btnStoreStockAdd = new ToolStripButton();
            btnStoreStockEdit = new ToolStripButton();
            btnStoreStockDelete = new ToolStripButton();
            lblTotalStoreStocks = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            cmbBranches = new ToolStripComboBox();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabStores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgBranchStocks).BeginInit();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1090, 112);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item Details";
            // 
            // panel1
            // 
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
            panel1.Size = new Size(1084, 90);
            panel1.TabIndex = 1;
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(100, 47);
            txtUnit.Name = "txtUnit";
            txtUnit.ReadOnly = true;
            txtUnit.Size = new Size(207, 23);
            txtUnit.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 50);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 6;
            label4.Text = "Unit";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(100, 18);
            txtCategory.Name = "txtCategory";
            txtCategory.ReadOnly = true;
            txtCategory.Size = new Size(207, 23);
            txtCategory.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 21);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "Category";
            // 
            // txtName
            // 
            txtName.Location = new Point(386, 47);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(207, 23);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 50);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(386, 18);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(207, 23);
            txtCode.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 21);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Code";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabStores);
            tabControl1.Location = new Point(12, 130);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1090, 370);
            tabControl1.TabIndex = 1;
            // 
            // tabStores
            // 
            tabStores.Controls.Add(dgBranchStocks);
            tabStores.Controls.Add(toolStrip2);
            tabStores.Location = new Point(4, 24);
            tabStores.Name = "tabStores";
            tabStores.Padding = new Padding(3);
            tabStores.Size = new Size(1082, 342);
            tabStores.TabIndex = 0;
            tabStores.Text = "Branches";
            tabStores.UseVisualStyleBackColor = true;
            // 
            // dgBranchStocks
            // 
            dgBranchStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBranchStocks.Dock = DockStyle.Fill;
            dgBranchStocks.Location = new Point(3, 41);
            dgBranchStocks.Name = "dgBranchStocks";
            dgBranchStocks.RowTemplate.Height = 25;
            dgBranchStocks.Size = new Size(1076, 298);
            dgBranchStocks.TabIndex = 3;
            dgBranchStocks.SelectionChanged += dgStoreStocks_SelectionChanged;
            // 
            // toolStrip2
            // 
            toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip2.Items.AddRange(new ToolStripItem[] { btnStoreStockAdd, btnStoreStockEdit, btnStoreStockDelete, lblTotalStoreStocks, toolStripLabel2, cmbBranches, toolStripSeparator1, toolStripButton1, toolStripButton2 });
            toolStrip2.Location = new Point(3, 3);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(1076, 38);
            toolStrip2.TabIndex = 2;
            toolStrip2.Text = "toolStrip2";
            // 
            // btnStoreStockAdd
            // 
            btnStoreStockAdd.Image = (Image)resources.GetObject("btnStoreStockAdd.Image");
            btnStoreStockAdd.ImageTransparentColor = Color.Magenta;
            btnStoreStockAdd.Name = "btnStoreStockAdd";
            btnStoreStockAdd.Size = new Size(33, 35);
            btnStoreStockAdd.Text = "Add";
            btnStoreStockAdd.TextImageRelation = TextImageRelation.ImageAboveText;
            btnStoreStockAdd.Click += btnStoreStockAdd_Click;
            // 
            // btnStoreStockEdit
            // 
            btnStoreStockEdit.Image = (Image)resources.GetObject("btnStoreStockEdit.Image");
            btnStoreStockEdit.ImageTransparentColor = Color.Magenta;
            btnStoreStockEdit.Name = "btnStoreStockEdit";
            btnStoreStockEdit.Size = new Size(31, 35);
            btnStoreStockEdit.Text = "Edit";
            btnStoreStockEdit.TextImageRelation = TextImageRelation.ImageAboveText;
            btnStoreStockEdit.Click += btnStoreStockEdit_Click;
            // 
            // btnStoreStockDelete
            // 
            btnStoreStockDelete.Image = (Image)resources.GetObject("btnStoreStockDelete.Image");
            btnStoreStockDelete.ImageTransparentColor = Color.Magenta;
            btnStoreStockDelete.Name = "btnStoreStockDelete";
            btnStoreStockDelete.Size = new Size(44, 35);
            btnStoreStockDelete.Text = "Delete";
            btnStoreStockDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            btnStoreStockDelete.Click += btnStoreStockDelete_Click;
            // 
            // lblTotalStoreStocks
            // 
            lblTotalStoreStocks.Alignment = ToolStripItemAlignment.Right;
            lblTotalStoreStocks.Name = "lblTotalStoreStocks";
            lblTotalStoreStocks.Size = new Size(28, 35);
            lblTotalStoreStocks.Text = "0.00";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(36, 35);
            toolStripLabel2.Text = "Total:";
            // 
            // cmbBranches
            // 
            cmbBranches.Alignment = ToolStripItemAlignment.Right;
            cmbBranches.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBranches.Name = "cmbBranches";
            cmbBranches.Size = new Size(200, 38);
            cmbBranches.Click += cmbBranches_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 38);
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = PamanaWaterInventory.Properties.Resources.icons8_tools_24;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(49, 35);
            toolStripButton1.Text = "Repairs";
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = PamanaWaterInventory.Properties.Resources.icons8_user_24;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(39, 35);
            toolStripButton2.Text = "Users";
            toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // FrmStocks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 510);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmStocks";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Stocks";
            WindowState = FormWindowState.Maximized;
            FormClosed += FrmStocks_FormClosed;
            Load += FrmStocks_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabStores.ResumeLayout(false);
            tabStores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgBranchStocks).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private TextBox txtCode;
        private Label label1;
        private TextBox txtUnit;
        private Label label4;
        private TextBox txtCategory;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabStores;
        private DataGridView dgBranchStocks;
        private ToolStrip toolStrip2;
        private ToolStripButton btnStoreStockAdd;
        private ToolStripButton btnStoreStockEdit;
        private ToolStripButton btnStoreStockDelete;
        private ToolStripLabel lblTotalStoreStocks;
        private ToolStripLabel toolStripLabel2;
        private ToolStripComboBox cmbBranches;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
    }
}