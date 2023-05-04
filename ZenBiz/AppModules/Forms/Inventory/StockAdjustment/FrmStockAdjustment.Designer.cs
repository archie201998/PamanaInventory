namespace ZenBiz.AppModules.Forms.Inventory.StockAdjustment
{
    partial class FrmStockAdjustment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockAdjustment));
            ucItemDetailsDisplay1 = new Items.UcItemDetailsDisplay();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgStoreStockAdjust = new DataGridView();
            toolStrip2 = new ToolStrip();
            btnStoreStockAdd = new ToolStripButton();
            btnStoreStockEdit = new ToolStripButton();
            btnStoreStockDelete = new ToolStripButton();
            tabPage2 = new TabPage();
            dgWarehouseStockAdjust = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnWarehouseStockAdd = new ToolStripButton();
            btnWarehouseStockEdit = new ToolStripButton();
            btnWarehouseStockDelete = new ToolStripButton();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgStoreStockAdjust).BeginInit();
            toolStrip2.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgWarehouseStockAdjust).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ucItemDetailsDisplay1
            // 
            ucItemDetailsDisplay1.Location = new Point(12, 12);
            ucItemDetailsDisplay1.Name = "ucItemDetailsDisplay1";
            ucItemDetailsDisplay1.Size = new Size(845, 194);
            ucItemDetailsDisplay1.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 212);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(845, 226);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgStoreStockAdjust);
            tabPage1.Controls.Add(toolStrip2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(837, 198);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Stores";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgStoreStockAdjust
            // 
            dgStoreStockAdjust.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStoreStockAdjust.Dock = DockStyle.Fill;
            dgStoreStockAdjust.Location = new Point(3, 28);
            dgStoreStockAdjust.Name = "dgStoreStockAdjust";
            dgStoreStockAdjust.RowTemplate.Height = 25;
            dgStoreStockAdjust.Size = new Size(831, 167);
            dgStoreStockAdjust.TabIndex = 4;
            dgStoreStockAdjust.SelectionChanged += dgStoreStockAdjust_SelectionChanged;
            // 
            // toolStrip2
            // 
            toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip2.Items.AddRange(new ToolStripItem[] { btnStoreStockAdd, btnStoreStockEdit, btnStoreStockDelete });
            toolStrip2.Location = new Point(3, 3);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(831, 25);
            toolStrip2.TabIndex = 3;
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
            // tabPage2
            // 
            tabPage2.Controls.Add(dgWarehouseStockAdjust);
            tabPage2.Controls.Add(toolStrip1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(837, 198);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Warehouses";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgWarehouseStockAdjust
            // 
            dgWarehouseStockAdjust.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgWarehouseStockAdjust.Dock = DockStyle.Fill;
            dgWarehouseStockAdjust.Location = new Point(3, 28);
            dgWarehouseStockAdjust.Name = "dgWarehouseStockAdjust";
            dgWarehouseStockAdjust.RowTemplate.Height = 25;
            dgWarehouseStockAdjust.Size = new Size(831, 167);
            dgWarehouseStockAdjust.TabIndex = 5;
            dgWarehouseStockAdjust.SelectionChanged += dgWarehouseStockAdjust_SelectionChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnWarehouseStockAdd, btnWarehouseStockEdit, btnWarehouseStockDelete });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(831, 25);
            toolStrip1.TabIndex = 4;
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
            // FrmStockAdjustment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 450);
            Controls.Add(tabControl1);
            Controls.Add(ucItemDetailsDisplay1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmStockAdjustment";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock Adjustment";
            FormClosed += FrmStockAdjustment_FormClosed;
            Load += FrmStockAdjustment_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgStoreStockAdjust).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgWarehouseStockAdjust).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Items.UcItemDetailsDisplay ucItemDetailsDisplay1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ToolStrip toolStrip2;
        private ToolStripButton btnStoreStockAdd;
        private ToolStripButton btnStoreStockEdit;
        private ToolStripButton btnStoreStockDelete;
        private ToolStrip toolStrip1;
        private ToolStripButton btnWarehouseStockAdd;
        private ToolStripButton btnWarehouseStockEdit;
        private ToolStripButton btnWarehouseStockDelete;
        private DataGridView dgStoreStockAdjust;
        private DataGridView dgWarehouseStockAdjust;
    }
}