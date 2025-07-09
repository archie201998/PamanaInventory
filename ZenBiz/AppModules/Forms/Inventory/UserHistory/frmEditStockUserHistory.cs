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
    public partial class frmEditStockUserHistory : Form
    {
        private readonly ucStockUserHistory uc;
        private int _stockId;
        private int _stockUserHistoryId;

        public frmEditStockUserHistory(int stockId, int stockUserHistoryId)
        {
            InitializeComponent();
            uc = ucStockUserHistory1;
            _stockId = stockId;
            _stockUserHistoryId = stockUserHistoryId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (UpdateData())
            {
                Helper.MessageBoxSuccess("User history has been updated.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool UpdateData()
        {
            if (!uc.ValidateChildren())
            {
                Helper.MessageBoxError(uc.GetFormErrors());
                return false;
            }

            int stocksId = _stockId;
            string user = uc.txtUser.Text.Trim();
            DateTime assignedDate = uc.dtpDateAssigned.Value;
            DateTime returnedDate = uc.dtpDateReturned.Value;

            StockUserHistoryModel stockUserHistoryModel = new()
            {
                Id = _stockUserHistoryId,
                User = user,
                AssignedDate = assignedDate,
                ReturnedDate = uc.checkBox1.Checked ? returnedDate : DateTime.MinValue,
                BranchID = uc.cmbBranch.SelectedValue != null ? Convert.ToInt32(uc.cmbBranch.SelectedValue) : 0,
                StockID = stocksId
            };

            return Factory.StockUserHistoryController().Insert(stockUserHistoryModel);

        }

        private void LoadData()
        {
            Dictionary<string, string> dict;

            dict = Factory.StockUserHistoryController().FindById(_stockId);

            uc.cmbBranch.SelectedValue = dict["branches_id"];
            uc.txtUser.Text = dict["user"];
            uc.dtpDateAssigned.Value = Convert.ToDateTime(dict["assigned_date"]);
            uc.dtpDateReturned.Value = string.IsNullOrEmpty(dict["unassigned_date"]) ? DateTime.Now : Convert.ToDateTime(dict["unassigned_date"]);
            uc.cbxCurrentUser.Checked = Convert.ToBoolean(dict["is_current_user"]); 
        }

        private void frmEditStockUserHistory_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
