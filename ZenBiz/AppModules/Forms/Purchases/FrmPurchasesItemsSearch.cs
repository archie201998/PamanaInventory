using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenBiz.AppModules.Forms.Sales;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZenBiz.AppModules.Forms.Purchases
{
    public partial class FrmPurchasesItemsSearch : Form
    {
        internal int ItemId;
        private readonly UcPurchaseForm _ucPurchaseForm;
        public FrmPurchasesItemsSearch(UcPurchaseForm ucPurchaseForm)
        {
            InitializeComponent();
            _ucPurchaseForm = ucPurchaseForm;

            Helper.LoadFormIcon(this);
            Helper.DatagridDefaultStyle(dgItems);
            Helper.FormDialogDefaults(this);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectItem();
        }

        private void SelectItem()
        {
            bool ItemExist(int itemId)
            {
                foreach (DataGridViewRow item in _ucPurchaseForm.dgItems.Rows)
                {
                    string currentItemId = item.Cells["item_id"].Value.ToString();
                    if (currentItemId == itemId.ToString())
                        return true;
                }

                return false;
            }

            if (dgItems.SelectedRows.Count == 0) return;
            int rowIndex = dgItems.CurrentCell.RowIndex;
            ItemId = Convert.ToInt32(dgItems.SelectedCells[0].Value);
            if (ItemExist(ItemId))
            {
                Helper.MessageBoxError("Item already added. Please check.");
                return;
            }

            _ = new FrmPurchasesQuantity(this, _ucPurchaseForm).ShowDialog();
        }

        private void FrmPurchasesItemsSearch_Load(object sender, EventArgs e)
        {
            CreateColumns();
        }
        private void CreateColumns()
        {
            dgItems.ColumnCount = 6;
            dgItems.Columns[0].Name = "id";
            dgItems.Columns[1].Name = "sku_code";
            dgItems.Columns[2].Name = "name";
            dgItems.Columns[3].Name = "category_name";
            dgItems.Columns[4].Name = "unit_name";
            dgItems.Columns[5].Name = "unit_cost";

            dgItems.Columns["id"].Visible = false;
            dgItems.Columns["sku_code"].HeaderText = "Code";
            dgItems.Columns["name"].HeaderText = "Item";
            dgItems.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgItems.Columns["category_name"].HeaderText = "Category";
            dgItems.Columns["unit_name"].HeaderText = "Unit";
            dgItems.Columns["unit_cost"].HeaderText = "Unit Cost";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim().Length < 3) return;
            dgItems.Rows.Clear();
            LoadItems();
        }

        private void LoadItems()
        {
            DataTable dtItems = Factory.ItemsController().FetchBySearch(txtSearch.Text.Trim());
            foreach (DataRow item in dtItems.Rows)
            {
                string[] itemRow = new string[] {
                    item["id"].ToString(),
                    item["sku_code"].ToString(),
                    item["name"].ToString(),
                    item["category_name"].ToString(),
                    item["unit_name"].ToString(),
                    Convert.ToDecimal(item["unit_cost"]).ToString("N2"),
                };
                dgItems.Rows.Add(itemRow);
            }
        }

        private void dgItems_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectItem();
        }
    }
}
