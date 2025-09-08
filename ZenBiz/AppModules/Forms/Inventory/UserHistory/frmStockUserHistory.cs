using MySql.Data.MySqlClient;
using PamanaWaterInventory.AppModules.Forms.Inventory.RepairHistory;
using PamanaWaterInventory.AppModules.Models;
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
            LoadStockUserHistory();
        }

        private void btnEditStoreStock_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dgUserHistory.CurrentCell.RowIndex;
                int repairId = Convert.ToInt32(dgUserHistory.Rows[rowIndex].Cells["id"].Value);
                _ = new frmEditStockUserHistory(_stockId, repairId).ShowDialog();
                LoadStockUserHistory();
            }
            catch (Exception)
            {
            }
        }

        private void LoadStockUserHistory()
        {
            try
            {
                int stockId = _stockId;
                var dataSource = Factory.StockUserHistoryController().GetViewRecordsByStockId(stockId);

                dgUserHistory.DataSource = dataSource;

                // Check if data source is not null and has columns
                if (dataSource == null || dgUserHistory.Columns.Count == 0)
                {
                    // Clear the grid and exit if no data
                    dgUserHistory.DataSource = null;
                    return;
                }

                // Hide columns - check if they exist first
                HideColumnIfExists(dgUserHistory, "id");
                HideColumnIfExists(dgUserHistory, "stocks_id");
                HideColumnIfExists(dgUserHistory, "branches_id");

                // Set headers - check if columns exist first
                SetColumnHeaderIfExists(dgUserHistory, "user", "User");
                SetColumnHeaderIfExists(dgUserHistory, "assigned_date", "Assigned Date");
                SetColumnHeaderIfExists(dgUserHistory, "unassigned_date", "Returned Date");
                SetColumnHeaderIfExists(dgUserHistory, "is_current_user", "Current User");

                // Auto adjust columns size
                dgUserHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgUserHistory.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                // Handle the error gracefully
                dgUserHistory.DataSource = null;
                // Optionally log the error
                // MessageBox.Show($"Error loading user history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Helper methods (add these to your class)
        private void HideColumnIfExists(DataGridView grid, string columnName)
        {
            if (grid.Columns.Contains(columnName))
            {
                grid.Columns[columnName].Visible = false;
            }
        }

        private void SetColumnHeaderIfExists(DataGridView grid, string columnName, string headerText)
        {
            if (grid.Columns.Contains(columnName))
            {
                grid.Columns[columnName].HeaderText = headerText;
            }
        }

        private void dgUserHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgUserHistory_SelectionChanged(object sender, EventArgs e)
        {
            Helper.EnableDisableToolStripButtons(dgUserHistory, btnEditStoreStock, btnDeleteStoreStock);
        }

        private void btnDeleteStoreStock_Click(object sender, EventArgs e)
        {
            if (DeleteUserHistory(dgUserHistory)) LoadStockUserHistory();
        }

        private bool DeleteUserHistory(DataGridView dataGrid)
        {
            if (dataGrid.SelectedRows.Count == 0) return false;

            try
            {
                //Dev Mode.
                //List<UserHistoryModel> repairHistoryModelList = new();
                //foreach (DataGridViewRow item in dataGrid.SelectedRows)
                //    repairHistoryModelList.Add(new RepairedHistoryModel() { Id = Convert.ToInt32(item.Cells["stocks_id"].Value) });

                //var messageBox = MessageBox.Show("Are you sure you want to delete this data?", "Deleting Repair History", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (messageBox != DialogResult.Yes) return false;

                //return Factory.RepairedHistoryController().Delete(repairHistoryModelList);
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
    }
}
