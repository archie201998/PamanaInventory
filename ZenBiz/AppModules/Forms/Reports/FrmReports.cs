using ZenBiz.AppModules.Forms.Reports.Store;

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
            ShowMdiForm(new FrmStockPerBranchReport());
        }

        private void stockAdjustmentStoreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new FrmStockAdjustmentsReport(false));
        }

        private void stockAdjustmentWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new FrmStockAdjustmentsReport(true));
        }

        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new FrmStockPerBranchDetailsReport());
        }
    }
}
