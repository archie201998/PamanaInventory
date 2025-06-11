using System.ComponentModel;

namespace ZenBiz.AppModules.Forms.Inventory.Items
{
    public partial class UcStocksForm : UserControl
    {
        public UcStocksForm()
        {
            InitializeComponent();
        }

        internal string GetFormErrors()
        {
            string[] errorArray = new string[]
            {
                epStockCount.GetError(nudUnitCost)
            };

            return Helper.GenerateFormErrorMessage(errorArray);
        }

        internal void ResetForm()
        {
            cmbBranch.SelectedIndex = 0;
            dtpRepairedDate.Checked = false;
        }

        internal void LoadBranches()
        {
            cmbBranch.DataSource = Factory.BranchesController().Fetch();
            cmbBranch.DisplayMember = "name";
            cmbBranch.ValueMember = "id";
        }

        internal void LoadSuppliers()
        {
            cmbSupplier.DataSource = Factory.SuppliersController().Fetch();
            cmbSupplier.DisplayMember = "name";
            cmbSupplier.ValueMember = "id";
        }

        private void UcStoreStocks_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {   
                LoadBranches();
                LoadSuppliers();
            }
        }

        private void nudStockCount_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Helper.ShowErrorNumericUpDownEmpty(epStockCount, nudUnitCost, "unit cost");
        }

        private void nudStockCount_Validated(object sender, EventArgs e)
        {
            Helper.ClearErrorNumericUpDown(epStockCount, nudUnitCost);
        }

        private void chkSupplier_CheckedChanged(object sender, EventArgs e)
        {
            txtUser.Enabled = chkUser.Checked;
        }

        private void chkRepairedDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpRepairedDate.Enabled = chkRepairedDate.Checked;
        }

    }
}
