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
            Helper.DatagridDefaultStyle(dgBranchStocks);
            _itemId = itemId;
            cmbStores.ComboBox.SelectionChangeCommitted += cmbStores_SelectionChangeCommitted;
        }

        private void LoadItemDetails()
        {
            var dict = Factory.ItemsController().FindById(_itemId);
            txtCode.Text = dict["sku_code"];
            txtName.Text = dict["name"];
            txtCategory.Text = dict["category_name"];
            txtUnit.Text = dict["unit_name"];
        }

        private void LoadBranches()
        {
            Dictionary<int, string> storesDict = new();
            DataTable dtBranches = Factory.BranchesController().Fetch();
            storesDict.Add(0, "All Branches");
            foreach (DataRow item in dtBranches.Rows)
                storesDict.Add(Convert.ToInt32(item["id"]), item["name"].ToString());

            cmbStores.ComboBox.DataSource = new BindingSource(storesDict, null);
            cmbStores.ComboBox.DisplayMember = "Value";
            cmbStores.ComboBox.ValueMember = "key";
        }

        private void FrmStocks_Load(object sender, EventArgs e)
        {
            LoadItemDetails();
            LoadBranches();
            LoadBranchesStocks();
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

        private void LoadBranchesStocks()
        {
            int branchId = (int)cmbStores.ComboBox.SelectedValue;

            if (branchId == 0) 
                dgBranchStocks.DataSource = Factory.BranchStocksController().Fetch(_itemId);
            else 
                dgBranchStocks.DataSource = Factory.BranchStocksController().Fetch(branchId, _itemId);

            dgBranchStocks.Columns["id"].Visible = false;
            dgBranchStocks.Columns["stocks_id"].Visible = false;
            dgBranchStocks.Columns["branch_name"].HeaderText = "Branches";
            dgBranchStocks.Columns["quantity"].HeaderText = "Quantity";
            dgBranchStocks.Columns["quantity"].DefaultCellStyle.Format = "N2";
            dgBranchStocks.Columns["stock_date"].HeaderText = "Stock Date";
            dgBranchStocks.Columns["stock_date"].DefaultCellStyle.Format = "MMM dd, yyyy";
            dgBranchStocks.Columns["expiration"].HeaderText = "Expiration";
            dgBranchStocks.Columns["expiration"].DefaultCellStyle.Format = "MMM dd, yyyy";
            dgBranchStocks.Columns["suppliers_name"].HeaderText = "Supplier";
            dgBranchStocks.Columns["repaired_date"].HeaderText = "Repaired Date";
            dgBranchStocks.Columns["repaired_date"].DefaultCellStyle.Format = "MMM dd, yyyy";
            dgBranchStocks.Columns["returned_date"].HeaderText = "Returned Date";
            dgBranchStocks.Columns["returned_date"].DefaultCellStyle.Format = "MMM dd, yyyy";
            dgBranchStocks.Columns["user"].HeaderText = "User";
            dgBranchStocks.Columns["status"].HeaderText = "Status";
            dgBranchStocks.Columns["remarks"].HeaderText = "Remarks";

            lblTotalStoreStocks.Text = SumDatagridViewStocks(dgBranchStocks).ToString("N2");
        }

        

        private void btnStoreStockAdd_Click(object sender, EventArgs e)
        {
            using FrmStocksAdd form = new(_itemId);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                LoadBranchesStocks();

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
            int rowIndex = dgBranchStocks.CurrentCell.RowIndex;
            int stockId = (int)dgBranchStocks.Rows[rowIndex].Cells["stocks_id"].Value;
            using FrmStocksEdit form = new(_itemId, stockId, false);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                LoadBranchesStocks();

            form.Dispose();
        }

        private void btnStoreStockDelete_Click(object sender, EventArgs e)
        {
            if (DeleteStocks(dgBranchStocks)) LoadBranchesStocks();
        }


        private void cmbStores_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadBranchesStocks();
        }

        private void dgStoreStocks_SelectionChanged(object sender, EventArgs e)
        {
            Helper.EnableDisableToolStripButtons(dgBranchStocks, btnStoreStockEdit, btnStoreStockDelete);
        }

        private void FrmStocks_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
