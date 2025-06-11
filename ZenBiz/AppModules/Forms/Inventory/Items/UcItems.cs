using ZenBiz.AppModules.Forms.Inventory.Items;
using ZenBiz.AppModules.Forms.Inventory.UnitOfMeasurements;
using ZenBiz.AppModules.Inventory.Categories;

namespace ZenBiz.AppModules.Inventory.Items
{
    public partial class UcItems : UserControl
    {
        public UcItems()
        {
            InitializeComponent();
            Helper.DatagridDefaultStyle(dgStoreStocks, false, true);

        }

        internal void SumStocks(DataGridView dataGridView, Label lblTotalStocks)
        {
            decimal total = 0;
            foreach (DataGridViewRow item in dataGridView.Rows)
                total += Convert.ToDecimal(item.Cells["stocks"].Value);
                
            lblTotalStocks.Text = total.ToString("N2");
        }

        private void DateTimePickerDgStoreStocks_ValueChange(object sender, EventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            dgStoreStocks.CurrentCell.Value = dtp.Value;
        }


        internal string GetFormErrors()
        {
            string[] errorArray = new string[]
            {
                epCode.GetError(txtCode),
                epName.GetError(txtName),
            };

            return Helper.GenerateFormErrorMessage(errorArray);
        }

        private void CreateDatagridViewColumnsOnStocks(DataGridView dataGridView, bool isStoreType)
        {
            string columnName = isStoreType ? "store" : "warehouse";
            string columnHeaderText = isStoreType ? "Store" : "Warehouse";

            dataGridView.ColumnCount = 5;
            dataGridView.Columns[0].Name = "stocks";
            dataGridView.Columns["stocks"].HeaderText = "Stocks";
            dataGridView.Columns["stocks"].Width = 70;
            dataGridView.Columns[1].Name = "expiration";
            dataGridView.Columns["expiration"].HeaderText = "Expiration";
            dataGridView.Columns[2].Name = "stock_date";
            dataGridView.Columns["stock_date"].HeaderText = "Stock Date";
            dataGridView.Columns[3].Name = columnName;
            dataGridView.Columns[columnName].HeaderText = columnHeaderText;
            dataGridView.Columns[columnName].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[4].Name = "store_warehouse_id";
            dataGridView.Columns["store_warehouse_id"].Visible = false;
        }

        private void LoadCategories()
        {
            cmbCategory.DataSource = Factory.CategoriesController().Fetch();
            cmbCategory.DisplayMember = "name";
            cmbCategory.ValueMember = "id";
        }

        private void LoadUnit()
        {
            cmbUnit.DataSource = Factory.UnitsOfMeasurementsController().Fetch();
            cmbUnit.DisplayMember = "name";
            cmbUnit.ValueMember = "id";
        }

        private void UcItems_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                CreateDatagridViewColumnsOnStocks(dgStoreStocks, true);
                LoadCategories();
                LoadUnit();
                btnEditStoreStock.Enabled = false;
                btnDeleteStoreStock.Enabled = false;

                if (Helper.UserType == "Staff")
                {
                }
            }
        }

        private void txtCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = Helper.ShowErrorTextBoxEmpty(epCode, txtCode, "code");
        }

        private void txtCode_Validated(object sender, EventArgs e)
        {
            Helper.ClearErrorTextBox(epCode, txtCode);
        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = Helper.ShowErrorTextBoxEmpty(epName, txtName, "name");
        }

        private void txtName_Validated(object sender, EventArgs e)
        {
            Helper.ClearErrorTextBox(epName, txtName);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            using FrmCategoriesAdd form = new();
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                LoadCategories();

            form.Dispose();
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            using FrmUnitsAdd form = new();
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                LoadUnit();

            form.Dispose();
        }

        private void btnAddStoreStock_Click(object sender, EventArgs e)
        {
            _ = new FrmStocksAdd(dgStoreStocks, false).ShowDialog();
        }

        private void dgStoreStocks_SelectionChanged(object sender, EventArgs e)
        {
            Helper.EnableDisableToolStripButtons(dgStoreStocks, btnEditStoreStock, btnDeleteStoreStock);
        }

        private void RemoveRow(DataGridView dataGridView)
        {
            foreach (DataGridViewRow item in dataGridView.SelectedRows)
                dataGridView.Rows.Remove(item);
        }

        private void btnDeleteStoreStock_Click(object sender, EventArgs e)
        {
            RemoveRow(dgStoreStocks);
        }

        private void btnDeleteWarehouseStock_Click(object sender, EventArgs e)
        {
        }

        private Dictionary<string, string> GetSelectedData(DataGridView dataGridView)
        {
            int rowIndex = dataGridView.CurrentCell.RowIndex;
            Dictionary<string, string> data = new()
            {
                { "stocks", dataGridView.Rows[rowIndex].Cells["stocks"].Value.ToString() },
                { "expiration", dataGridView.Rows[rowIndex].Cells["expiration"].Value.ToString() },
                { "stock_date", dataGridView.Rows[rowIndex].Cells["stock_date"].Value.ToString() },
                { "store_warehouse_id", dataGridView.Rows[rowIndex].Cells["store_warehouse_id"].Value.ToString() },
            };

            return data;
        }

        private void btnEditStoreStock_Click(object sender, EventArgs e)
        {
            _ = new FrmStocksEdit(GetSelectedData(dgStoreStocks), dgStoreStocks, false).ShowDialog();
        }

    }
}