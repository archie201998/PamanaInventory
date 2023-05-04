namespace ZenBiz.AppModules.Forms.Inventory.Items
{
    public partial class FrmStocksEdit : Form
    {
        private readonly UcStocksForm uc;
        private readonly Dictionary<string, string> _data;
        private readonly DataGridView _dgStocks;

        public FrmStocksEdit(Dictionary<string, string> selectedData, DataGridView dgStocks, bool isWarehouse)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            uc = ucStocksForm1;
            uc.IsWarehouse = isWarehouse;
            _data = selectedData;
            _dgStocks = dgStocks;
            Text = isWarehouse ? "Edit Warehouse Stock" : "Edit Store Stock";
        }

        private void LoadSelectedData()
        {
            uc.cmbStoreWarehouse.SelectedValue = Convert.ToInt32(_data["store_warehouse_id"]);
            uc.nudStockCount.Value = Convert.ToDecimal(_data["stocks"]);
            if (!string.IsNullOrEmpty(_data["expiration"]))
            {
                uc.dtpExpiration.Value = Convert.ToDateTime(_data["expiration"]);
                uc.chkExpiration.Checked = true;
                uc.dtpExpiration.Enabled = true;

            }

            if (!string.IsNullOrWhiteSpace(_data["stock_date"]))
            {
                uc.dtpStockDate.Value = Convert.ToDateTime(_data["stock_date"]);
                uc.chkStockDate.Checked = true;
                uc.dtpStockDate.Enabled = true;
            }
        }

        private void FrmStocksEdit_Load(object sender, EventArgs e)
        {
            uc.dtpExpiration.Enabled = false;
            uc.dtpStockDate.Enabled = false;
            LoadSelectedData();
        }

        private bool UpdateStock()
        {
            if (!uc.ValidateChildren())
            {
                Helper.MessageBoxError(uc.GetFormErrors());
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string expirationDate = uc.chkExpiration.Checked ? uc.dtpExpiration.Value.ToShortDateString() : "";
            string stockDate = uc.chkStockDate.Checked ? uc.dtpStockDate.Value.ToShortDateString() : "";

            if (!UpdateStock()) return;
            var stockCount = uc.nudStockCount.Value.ToString("N2");
            var storeWarehouseId = uc.cmbStoreWarehouse.SelectedValue.ToString();
            string storeWarehouseText = uc.cmbStoreWarehouse.Text;
            string columnName = uc.IsWarehouse ? "warehouse" : "store";
            string[] row = new string[]
            {
                    stockCount,
                    expirationDate,
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
                    item.Cells["stocks"].Value = stockCount;
                    item.Cells["expiration"].Value = expirationDate;
                    item.Cells["stock_date"].Value = stockDate;
                    item.Cells[columnName].Value = storeWarehouseText;
                }
            }

            if (!storeOrWarehouseExist) _dgStocks.Rows.Add(row);
            uc.ResetForm();
        }
    }
}
