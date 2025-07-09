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
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            storeToolStripMenuItem = new ToolStripMenuItem();
            stocksPerStoreToolStripMenuItem = new ToolStripMenuItem();
            fastSlowMovingStocksToolStripMenuItem = new ToolStripMenuItem();
            salesToolStripMenuItem = new ToolStripMenuItem();
            grossIncomeToolStripMenuItem = new ToolStripMenuItem();
            soldItemsToolStripMenuItem = new ToolStripMenuItem();
            dueReportToolStripMenuItem = new ToolStripMenuItem();
            statementOfAcocuntToolStripMenuItem = new ToolStripMenuItem();
            payablesToolStripMenuItem = new ToolStripMenuItem();
            accountsReceivableToolStripMenuItem = new ToolStripMenuItem();
            itemToolStripMenuItem = new ToolStripMenuItem();
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
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { storeToolStripMenuItem, fastSlowMovingStocksToolStripMenuItem, itemToolStripMenuItem });
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(69, 20);
            inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // storeToolStripMenuItem
            // 
            storeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stocksPerStoreToolStripMenuItem });
            storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            storeToolStripMenuItem.Size = new Size(180, 22);
            storeToolStripMenuItem.Text = "Branch";
            // 
            // stocksPerStoreToolStripMenuItem
            // 
            stocksPerStoreToolStripMenuItem.Name = "stocksPerStoreToolStripMenuItem";
            stocksPerStoreToolStripMenuItem.Size = new Size(180, 22);
            stocksPerStoreToolStripMenuItem.Text = "Inventory List";
            stocksPerStoreToolStripMenuItem.Click += stocksPerStoreToolStripMenuItem_Click_1;
            // 
            // fastSlowMovingStocksToolStripMenuItem
            // 
            fastSlowMovingStocksToolStripMenuItem.Name = "fastSlowMovingStocksToolStripMenuItem";
            fastSlowMovingStocksToolStripMenuItem.Size = new Size(180, 22);
            fastSlowMovingStocksToolStripMenuItem.Text = "Defective Items";
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
            // itemToolStripMenuItem
            // 
            itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            itemToolStripMenuItem.Size = new Size(171, 22);
            itemToolStripMenuItem.Text = "Stock Item History";
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
        private ToolStripMenuItem statementOfAcocuntToolStripMenuItem;
        private ToolStripMenuItem payablesToolStripMenuItem;
        private ToolStripMenuItem accountsReceivableToolStripMenuItem;
        private ToolStripMenuItem dueReportToolStripMenuItem;
        private ToolStripMenuItem itemToolStripMenuItem;
    }
}