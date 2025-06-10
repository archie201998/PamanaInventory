namespace ZenBiz.AppModules.Forms.Reports
{
    partial class FrmReports
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
            menuStrip1 = new MenuStrip();
            salesToolStripMenuItem = new ToolStripMenuItem();
            grossIncomeToolStripMenuItem = new ToolStripMenuItem();
            soldItemsToolStripMenuItem = new ToolStripMenuItem();
            dueReportToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            storeToolStripMenuItem = new ToolStripMenuItem();
            stocksPerStoreToolStripMenuItem = new ToolStripMenuItem();
            stockAdjustmentStoreToolStripMenuItem1 = new ToolStripMenuItem();
            warehouseToolStripMenuItem = new ToolStripMenuItem();
            stocksPerWarehouseToolStripMenuItem1 = new ToolStripMenuItem();
            stockAdjustmentWarehouseToolStripMenuItem = new ToolStripMenuItem();
            fastSlowMovingStocksToolStripMenuItem = new ToolStripMenuItem();
            statementOfAcocuntToolStripMenuItem = new ToolStripMenuItem();
            payablesToolStripMenuItem = new ToolStripMenuItem();
            accountsReceivableToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inventoryToolStripMenuItem, salesToolStripMenuItem, statementOfAcocuntToolStripMenuItem, payablesToolStripMenuItem, accountsReceivableToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // salesToolStripMenuItem
            // 
            salesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { grossIncomeToolStripMenuItem, soldItemsToolStripMenuItem, dueReportToolStripMenuItem });
            salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            salesToolStripMenuItem.Size = new Size(45, 20);
            salesToolStripMenuItem.Text = "Sales";
            salesToolStripMenuItem.Visible = false;
            // 
            // grossIncomeToolStripMenuItem
            // 
            grossIncomeToolStripMenuItem.Name = "grossIncomeToolStripMenuItem";
            grossIncomeToolStripMenuItem.Size = new Size(146, 22);
            grossIncomeToolStripMenuItem.Text = "Gross Income";
            // 
            // soldItemsToolStripMenuItem
            // 
            soldItemsToolStripMenuItem.Name = "soldItemsToolStripMenuItem";
            soldItemsToolStripMenuItem.Size = new Size(146, 22);
            soldItemsToolStripMenuItem.Text = "Sold Items";
            // 
            // dueReportToolStripMenuItem
            // 
            dueReportToolStripMenuItem.Name = "dueReportToolStripMenuItem";
            dueReportToolStripMenuItem.Size = new Size(146, 22);
            dueReportToolStripMenuItem.Text = "Due Report";
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { storeToolStripMenuItem, warehouseToolStripMenuItem, fastSlowMovingStocksToolStripMenuItem });
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(69, 20);
            inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // storeToolStripMenuItem
            // 
            storeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stocksPerStoreToolStripMenuItem, stockAdjustmentStoreToolStripMenuItem1 });
            storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            storeToolStripMenuItem.Size = new Size(217, 22);
            storeToolStripMenuItem.Text = "Branch";
            // 
            // stocksPerStoreToolStripMenuItem
            // 
            stocksPerStoreToolStripMenuItem.Name = "stocksPerStoreToolStripMenuItem";
            stocksPerStoreToolStripMenuItem.Size = new Size(173, 22);
            stocksPerStoreToolStripMenuItem.Text = "Inventory List";
            stocksPerStoreToolStripMenuItem.Click += stocksPerStoreToolStripMenuItem_Click_1;
            // 
            // stockAdjustmentStoreToolStripMenuItem1
            // 
            stockAdjustmentStoreToolStripMenuItem1.Name = "stockAdjustmentStoreToolStripMenuItem1";
            stockAdjustmentStoreToolStripMenuItem1.Size = new Size(173, 22);
            stockAdjustmentStoreToolStripMenuItem1.Text = "Stock Adjustments";
            stockAdjustmentStoreToolStripMenuItem1.Click += stockAdjustmentStoreToolStripMenuItem1_Click;
            // 
            // warehouseToolStripMenuItem
            // 
            warehouseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stocksPerWarehouseToolStripMenuItem1, stockAdjustmentWarehouseToolStripMenuItem });
            warehouseToolStripMenuItem.Name = "warehouseToolStripMenuItem";
            warehouseToolStripMenuItem.Size = new Size(217, 22);
            warehouseToolStripMenuItem.Text = "Warehouse";
            // 
            // stocksPerWarehouseToolStripMenuItem1
            // 
            stocksPerWarehouseToolStripMenuItem1.Name = "stocksPerWarehouseToolStripMenuItem1";
            stocksPerWarehouseToolStripMenuItem1.Size = new Size(173, 22);
            stocksPerWarehouseToolStripMenuItem1.Text = "Inventory List";
            stocksPerWarehouseToolStripMenuItem1.Click += stocksPerWarehouseToolStripMenuItem1_Click;
            // 
            // stockAdjustmentWarehouseToolStripMenuItem
            // 
            stockAdjustmentWarehouseToolStripMenuItem.Name = "stockAdjustmentWarehouseToolStripMenuItem";
            stockAdjustmentWarehouseToolStripMenuItem.Size = new Size(173, 22);
            stockAdjustmentWarehouseToolStripMenuItem.Text = "Stock Adjustments";
            stockAdjustmentWarehouseToolStripMenuItem.Click += stockAdjustmentWarehouseToolStripMenuItem_Click;
            // 
            // fastSlowMovingStocksToolStripMenuItem
            // 
            fastSlowMovingStocksToolStripMenuItem.Name = "fastSlowMovingStocksToolStripMenuItem";
            fastSlowMovingStocksToolStripMenuItem.Size = new Size(217, 22);
            fastSlowMovingStocksToolStripMenuItem.Text = "Fast && Slow Moving Stocks";
            // 
            // statementOfAcocuntToolStripMenuItem
            // 
            statementOfAcocuntToolStripMenuItem.Name = "statementOfAcocuntToolStripMenuItem";
            statementOfAcocuntToolStripMenuItem.Size = new Size(135, 20);
            statementOfAcocuntToolStripMenuItem.Text = "Statement of Acocunt";
            statementOfAcocuntToolStripMenuItem.Visible = false;
            // 
            // payablesToolStripMenuItem
            // 
            payablesToolStripMenuItem.Name = "payablesToolStripMenuItem";
            payablesToolStripMenuItem.Size = new Size(153, 20);
            payablesToolStripMenuItem.Text = "Aging Accounts Payables";
            payablesToolStripMenuItem.Visible = false;
            // 
            // accountsReceivableToolStripMenuItem
            // 
            accountsReceivableToolStripMenuItem.Name = "accountsReceivableToolStripMenuItem";
            accountsReceivableToolStripMenuItem.Size = new Size(163, 20);
            accountsReceivableToolStripMenuItem.Text = "Aging Accounts Receivable";
            accountsReceivableToolStripMenuItem.Visible = false;
            // 
            // FrmReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 633);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "FrmReports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem salesToolStripMenuItem;
        private ToolStripMenuItem grossIncomeToolStripMenuItem;
        private ToolStripMenuItem soldItemsToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem fastSlowMovingStocksToolStripMenuItem;
        private ToolStripMenuItem storeToolStripMenuItem;
        private ToolStripMenuItem stocksPerStoreToolStripMenuItem;
        private ToolStripMenuItem warehouseToolStripMenuItem;
        private ToolStripMenuItem stocksPerWarehouseToolStripMenuItem1;
        private ToolStripMenuItem stockAdjustmentStoreToolStripMenuItem1;
        private ToolStripMenuItem stockAdjustmentWarehouseToolStripMenuItem;
        private ToolStripMenuItem statementOfAcocuntToolStripMenuItem;
        private ToolStripMenuItem payablesToolStripMenuItem;
        private ToolStripMenuItem accountsReceivableToolStripMenuItem;
        private ToolStripMenuItem dueReportToolStripMenuItem;
    }
}