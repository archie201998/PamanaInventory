using System.Data;
using ZenBiz.AppModules.Forms.Purchases;
using ZenBiz.AppModules.Forms.Sales;

namespace ZenBiz.AppModules.Forms.Components
{
    public partial class FrmItemSearch : Form
    {
        internal int ItemId;
        private readonly UcPurchaseForm _ucPurchaseForm;
        private readonly UcSalesForm _ucSalesForm;

        public FrmItemSearch(UcPurchaseForm ucPurchaseForm, UcSalesForm ucSalesForm)
        {
            InitializeComponent();

            Helper.LoadFormIcon(this);
            Helper.DatagridDefaultStyle(dgItems);
            Helper.FormDialogDefaults(this);

            _ucSalesForm = ucSalesForm;
            _ucPurchaseForm = ucPurchaseForm;
        }

        private void LoadStores()
        {
            cmbStores.DataSource = Factory.StoresController().Fetch();
            cmbStores.DisplayMember = "name";
            cmbStores.ValueMember = "id";
        }

        private void CreateColumns()
        {
            dgItems.ColumnCount = 9;
            dgItems.Columns[0].Name = "id";
            dgItems.Columns[1].Name = "sku_code";
            dgItems.Columns[2].Name = "name";
            dgItems.Columns[3].Name = "category_name";
            dgItems.Columns[4].Name = "unit_name";
            dgItems.Columns[5].Name = "retail_price";
            dgItems.Columns[6].Name = "wholesale_price";
            dgItems.Columns[7].Name = "special_price";
            dgItems.Columns[8].Name = "stocks_left";

            dgItems.Columns["id"].Visible = false;
            dgItems.Columns["sku_code"].HeaderText = "Code";
            dgItems.Columns["name"].HeaderText = "Item";
            dgItems.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgItems.Columns["category_name"].HeaderText = "Category";
            dgItems.Columns["unit_name"].HeaderText = "Unit";
            dgItems.Columns["retail_price"].HeaderText = "Retail Price";
            dgItems.Columns["wholesale_price"].HeaderText = "Wholesale Price";
            dgItems.Columns["special_price"].HeaderText = "Special Price";
            dgItems.Columns["stocks_left"].HeaderText = "Stocks Left";
        }

        private void FrmItemSearch_Load(object sender, EventArgs e)
        {
            LoadStores();
            CreateColumns();
            progressBar1.Visible = false;
            CheckForIllegalCrossThreadCalls = false;
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            int i = 1;
            int storeId = (int)cmbStores.SelectedValue;
            DataTable dtItems = Factory.ItemsController().FetchBySearch(txtSearch.Text.Trim());
            foreach (DataRow item in dtItems.Rows)
            {
                int itemId = Convert.ToInt32(item["id"]);
                decimal stocksLeft = Factory.StoreStocksController().StocksLeft(storeId, itemId);

                string[] itemRow = new string[] {
                    item["id"].ToString(),
                    item["sku_code"].ToString(),
                    item["name"].ToString(),
                    item["category_name"].ToString(),
                    item["unit_name"].ToString(),
                    Convert.ToDecimal(item["retail_price"]).ToString("n2"),
                    Convert.ToDecimal(item["wholesale_price"]).ToString("n2"),
                    Convert.ToDecimal(item["special_price"]).ToString("n2"),
                    stocksLeft.ToString("N2")
                };
                dgItems.Rows.Add(itemRow);
                int progress = (i / dtItems.Rows.Count) * 100;
                backgroundWorker1.ReportProgress(progress);
                i++;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim().Length < 3) return;
            dgItems.Rows.Clear();
            progressBar1.Visible = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void SelectItem()
        {
            bool ItemExist(int storeId, int itemId)
            {
                if (_ucSalesForm == null)
                {
                    foreach (DataGridViewRow item in _ucPurchaseForm.dgItems.Rows)
                    {
                        string currentItemId = item.Cells["ItemId"].Value.ToString();
                        string currentStoreId = item.Cells["StoreId"].Value.ToString();
                        if (currentItemId == itemId.ToString() && currentStoreId == storeId.ToString())
                            return true;
                    }
                }
                else 
                {
                    foreach (DataGridViewRow item in _ucSalesForm.dgItems.Rows)
                    {
                        string currentItemId = item.Cells["ItemId"].Value.ToString();
                        string currentStoreId = item.Cells["StoreId"].Value.ToString();
                        if (currentItemId == itemId.ToString() && currentStoreId == storeId.ToString())
                            return true;
                    }
                }

                return false;
            }

            if (dgItems.SelectedRows.Count == 0) return;
            int rowIndex = dgItems.CurrentCell.RowIndex;
            decimal stocksLeft = Convert.ToDecimal(dgItems.Rows[rowIndex].Cells["stocks_left"].Value);
            if (stocksLeft < 1)
            {
                Helper.MessageBoxError("No available stocks.");
                return;
            }

            int storeId = Convert.ToInt32(cmbStores.SelectedValue);
            ItemId = Convert.ToInt32(dgItems.SelectedCells[0].Value);
            if (ItemExist(storeId, ItemId))
            {
                Helper.MessageBoxError("Item already added from the same store. Please check.");
                return;
            }

            if (_ucSalesForm == null)
            {
                _ = new FrmPurchasesQuantity(this, _ucPurchaseForm).ShowDialog();
            }
            else 
            {
                _ = new FrmSalesQuantity(this, _ucSalesForm).ShowDialog();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectItem();
        }

        private void dgItems_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectItem();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //if (txtSearch.Text.Trim().Length < 3) return;
            //dgItems.Rows.Clear();
            //progressBar1.Visible = true;
            //backgroundWorker1.RunWorkerAsync();
        }

        private void cmbStores_SelectedValueChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            dgItems.Rows.Clear();
        }
    }
}
