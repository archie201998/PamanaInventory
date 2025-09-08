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

            return Factory.StockUserHistoryController().Update(stockUserHistoryModel);
        }

        private void LoadData()
        {
            try
            {
                Dictionary<string, string> dict;
                dict = Factory.StockUserHistoryController().FindById(_stockId);

                // Check if dictionary is not null and has data
                if (dict == null)
                {
                    MessageBox.Show("No record found for the specified stock ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Safe assignment with null checks
                if (dict.ContainsKey("branches_id"))
                    uc.cmbBranch.SelectedValue = dict["branches_id"];

                if (dict.ContainsKey("user"))
                    uc.txtUser.Text = dict["user"] ?? string.Empty;

                // Safe date assignment for assigned_date
                if (dict.ContainsKey("assigned_date") && !string.IsNullOrEmpty(dict["assigned_date"]))
                {
                    if (DateTime.TryParse(dict["assigned_date"], out DateTime assignedDate))
                    {
                        uc.dtpDateAssigned.Value = assignedDate;
                    }
                    else
                    {
                        uc.dtpDateAssigned.Value = DateTime.Now; // or some default date
                    }
                }

                // Safe date assignment for unassigned_date (this was causing the error)
                if (dict.ContainsKey("unassigned_date"))
                {
                    string unassignedDateStr = dict["unassigned_date"];
                    if (string.IsNullOrEmpty(unassignedDateStr) ||
                        unassignedDateStr.Equals("NULL", StringComparison.OrdinalIgnoreCase) ||
                        !DateTime.TryParse(unassignedDateStr, out DateTime unassignedDate))
                    {
                        uc.dtpDateReturned.Value = DateTime.Now;
                    }
                    else
                    {
                        uc.dtpDateReturned.Value = unassignedDate;
                    }
                }
                else
                {
                    uc.dtpDateReturned.Value = DateTime.Now;
                }

                // Safe boolean conversion
                if (dict.ContainsKey("is_current_user"))
                {
                    string currentUserStr = dict["is_current_user"];
                    if (bool.TryParse(currentUserStr, out bool isCurrentUser))
                    {
                        uc.cbxCurrentUser.Checked = isCurrentUser;
                    }
                    else
                    {
                        // Handle "1"/"0" or "Y"/"N" scenarios
                        uc.cbxCurrentUser.Checked = currentUserStr == "1" ||
                                                  currentUserStr.Equals("Y", StringComparison.OrdinalIgnoreCase) ||
                                                  currentUserStr.Equals("True", StringComparison.OrdinalIgnoreCase);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error loading stock user history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmEditStockUserHistory_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
