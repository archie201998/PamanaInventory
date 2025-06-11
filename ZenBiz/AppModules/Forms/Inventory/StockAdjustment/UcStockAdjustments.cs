using System.ComponentModel;

namespace ZenBiz.AppModules.Forms.Inventory.StockAdjustment
{
    public partial class UcStockAdjustments : UserControl
    {
        internal bool IsWarehouse;
        public UcStockAdjustments()
        {
            InitializeComponent();
        }

        internal string GetFormErrors()
        {
            string[] errorArray = new string[]
            {
                epQuantity.GetError(nudQuantity),
                epReason.GetError(txtReason)
            };

            return Helper.GenerateFormErrorMessage(errorArray);
        }

        internal void LoadStores()
        {
            cmbStoreWarehouse.DataSource = Factory.StoresController().Fetch();
            cmbStoreWarehouse.DisplayMember = "name";
            cmbStoreWarehouse.ValueMember = "id";
            lblStoreWarehouse.Text = "Store";
        }
        private void UcStockAdjustments_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                LoadStores();
            }
        }

        private void UcStockAdjustments_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Helper.ShowErrorNumericUpDownEmpty(epQuantity, nudQuantity, "quantity");
        }

        private void UcStockAdjustments_Validated(object sender, EventArgs e)
        {
            Helper.ClearErrorNumericUpDown(epQuantity, nudQuantity);
        }

        private void txtReason_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Helper.ShowErrorTextBoxEmpty(epReason, txtReason, "reason");
        }

        private void txtReason_Validated(object sender, EventArgs e)
        {
            Helper.ClearErrorTextBox(epReason, txtReason);
        }

    }
}
