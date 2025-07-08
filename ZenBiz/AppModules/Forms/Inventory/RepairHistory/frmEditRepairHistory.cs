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

namespace PamanaWaterInventory.AppModules.Forms.Inventory.RepairHistory
{
    public partial class frmEditRepairHistory : Form
    {
        private readonly ucRepairHistory uc;
        private int _stockId;
        private int _repairId;

        public frmEditRepairHistory(int stockId, int repairId)
        {
            InitializeComponent();
            uc = ucRepairHistory2;
            _stockId = stockId;
            _repairId = repairId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (UpdateData())
            {
                Helper.MessageBoxSuccess("Stock has been updated.");
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
            string reportedBy = uc.txtReportedBy.Text.Trim();
            string issuedDescription = uc.txtIssueDescription.Text.Trim();
            string repairAction = uc.txtRepairAction.Text.Trim();
            DateTime repairedDate = uc.dtpDateRepaired.Value;
            decimal cost = uc.nudRepairCost.Value;
            string otherDetails = uc.txtOtherDetails.Text.Trim();
            int repairId = _repairId;   

            RepairedHistoryModel repairedHistoryModel = new()
            {
                ReportedBy = reportedBy,
                IssueDescription = issuedDescription,
                RepairedAction = repairAction,
                RepairedDate = repairedDate,
                RepairedCost = cost,
                RepairedBy = uc.txtRepairedBy.Text.Trim(),
                OtherDetails = otherDetails,
                StockID = stocksId,
                Id = repairId   

            };

            return Factory.RepairedHistoryController().Update(repairedHistoryModel);

        }

        private void LoadData()
        {
            Dictionary<string, string> dict;

            dict = Factory.RepairedHistoryController().FindById(_stockId);

            uc.txtReportedBy.Text = dict["reported_by"];
            uc.txtIssueDescription.Text = dict["issue_description"];
            uc.txtRepairAction.Text = dict["repair_action"];
            uc.dtpDateRepaired.Value = Convert.ToDateTime(dict["repair_date"]);
            uc.txtRepairedBy.Text = dict["repaired_by"];
            uc.nudRepairCost.Value = Convert.ToDecimal(dict["cost"]);
            uc.txtOtherDetails.Text = dict["other_details"];

        }

        private void frmEditRepairHistory_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
