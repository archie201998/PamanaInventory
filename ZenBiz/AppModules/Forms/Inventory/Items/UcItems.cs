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
            Helper.DatagridDefaultStyle(dgBranchStocks, false, true);

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
            dgBranchStocks.CurrentCell.Value = dtp.Value;
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

        private void CreateDatagridViewColumnsOnStocks(DataGridView dataGridView)
        {
            dataGridView.ColumnCount = 13;
            dataGridView.Columns[0].Name = "branch";
            dataGridView.Columns[1].Name = "item";
            dataGridView.Columns[2].Name = "serial_number";
            dataGridView.Columns[3].Name = "model";
            dataGridView.Columns[4].Name = "operating_system";
            dataGridView.Columns[5].Name = "ram";
            dataGridView.Columns[6].Name = "computer_name";
            dataGridView.Columns[7].Name = "sophos_tamper";
            dataGridView.Columns[8].Name = "date_acquired";
            dataGridView.Columns[9].Name = "unit_cost";
            dataGridView.Columns[10].Name = "status";
            dataGridView.Columns[11].Name = "remarks";
            dataGridView.Columns[12].Name = "branch_id";

            //dataGridView.Columns["branch_id"].Visible = false;
            dataGridView.Columns["item"].HeaderText = "Item Name";
            dataGridView.Columns["serial_number"].HeaderText = "Serial Number";
            dataGridView.Columns["model"].HeaderText = "Model";
            dataGridView.Columns["operating_system"].HeaderText = "Operating Sys.";
            dataGridView.Columns["ram"].HeaderText = "RAM";
            dataGridView.Columns["computer_name"].HeaderText = "Computer Name";
            dataGridView.Columns["sophos_tamper"].HeaderText = "Sophos Tamper";
            dataGridView.Columns["date_acquired"].HeaderText = "Date Acquired";
            dataGridView.Columns["unit_cost"].HeaderText = "Unit Cost";
            dataGridView.Columns["status"].HeaderText = "Status";
            dataGridView.Columns["remarks"].HeaderText = "Remarks";

            dataGridView.Columns["branch"].HeaderText = "Branches";
            dataGridView.Columns["branch"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        private void UcItems_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                CreateDatagridViewColumnsOnStocks(dgBranchStocks);
                Helper.LoadCategories(cmbCategory);
                Helper.LoadUnit(cmbUnit);

                btnEditStoreStock.Enabled = false;
                btnDeleteStoreStock.Enabled = false;
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
                Helper.LoadCategories(cmbCategory);

            form.Dispose();
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            using FrmUnitsAdd form = new();
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                Helper.LoadUnit(cmbCategory);

            form.Dispose();
        }

        private void btnAddStoreStock_Click(object sender, EventArgs e)
        {
            _ = new FrmStocksAdd(dgBranchStocks, false).ShowDialog();
        }

        private void dgStoreStocks_SelectionChanged(object sender, EventArgs e)
        {
            Helper.EnableDisableToolStripButtons(dgBranchStocks, btnEditStoreStock, btnDeleteStoreStock);
        }

        private void RemoveRow(DataGridView dataGridView)
        {
            foreach (DataGridViewRow item in dataGridView.SelectedRows)
                dataGridView.Rows.Remove(item);
        }

        private void btnDeleteStoreStock_Click(object sender, EventArgs e)
        {
            RemoveRow(dgBranchStocks);
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
            _ = new FrmStocksEdit(GetSelectedData(dgBranchStocks), dgBranchStocks, false).ShowDialog();
        }

    }
}