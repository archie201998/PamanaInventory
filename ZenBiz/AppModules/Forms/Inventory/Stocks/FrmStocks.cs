using MySql.Data.MySqlClient;
using PamanaWaterInventory.AppModules.Forms.Inventory.RepairHistory;
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
        }

        private void FrmStocks_Load(object sender, EventArgs e)
        {
            LoadItemDetails();
            LoadBranches();
            LoadBranchesStocks();
        }

        private void LoadBranchesStocks()
        {
            int branchId = (int)cmbBranches.ComboBox.SelectedValue;
            if (branchId == 0)
                dgBranchStocks.DataSource = Factory.BranchStocksController().Fetch(_itemId);
            else
                dgBranchStocks.DataSource = Factory.BranchStocksController().Fetch(branchId, _itemId);

            dgBranchStocks.Columns["stocks_id"].Visible = false;
            dgBranchStocks.Columns["item_id"].Visible = false;
            dgBranchStocks.Columns["suppliers_id"].Visible = false;
            dgBranchStocks.Columns["branches_id"].Visible = false;
            dgBranchStocks.Columns["created_at"].Visible = false;
            dgBranchStocks.Columns["created_by"].Visible = false;
            dgBranchStocks.Columns["updated_at"].Visible = false;
            dgBranchStocks.Columns["updated_by"].Visible = false;

            dgBranchStocks.Columns["branch_name"].HeaderText = "Branches";
            dgBranchStocks.Columns["serial_number"].HeaderText = "Serial Number";
            dgBranchStocks.Columns["model"].HeaderText = "Model";
            dgBranchStocks.Columns["operating_system"].HeaderText = "Operating System";
            dgBranchStocks.Columns["ram"].HeaderText = "RAM";
            dgBranchStocks.Columns["computer_name"].HeaderText = "Computer Name";
            dgBranchStocks.Columns["sophos_tamper"].HeaderText = "Sophos Tamper";
            dgBranchStocks.Columns["unit_cost"].HeaderText = "Unit Cost";
            dgBranchStocks.Columns["date_acquired"].HeaderText = "Date Acquired";
            dgBranchStocks.Columns["date_acquired"].DefaultCellStyle.Format = "MMM dd, yyyy";
            dgBranchStocks.Columns["suppliers_name"].HeaderText = "Supplier";
            dgBranchStocks.Columns["suppliers_address"].HeaderText = "Supplier Address";
            dgBranchStocks.Columns["status"].HeaderText = "Status";
            //dgBranchStocks.Columns["user"].HeaderText = "User";
            //dgBranchStocks.Columns["remarks"].HeaderText = "Remarks";

            lblTotalStoreStocks.Text = dgBranchStocks.Rows.Count.ToString();
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

    }
}
