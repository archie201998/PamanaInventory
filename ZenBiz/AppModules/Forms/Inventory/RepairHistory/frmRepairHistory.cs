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

namespace PamanaWaterInventory.AppModules.Forms.Inventory.RepairHistory
{
    public partial class frmRepairHistory : Form
    {
        public frmRepairHistory()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
        }

        private void frmRepairHistory_Load(object sender, EventArgs e)
        {
            CreateDatagridViewColumnsOnRepairHistory(dgRepairHistory);
            Helper.DatagridDefaultStyle(dgRepairHistory, false, true);
        }

        private void CreateDatagridViewColumnsOnRepairHistory(DataGridView dataGridView)
        {
            dataGridView.ColumnCount = 9;
            dataGridView.Columns[0].Name = "id";
            dataGridView.Columns[1].Name = "repair_date";
            dataGridView.Columns[2].Name = "issue_description";
            dataGridView.Columns[3].Name = "reported_by";
            dataGridView.Columns[4].Name = "repaired_by";
            dataGridView.Columns[5].Name = "repair_action";
            dataGridView.Columns[6].Name = "cost";
            dataGridView.Columns[7].Name = "other_details";
            dataGridView.Columns[8].Name = "stocks_id";

            dataGridView.Columns["id"].Visible = false;
            dataGridView.Columns["repair_date"].HeaderText = "Date Repaired";
            dataGridView.Columns["issue_description"].HeaderText = "Issue Description";
            dataGridView.Columns["reported_by"].HeaderText = "Reported By";
            dataGridView.Columns["repaired_by"].HeaderText = "Repaired By";
            dataGridView.Columns["repair_action"].HeaderText = "Repair Action";
            dataGridView.Columns["cost"].HeaderText = "Cost";
            dataGridView.Columns["other_details"].HeaderText = "Other Details";
            dataGridView.Columns["stocks_id"].Visible = false;
            dataGridView.Columns["issue_description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }

        private void btnAddStoreStock_Click(object sender, EventArgs e)
        {
            _ = new frmAddRepairHistory().ShowDialog();
        }
    }
}
