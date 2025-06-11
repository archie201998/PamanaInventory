using System.ComponentModel;

namespace ZenBiz.AppModules.Forms.Inventory.Items
{
    public partial class UcStocksForm : UserControl
    {
        internal bool IsWarehouse;

        public UcStocksForm()
        {
            InitializeComponent();
        }

        internal string GetFormErrors()
        {
            string[] errorArray = new string[]
            {
                epStockCount.GetError(nudStockCount),
            };

            return Helper.GenerateFormErrorMessage(errorArray);
        }

        internal void ResetForm()
        {
            cmbStoreWarehouse.SelectedIndex = 0;
            nudStockCount.Value = 0;
            dtpExpiration.Enabled = false;
            dtpStockDate.Enabled = false;
            chkExpiration.Checked = false;
            chkStockDate.Checked = false;
            chkSupplier.Checked = false;
            dtpRepairedDate.Checked = false;
            dtpReturnedDate.Checked = false;
        }

        internal void LoadStores()
        {
            cmbStoreWarehouse.DataSource = Factory.StoresController().Fetch();
            cmbStoreWarehouse.DisplayMember = "name";
            cmbStoreWarehouse.ValueMember = "id";
            lblStoreWarehouse.Text = "Store";
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
                LoadStores();
                LoadSuppliers();
            }
        }

        private void nudStockCount_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Helper.ShowErrorNumericUpDownEmpty(epStockCount, nudStockCount, "stocks count");
        }

        private void nudStockCount_Validated(object sender, EventArgs e)
        {
            Helper.ClearErrorNumericUpDown(epStockCount, nudStockCount);
        }

        private void chkExpiration_CheckedChanged(object sender, EventArgs e)
        {
            dtpExpiration.Enabled = chkExpiration.Checked;
        }

        private void chkStockDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpStockDate.Enabled = chkStockDate.Checked;
        }

        private void chkSupplier_CheckedChanged(object sender, EventArgs e)
        {
            cmbSupplier.Enabled = chkSupplier.Checked;
        }

        private void chkRepairedDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpRepairedDate.Enabled = chkRepairedDate.Checked;
        }

        private void chkReturnedDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpReturnedDate.Enabled = chkReturnedDate.Checked;
        }
    }
}
