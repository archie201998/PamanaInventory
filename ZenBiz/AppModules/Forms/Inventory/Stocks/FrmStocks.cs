using MySql.Data.MySqlClient;
using System.Data;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Inventory.Stocks
{
    public partial class FrmStocks : Form
    {
        private readonly int _itemId;

        public FrmStocks(int itemId)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            Helper.DatagridDefaultStyle(dgStoreStocks);
            Helper.DatagridDefaultStyle(dgWarehouseStocks);
            _itemId = itemId;
            cmbStores.ComboBox.SelectionChangeCommitted += cmbStores_SelectionChangeCommitted;
            cmbWarehouses.ComboBox.SelectionChangeCommitted += cmbWarehouses_SelectionChangeCommitted;
        }

        private void LoadItemDetails()
        {
            var dict = Factory.ItemsController().FindById(_itemId);
            txtCode.Text = dict["sku_code"];
            txtName.Text = dict["name"];
            txtCategory.Text = dict["category_name"];
            txtUnit.Text = dict["unit_name"];
            txtUnitCost.Text = Convert.ToDecimal(dict["unit_cost"]).ToString("N2");
            txtMinStockThreshold.Text = Convert.ToDecimal(dict["min_threshold_stock"]).ToString("N2");
        }

        private void LoadStores()
        {
            Dictionary<int, string> storesDict = new();
            DataTable dtStores = Factory.StoresController().Fetch();
            storesDict.Add(0, "All Branches");
            foreach (DataRow item in dtStores.Rows)
                storesDict.Add(Convert.ToInt32(item["id"]), item["name"].ToString());

            cmbStores.ComboBox.DataSource = new BindingSource(storesDict, null);
            cmbStores.ComboBox.DisplayMember = "Value";
            cmbStores.ComboBox.ValueMember = "key";
        }

        private void LoadWarehouses()
        {
            Dictionary<int, string> warehouseDict = new();
            DataTable dtWarehouse = Factory.StoresController().Fetch();
            warehouseDict.Add(0, "All warehouses");
            foreach (DataRow item in dtWarehouse.Rows)
                warehouseDict.Add(Convert.ToInt32(item["id"]), item["name"].ToString());

            cmbWarehouses.ComboBox.DataSource = new BindingSource(warehouseDict, null);
            cmbWarehouses.ComboBox.DisplayMember = "Value";
            cmbWarehouses.ComboBox.ValueMember = "Key";
        }

        private void FrmStocks_Load(object sender, EventArgs e)
        {
            LoadItemDetails();
            LoadStores();
            LoadWarehouses();
            LoadStoresStocks();
            LoadWarehousesStocks();

            if (dgStoreStocks.Rows.Count == 0)
            {
                btnStoreStockEdit.Enabled = false;
                btnStoreStockDelete.Enabled = false;
            }

            if (dgWarehouseStocks.Rows.Count == 0)
            {
                btnWarehouseStockEdit.Enabled = false;
                btnWarehouseStockDelete.Enabled = false;
            }
        }

        private decimal SumDatagridViewStocks(DataGridView dataGridView)
        {
            decimal total = 0;
            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                total += Convert.ToDecimal(item.Cells["quantity"].Value);
            }

            return total;
        }

        private void LoadStoresStocks()
        {
            int storeId = (int)cmbStores.ComboBox.SelectedValue;
            if (storeId == 0) dgStoreStocks.DataSource = Factory.StoreStocksController().Fetch(_itemId);
            else dgStoreStocks.DataSource = Factory.StoreStocksController().Fetch(storeId, _itemId);
            dgStoreStocks.Columns["id"].Visible = false;
            dgStoreStocks.Columns["stocks_id"].Visible = false;
            dgStoreStocks.Columns["store_name"].HeaderText = "Branches";
            dgStoreStocks.Columns["quantity"].HeaderText = "Quantity";
            dgStoreStocks.Columns["quantity"].DefaultCellStyle.Format = "N2";
            dgStoreStocks.Columns["stock_date"].HeaderText = "Stock Date";
            dgStoreStocks.Columns["stock_date"].DefaultCellStyle.Format = "MMM dd, yyyy";
            dgStoreStocks.Columns["expiration"].HeaderText = "Expiration";
            dgStoreStocks.Columns["expiration"].DefaultCellStyle.Format = "MMM dd, yyyy";
            dgStoreStocks.Columns["suppliers_name"].HeaderText = "Supplier";
            dgStoreStocks.Columns["repaired_date"].HeaderText = "Repaired Date";
            dgStoreStocks.Columns["repaired_date"].DefaultCellStyle.Format = "MMM dd, yyyy";
            dgStoreStocks.Columns["returned_date"].HeaderText = "Returned Date";
            dgStoreStocks.Columns["returned_date"].DefaultCellStyle.Format = "MMM dd, yyyy";
            dgStoreStocks.Columns["user"].HeaderText = "User";
            dgStoreStocks.Columns["status"].HeaderText = "Status";
            dgStoreStocks.Columns["remarks"].HeaderText = "Remarks";

            lblTotalStoreStocks.Text = SumDatagridViewStocks(dgStoreStocks).ToString("N2");
        }

        private void LoadWarehousesStocks()
        {
            int warehouseId = (int)cmbWarehouses.ComboBox.SelectedValue;
            if (warehouseId == 0) dgWarehouseStocks.DataSource = Factory.WarehouseStocksController().Fetch(_itemId);
            else dgWarehouseStocks.DataSource = Factory.WarehouseStocksController().Fetch(warehouseId, _itemId);
            dgWarehouseStocks.Columns["id"].Visible = false;
            dgWarehouseStocks.Columns["stocks_id"].Visible = false;
            dgWarehouseStocks.Columns["warehouse_name"].HeaderText = "Warehouse";
            dgWarehouseStocks.Columns["quantity"].HeaderText = "Quantity";
            dgWarehouseStocks.Columns["quantity"].DefaultCellStyle.Format = "N2";
            dgWarehouseStocks.Columns["stock_date"].HeaderText = "Stock Date";
            dgWarehouseStocks.Columns["stock_date"].DefaultCellStyle.Format = "MMM dd, yyyy";
            dgWarehouseStocks.Columns["expiration"].HeaderText = "Expiration";
            dgWarehouseStocks.Columns["expiration"].DefaultCellStyle.Format = "MMM dd, yyyy";
            dgWarehouseStocks.Columns["suppliers_name"].HeaderText = "Supplier";

            lblTotalWarehouseStocks.Text = SumDatagridViewStocks(dgWarehouseStocks).ToString("N2");
        }

        private void btnStoreStockAdd_Click(object sender, EventArgs e)
        {
            using FrmStocksAdd form = new(_itemId, false);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                LoadStoresStocks();

            form.Dispose();
        }

        private bool DeleteStocks(DataGridView dataGrid)
        {
            if (dataGrid.SelectedRows.Count == 0) return false;

            try
            {
                List<StocksModel> stocksModelList = new();
                foreach (DataGridViewRow item in dataGrid.SelectedRows)
                    stocksModelList.Add(new StocksModel() { Id = Convert.ToInt32(item.Cells["stocks_id"].Value) });

                var messageBox = MessageBox.Show("Are you sure you want to delete this data?", "Deleting Stocks", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messageBox != DialogResult.Yes) return false;

                return Factory.StocksController().Delete(stocksModelList);
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                    Helper.MessageBoxError("Unable to delete the record/s because it is already been referenced to other records.");
                else
                    Helper.MessageBoxError(ex.Message);
            }

            return false;
        }

        private void btnStoreStockEdit_Click(object sender, EventArgs e)
        {
            int rowIndex = dgStoreStocks.CurrentCell.RowIndex;
            int stockId = (int)dgStoreStocks.Rows[rowIndex].Cells["stocks_id"].Value;
            using FrmStocksEdit form = new(_itemId, stockId, false);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                LoadStoresStocks();

            form.Dispose();
        }

        private void btnStoreStockDelete_Click(object sender, EventArgs e)
        {
            if (DeleteStocks(dgStoreStocks)) LoadStoresStocks();
        }

        private void btnWarehouseStockAdd_Click(object sender, EventArgs e)
        {
            using FrmStocksAdd form = new(_itemId, true);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                LoadWarehousesStocks();

            form.Dispose();
        }

        private void btnWarehouseStockEdit_Click(object sender, EventArgs e)
        {
            int rowIndex = dgWarehouseStocks.CurrentCell.RowIndex;
            int stockId = (int)dgWarehouseStocks.Rows[rowIndex].Cells["stocks_id"].Value;
            using FrmStocksEdit form = new(_itemId, stockId, true);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                LoadWarehousesStocks();
            }

            form.Dispose();
        }

        private void btnWarehouseStockDelete_Click(object sender, EventArgs e)
        {
            if (DeleteStocks(dgWarehouseStocks)) LoadWarehousesStocks();
        }

        private void cmbStores_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadStoresStocks();
        }

        private void cmbWarehouses_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadWarehousesStocks();
        }

        private void dgStoreStocks_SelectionChanged(object sender, EventArgs e)
        {
            Helper.EnableDisableToolStripButtons(dgStoreStocks, btnStoreStockEdit, btnStoreStockDelete);
        }

        private void dgWarehouseStocks_SelectionChanged(object sender, EventArgs e)
        {
            Helper.EnableDisableToolStripButtons(dgWarehouseStocks, btnWarehouseStockEdit, btnWarehouseStockDelete);
        }

        private void FrmStocks_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
