using MySql.Data.MySqlClient;
using ZenBiz.AppModules.Forms.Inventory.Items;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Inventory.StockAdjustment
{
    public partial class FrmStockAdjustment : Form
    {
        private readonly UcItemDetailsDisplay uc;
        private readonly int _itemId;

        public FrmStockAdjustment(int itemId)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            Helper.DatagridDefaultStyle(dgStoreStockAdjust, true);
            Helper.DatagridDefaultStyle(dgWarehouseStockAdjust, true);
            uc = ucItemDetailsDisplay1;
            uc.ItemId = itemId;
            _itemId = itemId;
        }

        private void LoadStoreData()
        {
            dgStoreStockAdjust.DataSource = Factory.StoreStockAdjustmentController().Fetch(_itemId);
            dgStoreStockAdjust.Columns["id"].Visible = false;
            dgStoreStockAdjust.Columns["stores_id"].Visible = false;
            dgStoreStockAdjust.Columns["store_name"].HeaderText = "Store";
            dgStoreStockAdjust.Columns["quantity"].HeaderText = "Quantity";
            dgStoreStockAdjust.Columns["quantity"].Width = 100;
            dgStoreStockAdjust.Columns["date_adjusted"].HeaderText = "Date";
            dgStoreStockAdjust.Columns["date_adjusted"].DefaultCellStyle.Format = "MMM dd, yyyy";
            dgStoreStockAdjust.Columns["reason"].HeaderText = "Reason";
        }

        private void LoadWarehouseData()
        {
            dgWarehouseStockAdjust.DataSource = Factory.WarehouseStockAdjustmentController().Fetch(_itemId);
            dgWarehouseStockAdjust.Columns["id"].Visible = false;
            dgWarehouseStockAdjust.Columns["warehouses_id"].Visible = false;
            dgWarehouseStockAdjust.Columns["warehouse_name"].HeaderText = "Store";
            dgWarehouseStockAdjust.Columns["quantity"].HeaderText = "Quantity";
            //dgWarehouseStockAdjust.Columns["quantity"].Width = 100;
            dgWarehouseStockAdjust.Columns["date_adjusted"].HeaderText = "Date";
            dgWarehouseStockAdjust.Columns["date_adjusted"].DefaultCellStyle.Format = "MMM dd, yyyy";
            dgWarehouseStockAdjust.Columns["reason"].HeaderText = "Reason";
        }

        private void FrmStockAdjustment_Load(object sender, EventArgs e)
        {
            LoadStoreData();
            LoadWarehouseData();
            if (dgStoreStockAdjust.Rows.Count == 0)
            {
                btnStoreStockEdit.Enabled = false;
                btnStoreStockDelete.Enabled = false;
            }

            if (dgWarehouseStockAdjust.Rows.Count == 0)
            {
                btnWarehouseStockEdit.Enabled = false;
                btnWarehouseStockDelete.Enabled = false;
            }
        }

        private void dgStoreStockAdjust_SelectionChanged(object sender, EventArgs e)
        {
            Helper.EnableDisableToolStripButtons(dgStoreStockAdjust, btnStoreStockEdit, btnStoreStockDelete);
        }

        private void dgWarehouseStockAdjust_SelectionChanged(object sender, EventArgs e)
        {
            Helper.EnableDisableToolStripButtons(dgWarehouseStockAdjust, btnWarehouseStockEdit, btnWarehouseStockDelete);
        }

        private void btnStoreStockAdd_Click(object sender, EventArgs e)
        {
            using FrmStockAdjustmentAdd form = new(_itemId, false);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                LoadStoreData();

            form.Dispose();
        }

        private void btnStoreStockEdit_Click(object sender, EventArgs e)
        {
            int storeStockAdjustmentId = (int)dgStoreStockAdjust.SelectedCells[0].Value;
            using FrmStockAdjustmentEdit form = new(storeStockAdjustmentId, _itemId, false);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                LoadStoreData();

            form.Dispose();
        }

        private void btnStoreStockDelete_Click(object sender, EventArgs e)
        {
            if (dgStoreStockAdjust.SelectedRows.Count == 0) return;

            try
            {
                List<BranchStockAdjustmentsModel> storeStockAdjustmentsModels = new();
                foreach (DataGridViewRow item in dgStoreStockAdjust.SelectedRows)
                    storeStockAdjustmentsModels.Add(new BranchStockAdjustmentsModel() { Id = Convert.ToInt32(item.Cells["id"].Value) });

                var messageBox = MessageBox.Show("Are you sure you want to delete this data?", "Deleting Stock Adjustment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messageBox != DialogResult.Yes) return;

                _ = Factory.StoreStockAdjustmentController().Delete(storeStockAdjustmentsModels);
                LoadStoreData();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                    Helper.MessageBoxError("Unable to delete the record/s because it is already been referenced to other records.");
                else
                    Helper.MessageBoxError(ex.Message);
            }
        }

        private void btnWarehouseStockAdd_Click(object sender, EventArgs e)
        {
            using FrmStockAdjustmentAdd form = new(_itemId, true);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                LoadWarehouseData();

            form.Dispose();
        }

        private void btnWarehouseStockEdit_Click(object sender, EventArgs e)
        {
            int warehouseStockAdjustmentId = (int)dgWarehouseStockAdjust.SelectedCells[0].Value;
            using FrmStockAdjustmentEdit form = new(warehouseStockAdjustmentId, _itemId, true);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                LoadWarehouseData();

            form.Dispose();
        }

        private void btnWarehouseStockDelete_Click(object sender, EventArgs e)
        {
            if (dgWarehouseStockAdjust.SelectedRows.Count == 0) return;

            try
            {
                List<WarehouseStockAdjustmentsModel> warehouseStockAdjustmentsModels = new();
                foreach (DataGridViewRow item in dgWarehouseStockAdjust.SelectedRows)
                    warehouseStockAdjustmentsModels.Add(new WarehouseStockAdjustmentsModel() { Id = Convert.ToInt32(item.Cells["id"].Value) });

                var messageBox = MessageBox.Show("Are you sure you want to delete this data?", "Deleting Stock Adjustment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messageBox != DialogResult.Yes) return;

                _ = Factory.WarehouseStockAdjustmentController().Delete(warehouseStockAdjustmentsModels);
                LoadWarehouseData();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                    Helper.MessageBoxError("Unable to delete the record/s because it is already been referenced to other records.");
                else
                    Helper.MessageBoxError(ex.Message);
            }
        }

        private void FrmStockAdjustment_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
