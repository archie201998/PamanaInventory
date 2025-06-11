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
            _data = selectedData;
            _dgStocks = dgStocks;
            Text = isWarehouse ? "Edit Warehouse Stock" : "Edit Store Stock";
        }

        private void LoadSelectedData()
        {
            uc.cmbStoreWarehouse.SelectedValue = Convert.ToInt32(_data["store_warehouse_id"]);
          

            if (!string.IsNullOrWhiteSpace(_data["stock_date"]))
            {
                uc.dtpStockDate.Value = Convert.ToDateTime(_data["stock_date"]);
                uc.chkStockDate.Checked = true;
                uc.dtpStockDate.Enabled = true;
            }
        }

        private void FrmStocksEdit_Load(object sender, EventArgs e)
        {
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
            string stockDate = uc.chkStockDate.Checked ? uc.dtpStockDate.Value.ToShortDateString() : "";

            if (!UpdateStock()) return;
            var storeWarehouseId = uc.cmbStoreWarehouse.SelectedValue.ToString();
            string storeWarehouseText = uc.cmbStoreWarehouse.Text;
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
}
