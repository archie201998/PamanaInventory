using MySql.Data.MySqlClient;
using PamanaWaterInventory.AppModules.Interfaces;
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
using ZenBiz.AppModules.Models;

namespace PamanaWaterInventory.AppModules.Forms.Inventory.RepairHistory
{
    public partial class frmRepairHistory : Form
    {
        private int _stocksId;
        private string _serialNumber;
        public frmRepairHistory(int stockId, string serialNumber)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            _stocksId = stockId;
            _serialNumber = serialNumber;
        }

        private void frmRepairHistory_Load(object sender, EventArgs e)
        {
            Helper.DatagridDefaultStyle(dgRepairHistory, false, true);
            LoadRepairHistory();
            this.Text = $"Item Repair History > {_serialNumber}";
        }

        private void LoadRepairHistory()
        {
            try
            {
                int stockId = _stocksId;

                dgRepairHistory.DataSource = Factory.RepairedHistoryController().GetViewRecordsByStockId(stockId);

                dgRepairHistory.Columns["id"].Visible = false;
                dgRepairHistory.Columns["stocks_id"].Visible = false;

                dgRepairHistory.Columns["reported_by"].HeaderText = "Reported By";
                dgRepairHistory.Columns["repair_date"].HeaderText = "Date Repaired";
                dgRepairHistory.Columns["repaired_by"].HeaderText = "Repaired By";
                dgRepairHistory.Columns["cost"].HeaderText = "Cost";
                dgRepairHistory.Columns["issue_description"].HeaderText = "Issue Description";
                dgRepairHistory.Columns["repair_action"].HeaderText = "Repair Action";
                dgRepairHistory.Columns["cost"].HeaderText = "Repair Cost";
                dgRepairHistory.Columns["other_details"].HeaderText = "Other Details";
                dgRepairHistory.Columns["other_details"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            }
            catch (Exception)
            {
            }
        }

        private void btnAddStoreStock_Click(object sender, EventArgs e)
        {
            _ = new frmAddRepairHistory(_stocksId).ShowDialog();
            LoadRepairHistory();
        }

        private void btnEditStoreStock_Click(object sender, EventArgs e)
        {
            int rowIndex = dgRepairHistory.CurrentCell.RowIndex;
            int repairId = Convert.ToInt32(dgRepairHistory.Rows[rowIndex].Cells["id"].Value);
            _ = new frmEditRepairHistory(_stocksId, repairId).ShowDialog();
            LoadRepairHistory();
        }

        private void btnDeleteStoreStock_Click(object sender, EventArgs e)
        {
            if (DeleteRepairHistory(dgRepairHistory)) LoadRepairHistory();
        }


        private bool DeleteRepairHistory(DataGridView dataGrid)
        {
            if (dataGrid.SelectedRows.Count == 0) return false;

            try
            {
                List<RepairedHistoryModel> repairHistoryModelList = new();
                foreach (DataGridViewRow item in dataGrid.SelectedRows)
                    repairHistoryModelList.Add(new RepairedHistoryModel() { Id = Convert.ToInt32(item.Cells["stocks_id"].Value) });

                var messageBox = MessageBox.Show("Are you sure you want to delete this data?", "Deleting Repair History", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messageBox != DialogResult.Yes) return false;
                %
                return Factory.RepairedHistoryController().Delete(repairHistoryModelList);
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

        private void dgRepairHistory_SelectionChanged(object sender, EventArgs e)
        {
            Helper.EnableDisableToolStripButtons(dgRepairHistory, btnEditStoreStock, btnDeleteStoreStock);
        }
    }
}
