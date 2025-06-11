namespace ZenBiz.AppModules.Forms.Inventory.Items
{
    public partial class FrmStocksAdd : Form
    {
        private readonly UcStocksForm uc;
        private readonly DataGridView _dgStocks;
        public DataGridViewRow rowStoreStocks = new();

        public FrmStocksAdd(DataGridView dgStocks, bool isWarehouse)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            uc = ucStocksForm1;
            _dgStocks = dgStocks;
            Text = isWarehouse ? "Add Warehouse Stock" : "Add Store Stock";
        }

        private bool AddStock()
        {
            if (!uc.ValidateChildren())
            {
                Helper.MessageBoxError(uc.GetFormErrors());
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string stockDate = uc.chkStockDate.Checked ? uc.dtpDateAcquired.Value.ToShortDateString() : "";

            if (AddStock())
            {
                var storeWarehouseId = uc.cmbBranch.SelectedValue.ToString();
                string storeWarehouseText = uc.cmbBranch.Text;
                string[] row = new string[]
                {
                    stockDate,
                    storeWarehouseText,
                    storeWarehouseId,
                };

                bool storeOrWarehouseExist = false;
                foreach (DataGridViewRow item in _dgStocks.Rows)
                {
                    if (item.Cells["store_warehouse_id"].Value.ToString() == storeWarehouseId)
                    {
                        storeOrWarehouseExist = true;
                        item.Cells["stock_date"].Value = stockDate;
                    }
                }

                if (!storeOrWarehouseExist) _dgStocks.Rows.Add(row);
                uc.ResetForm();
            }
        }

        private void FrmStoreStocksAdd_Load(object sender, EventArgs e)
        {
            uc.dtpDateAcquired.Enabled = false;
        }
    }
}
