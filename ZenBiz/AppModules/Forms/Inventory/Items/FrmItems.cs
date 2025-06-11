using MySql.Data.MySqlClient;
using System.Data;
using ZenBiz.AppModules.Forms.Inventory.StockAdjustment;
using ZenBiz.AppModules.Forms.Inventory.Stocks;
using ZenBiz.AppModules.Inventory;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Inventory.Items
{
    public partial class FrmItems : Form
    {
        private readonly frmInventory _frmInventory;

        public FrmItems(frmInventory frmInventory)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            Helper.DatagridDefaultStyle(dgItems, true);
            Helper.DatagridDefaultStyle(dgBranchStocks);
            CreateStocksColumns(dgBranchStocks, false);
            _frmInventory = frmInventory;
        }

        private void CreateStocksColumns(DataGridView dataGrid, bool isWarehouse)
        {
            dataGrid.ColumnCount = 3;
            dataGrid.Columns[0].Name = "id";
            dataGrid.Columns[1].Name = "name";
            dataGrid.Columns[2].Name = "stocks_left";
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.Columns["id"].Visible = false;
            dataGrid.Columns["name"].HeaderText = isWarehouse ? "Warehouse" : "Branch";
            dataGrid.Columns["stocks_left"].HeaderText = "Stocks Left";
            dataGrid.Columns["stocks_left"].DefaultCellStyle.Format = "N2";
            dataGrid.Columns["stocks_left"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void LoadItems()
        {
            dgItems.DataSource = Factory.ItemsController().Fetch();
            dgItems.Columns["id"].Visible = false;
            dgItems.Columns["code"].HeaderText = "Code";
            dgItems.Columns["name"].HeaderText = "Item";
            dgItems.Columns["category_name"].HeaderText = "Category";
            dgItems.Columns["unit_name"].HeaderText = "Unit";
            dgItems.Columns["name"].Width = 300;
            CountRecords();
        }
        private void CountRecords()
        {
            lblRecordCount.Text = dgItems.Rows.Count.ToString();
        }

        // need pa ug minus ang total stocks sa sold
        private void LoadBranches()
        {
            dgBranchStocks.Rows.Clear();
            int itemId = (int)dgItems.SelectedCells[0].Value;
            DataTable dtBranhes = Factory.BranchStocksController().FetchBranches(itemId);
            foreach (DataRow item in dtBranhes.Rows)
            {
                int storeId = (int)item["branches_id"];
                string storeName = item["branch_name"].ToString();
                // total stocks + total stock adjusted + total transfer stocks + sold stocks
                decimal stocksLeft = Factory.BranchStocksController().StocksLeft(storeId, itemId);
                dgBranchStocks.Rows.Add(storeId, storeName, stocksLeft.ToString("N2"));
            }
        }

        private void FrmItems_Load(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using FrmItemsAdd form = new();
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                LoadItems();

            form.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int itemId = (int)dgItems.SelectedCells[0].Value;
            using FrmItemsEdit form = new(itemId);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                LoadItems();

            form.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgItems.SelectedRows.Count == 0) return;

            try
            {
                List<ItemsModel> itemModelList = new();
                foreach (DataGridViewRow item in dgItems.SelectedRows)
                    itemModelList.Add(new ItemsModel() { Id = Convert.ToInt32(item.Cells["id"].Value) });

                var messageBox = MessageBox.Show("Are you sure you want to delete this data?", "Deleting Items", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messageBox != DialogResult.Yes) return;

                _ = Factory.ItemsController().Delete(itemModelList);
                LoadItems();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                    Helper.MessageBoxError("Unable to delete the record/s because it is already been referenced to other records.");
                else
                    Helper.MessageBoxError(ex.Message);
            }
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            int itemId = (int)dgItems.SelectedCells[0].Value;
            using FrmStocks form = new(itemId);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                LoadBranches();
            }

            form.Dispose();
        }

        private void btnAdjustStocks_Click(object sender, EventArgs e)
        {
            int itemId = (int)dgItems.SelectedCells[0].Value;
            using FrmStockAdjustment form = new(itemId);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                LoadBranches();
            }

            form.Dispose();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dgItems.DataSource).DefaultView.RowFilter = string.Format("name LIKE '%{0}%'", txtSearch.Text);
        }

        private void dgItems_SelectionChanged(object sender, EventArgs e)
        {
            Helper.EnableDisableButtons(dgItems, btnEdit, btnDelete);
            if (dgItems.SelectedRows.Count == 1)
            {
                LoadBranches();
                btnStocks.Enabled = true;
                btnAdjustStocks.Enabled = true;
                return;
            }

            dgBranchStocks.Rows.Clear();
            btnStocks.Enabled = false;
            btnAdjustStocks.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
