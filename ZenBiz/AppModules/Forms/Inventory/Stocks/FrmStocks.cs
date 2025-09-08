using MySql.Data.MySqlClient;
using PamanaWaterInventory.AppModules.Forms.Inventory.RepairHistory;
using PamanaWaterInventory.AppModules.Forms.Inventory.UserHistory;
using System.Data;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Inventory.Stocks
{
    public partial class FrmStocks : Form
    {
        private readonly int _itemId;
        private readonly int _branchId;

        public FrmStocks(int branchId, int itemId)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            Helper.DatagridDefaultStyle(dgBranchStocks);
            _itemId = itemId;
            _branchId = branchId;   
            cmbBranches.ComboBox.SelectionChangeCommitted += cmbStores_SelectionChangeCommitted;
        }

        private void LoadItemDetails()
        {
            var dict = Factory.ItemsController().FindById(_itemId);
            txtCode.Text = dict["code"];
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

            cmbBranches.ComboBox.DataSource = new BindingSource(storesDict, null);
            cmbBranches.ComboBox.DisplayMember = "Value";
            cmbBranches.ComboBox.ValueMember = "key";
            cmbBranches.ComboBox.SelectedValue = _branchId; 
        }

        private void FrmStocks_Load(object sender, EventArgs e)
        {
            LoadBranches();
            LoadBranchesStocks();
            LoadItemDetails();
        }

        private void LoadBranchesStocks()
        {
            try
            {
                int branchId = 0;
                if (cmbBranches.ComboBox.SelectedValue != null)
                {
                    branchId = (int)cmbBranches.ComboBox.SelectedValue;
                }

                // Fetch data
                var dataSource = branchId == 0
                    ? Factory.BranchStocksController().Fetch(_itemId)
                    : Factory.BranchStocksController().Fetch(branchId, _itemId);

                dgBranchStocks.DataSource = dataSource;

                // Check if data source is not null and has data
                if (dataSource == null || dgBranchStocks.Columns.Count == 0)
                {
                    lblTotalStoreStocks.Text = "0";
                    return;
                }

                // Hide columns - check if they exist first
                HideColumnIfExists("stocks_id");
                HideColumnIfExists("item_id");
                HideColumnIfExists("suppliers_id");
                HideColumnIfExists("item_code");
                HideColumnIfExists("item_name");
                HideColumnIfExists("category_name");
                HideColumnIfExists("categories_id");
                HideColumnIfExists("abbreviation");
                HideColumnIfExists("unit_measurements_name");
                HideColumnIfExists("branches_id");
                HideColumnIfExists("created_at");
                HideColumnIfExists("created_by");
                HideColumnIfExists("updated_at");
                HideColumnIfExists("updated_by");

                // Set headers - check if columns exist first
                SetColumnHeaderIfExists("branch_name", "Branch");
                SetColumnHeaderIfExists("serial_number", "Serial Number");
                SetColumnHeaderIfExists("model", "Model");
                SetColumnHeaderIfExists("operating_system", "Operating System");
                SetColumnHeaderIfExists("ram", "RAM");
                SetColumnHeaderIfExists("computer_name", "Computer Name");
                SetColumnHeaderIfExists("sophos_tamper", "Sophos Tamper");
                SetColumnHeaderIfExists("suppliers_name", "Supplier");
                SetColumnHeaderIfExists("suppliers_address", "Supplier Address");
                SetColumnHeaderIfExists("status", "Status");
                SetColumnHeaderIfExists("remarks", "Remarks");

                // Format columns if they exist
                if (dgBranchStocks.Columns.Contains("unit_cost"))
                {
                    dgBranchStocks.Columns["unit_cost"].HeaderText = "Unit Cost";
                    dgBranchStocks.Columns["unit_cost"].DefaultCellStyle.Format = "N2";
                }

                if (dgBranchStocks.Columns.Contains("date_acquired"))
                {
                    dgBranchStocks.Columns["date_acquired"].HeaderText = "Date Acquired";
                    dgBranchStocks.Columns["date_acquired"].DefaultCellStyle.Format = "MMM dd, yyyy";
                }

                lblTotalStoreStocks.Text = dgBranchStocks.Rows.Count.ToString();

                // Auto adjust columns size
                dgBranchStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgBranchStocks.AutoResizeColumns();
                dgBranchStocks.ClearSelection();
            }
            catch (Exception ex)
            {
                // Log the actual error for debugging
                MessageBox.Show($"Error loading branch stocks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Or log to your logging system
                // Logger.LogError(ex, "Error in LoadBranchStocks");
            }

        }

        // Helper methods
        private void HideColumnIfExists(string columnName)
        {
            if (dgBranchStocks.Columns.Contains(columnName))
            {
                dgBranchStocks.Columns[columnName].Visible = false;
            }
        }

        private void SetColumnHeaderIfExists(string columnName, string headerText)
        {
            if (dgBranchStocks.Columns.Contains(columnName))
            {
                dgBranchStocks.Columns[columnName].HeaderText = headerText;
            }
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
            Helper.EnableDisableToolStripButtons_Repair_User_History(dgBranchStocks, btnRepairs, btnUsersHistory);
        }

        private void FrmStocks_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cmbBranches_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dgBranchStocks.CurrentCell != null && dgBranchStocks.CurrentCell.RowIndex >= 0)
            {
                int rowIndex = dgBranchStocks.CurrentCell.RowIndex;
                object stockIdValue = dgBranchStocks.Rows[rowIndex].Cells["stocks_id"].Value;
                string serialNumber = dgBranchStocks.Rows[rowIndex].Cells["serial_number"].Value?.ToString() ?? string.Empty;


                if (stockIdValue != null && int.TryParse(stockIdValue.ToString(), out int stockId))
                {
                    _ = new frmRepairHistory(stockId, serialNumber).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid or missing stock ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid row first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dgBranchStocks.ClearSelection();
            if (dgBranchStocks.CurrentCell != null)
            {
                int rowIndex = dgBranchStocks.CurrentCell.RowIndex;
                object stockIdValue = dgBranchStocks.Rows[rowIndex].Cells["stocks_id"].Value;
                string serialNumber = dgBranchStocks.Rows[rowIndex].Cells["serial_number"].Value?.ToString() ?? string.Empty;

                if (stockIdValue != null && int.TryParse(stockIdValue.ToString(), out int stockId))
                {
                    _ = new frmStockUserHistory(stockId, serialNumber).ShowDialog();
                }
            }
        }
           
    }
}
