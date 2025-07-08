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
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
