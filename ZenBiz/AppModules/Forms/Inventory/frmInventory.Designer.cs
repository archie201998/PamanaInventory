namespace ZenBiz.AppModules.Inventory
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            toolStrip1 = new ToolStrip();
            btnItemsForm = new ToolStripButton();
            btnStoresForm = new ToolStripButton();
            btnWarehousesForm = new ToolStripButton();
            btnSuppliers = new ToolStripButton();
            btnCategoriesForm = new ToolStripButton();
            btnUnitsForm = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnItemsForm, btnStoresForm, btnWarehousesForm, btnSuppliers, btnCategoriesForm, btnUnitsForm });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(824, 46);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnItemsForm
            // 
            btnItemsForm.Image = (Image)resources.GetObject("btnItemsForm.Image");
            btnItemsForm.ImageScaling = ToolStripItemImageScaling.None;
            btnItemsForm.ImageTransparentColor = Color.Magenta;
            btnItemsForm.Name = "btnItemsForm";
            btnItemsForm.Size = new Size(40, 43);
            btnItemsForm.Text = "Items";
            btnItemsForm.TextImageRelation = TextImageRelation.ImageAboveText;
            btnItemsForm.Click += btnItemsForm_Click;
            // 
            // btnStoresForm
            // 
            btnStoresForm.Image = (Image)resources.GetObject("btnStoresForm.Image");
            btnStoresForm.ImageScaling = ToolStripItemImageScaling.None;
            btnStoresForm.ImageTransparentColor = Color.Magenta;
            btnStoresForm.Name = "btnStoresForm";
            btnStoresForm.Size = new Size(59, 43);
            btnStoresForm.Text = "Branches";
            btnStoresForm.TextImageRelation = TextImageRelation.ImageAboveText;
            btnStoresForm.Click += btnStoresForm_Click;
            // 
            // btnWarehousesForm
            // 
            btnWarehousesForm.Image = (Image)resources.GetObject("btnWarehousesForm.Image");
            btnWarehousesForm.ImageScaling = ToolStripItemImageScaling.None;
            btnWarehousesForm.ImageTransparentColor = Color.Magenta;
            btnWarehousesForm.Name = "btnWarehousesForm";
            btnWarehousesForm.Size = new Size(75, 43);
            btnWarehousesForm.Text = "Warehouses";
            btnWarehousesForm.TextImageRelation = TextImageRelation.ImageAboveText;
            btnWarehousesForm.Click += btnWarehousesForm_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Image = (Image)resources.GetObject("btnSuppliers.Image");
            btnSuppliers.ImageScaling = ToolStripItemImageScaling.None;
            btnSuppliers.ImageTransparentColor = Color.Magenta;
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(59, 43);
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnCategoriesForm
            // 
            btnCategoriesForm.Image = (Image)resources.GetObject("btnCategoriesForm.Image");
            btnCategoriesForm.ImageScaling = ToolStripItemImageScaling.None;
            btnCategoriesForm.ImageTransparentColor = Color.Magenta;
            btnCategoriesForm.Name = "btnCategoriesForm";
            btnCategoriesForm.Size = new Size(67, 43);
            btnCategoriesForm.Text = "Categories";
            btnCategoriesForm.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCategoriesForm.Click += btnCategoriesForm_Click;
            // 
            // btnUnitsForm
            // 
            btnUnitsForm.Image = (Image)resources.GetObject("btnUnitsForm.Image");
            btnUnitsForm.ImageScaling = ToolStripItemImageScaling.None;
            btnUnitsForm.ImageTransparentColor = Color.Magenta;
            btnUnitsForm.Name = "btnUnitsForm";
            btnUnitsForm.Size = new Size(38, 43);
            btnUnitsForm.Text = "Units";
            btnUnitsForm.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUnitsForm.Click += btnUnitsForm_Click;
            // 
            // frmInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 507);
            Controls.Add(toolStrip1);
            IsMdiContainer = true;
            MinimumSize = new Size(840, 546);
            Name = "frmInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management";
            WindowState = FormWindowState.Maximized;
            Load += frmInventory_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnItemsForm;
        private ToolStripButton btnStoresForm;
        private ToolStripButton btnWarehousesForm;
        private ToolStripButton btnCategoriesForm;
        private ToolStripButton btnUnitsForm;
        private ToolStripButton btnSuppliers;
    }
}