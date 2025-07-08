using PamanaWaterInventory.AppModules.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using ZenBiz;
using ZenBiz.AppModules;
using ZenBiz.AppModules.Forms.Inventory.Items;
using ZenBiz.AppModules.Models;

namespace PamanaWaterInventory.AppModules.Forms.Inventory.RepairHistory
{
    public partial class frmAddRepairHistory : Form
    {
        private readonly ucRepairHistory uc;
        private int _stockId;

        public frmAddRepairHistory(int stockId)
        {
            InitializeComponent();
            uc = ucRepairHistory1;
            _stockId = stockId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Helper.MessageBoxSuccess("Stock has been saved.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool SaveData()
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

            RepairedHistoryModel repairedHistoryModel = new()
            {
                ReportedBy = reportedBy,
                IssueDescription = issuedDescription,
                RepairedAction = repairAction,
                RepairedDate = repairedDate,
                RepairedCost = cost,
                RepairedBy = uc.txtRepairedBy.Text.Trim(),
                OtherDetails = otherDetails,
                StockID = stocksId  
            };

            return Factory.RepairedHistoryController().Insert(repairedHistoryModel);

        }
    }
}
