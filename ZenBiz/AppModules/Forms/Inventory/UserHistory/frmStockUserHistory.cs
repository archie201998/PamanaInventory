using PamanaWaterInventory.AppModules.Forms.Inventory.RepairHistory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenBiz;
using ZenBiz.AppModules;

namespace PamanaWaterInventory.AppModules.Forms.Inventory.UserHistory
{
    public partial class frmStockUserHistory : Form
    {
        readonly string _serialNumber = string.Empty;
        readonly int _stockId = 0;
        public frmStockUserHistory(int stockId, string serialNumber)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            _serialNumber = serialNumber;
            _stockId = stockId;
        }

        private void frmStockUserHistory_Load(object sender, EventArgs e)
        {
            Helper.DatagridDefaultStyle(dgUserHistory, false, true);
            this.Text = $"Item User History > {_serialNumber}";
            LoadStockUserHistory();
        }

        private void btnAddStoreStock_Click(object sender, EventArgs e)
        {
            _ = new frmAddStockUserHistory(_stockId).ShowDialog();
        }

        private void btnEditStoreStock_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dgUserHistory.CurrentCell.RowIndex;
                int repairId = Convert.ToInt32(dgUserHistory.Rows[rowIndex].Cells["id"].Value);
                _ = new frmEditRepairHistory(_stockId, repairId).ShowDialog();
                LoadStockUserHistory();
            }
            catch (Exception)
            {
            }
        }

        private void LoadStockUserHistory()
        {
            int stockId = _stockId;

            dgUserHistory.DataSource = Factory.StockUserHistoryController().GetViewRecordsByStockId(stockId);

            dgUserHistory.Columns["id"].Visible = false;
            dgUserHistory.Columns["stocks_id"].Visible = false;
            dgUserHistory.Columns["branches_id"].Visible = false;

            dgUserHistory.Columns["user"].HeaderText = "User";
            dgUserHistory.Columns["assigned_date"].HeaderText = "Assigned Date";
            dgUserHistory.Columns["unassigned_date"].HeaderText = "Returned Date";
            dgUserHistory.Columns["is_current_user"].HeaderText = "Current User";

            // Auto adjust columns size
            dgUserHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgUserHistory.AutoResizeColumns();
        }

        private void dgUserHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgUserHistory_SelectionChanged(object sender, EventArgs e)
        {
            Helper.EnableDisableToolStripButtons(dgUserHistory, btnEditStoreStock, btnDeleteStoreStock);
        }
    }
}
