namespace ZenBiz.AppModules.Forms.Reports
{
    public partial class FrmReports : Form
    {
        public FrmReports()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
        }

        private void ShowMdiForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }

        private void stocksPerStoreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShowMdiForm(new FrmStockPerStoreReport());
        }

        private void stocksPerWarehouseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new FrmStockPerWarehouseReport());
        }

        private void stockAdjustmentStoreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new FrmStockAdjustmentsReport(false));
        }

        private void stockAdjustmentWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new FrmStockAdjustmentsReport(true));
        }

        private void grossIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new FrmGrossIncomeReport());
        }

        private void soldItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new FrmSoldItems());
        }

        private void statementOfAcocuntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new FrmStatementOfAccount());
        }

        private void payablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new FrmAgingPayable());
        }

        private void accountsReceivableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new FrmAgingReceivables());
        }

        private void fastSlowMovingStocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new FrmFastAndSlowMovingStocks());
        }
    }
}
