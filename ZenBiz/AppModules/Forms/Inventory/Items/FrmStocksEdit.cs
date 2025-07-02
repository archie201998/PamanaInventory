using Mysqlx.Crud;

namespace ZenBiz.AppModules.Forms.Inventory.Items
{
    public partial class FrmStocksEdit : Form
    {
        private readonly UcStocksForm uc;
        private readonly Dictionary<string, string> _data;
        private readonly DataGridView _dgStocks;

        private readonly string _serialNumber = string.Empty;

        public FrmStocksEdit(Dictionary<string, string> selectedData, DataGridView dgStocks)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            uc = ucStocksForm1;
            _data = selectedData;
            _dgStocks = dgStocks;
            Text = "Edit Branch Stock";

            _serialNumber = _data["serial_number"];
        }

        private void LoadSelectedData()
        {
            uc.dtpDateAcquired.Enabled = true;
            uc.txtSerialNumber.Text = _data["serial_number"];
            uc.txtModel.Text = _data["model"];
            uc.txtOS.Text = _data["operating_system"];
            uc.txtRAM.Text = _data["ram"];
            uc.txtComputerName.Text = _data["computer_name"];
            uc.txtSophosTamper.Text = _data["sophos_tamper"];
            uc.nudUnitCost.Value = Convert.ToDecimal(_data["unit_cost"]);
            //uc.cmbSupplier.SelectedValue = Convert.ToInt32(_data["suppliers_id"]);
            uc.cmbxStatus.SelectedValue = _data["status"];
            uc.txtUser.Text = _data["user"];
            //uc.dtpRepairedDate.Enabled = Convert.ToBoolean(_data["date_repaired"]);
            uc.txtRemarks.Text = _data["remarks"];

        }

        private void FrmStocksEdit_Load(object sender, EventArgs e)
        {
            LoadSelectedData();
        }

        private bool UpdateStock()
        {
            if (!uc.ValidateChildren())
            {
                Helper.MessageBoxError(uc.GetFormErrors());
            }

            return true;
        }

        private bool AddStock()
        {
            if (!uc.ValidateChildren())
            {
                Helper.MessageBoxError(uc.GetFormErrors());
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
         

            if (AddStock())
            {
                string branchId = uc.cmbBranch.SelectedValue.ToString();
                string branch = uc.cmbBranch.Text;
                string serialNumber = uc.txtSerialNumber.Text.Trim();
                string model = uc.txtModel.Text.Trim();
                string operatingSystem = uc.txtOS.Text.Trim();
                string ram = uc.txtRAM.Text.Trim();
                string computerName = uc.txtComputerName.Text.Trim();
                string sophosTamper = uc.txtSophosTamper.Text.Trim();
                string dateAcquired = uc.dtpDateAcquired.Value.ToString("yyyy-MM-dd");
                string unitCost = uc.nudUnitCost.Value.ToString("N2");
                string status = uc.cmbxStatus.Text.Trim();
                string user = uc.txtUser.Text.Trim();
                string dateRepaired = uc.dtpRepairedDate.Value.ToString("yyyy-MM-dd");
                string remarks = uc.txtRemarks.Text.Trim();

                string[] row = new string[]
                {
                    branch,
                    branchId,
                    serialNumber,
                    model,
                    operatingSystem,
                    ram,
                    computerName,
                    sophosTamper,
                    dateAcquired,
                    unitCost,
                    status,
                    user,
                    dateRepaired,
                    remarks,
                };

                RemoveStockBySerialNumber();
                _dgStocks.Rows.Add(row);
                uc.ResetForm();
                this.Close();
            }
        }

        private void ucStocksForm1_Load(object sender, EventArgs e)
        {

        }
        private void RemoveStockBySerialNumber()
        {
            foreach (DataGridViewRow row in _dgStocks.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["serial_number"].Value?.ToString() == _serialNumber)
                {
                    _dgStocks.Rows.Remove(row);
                    break;
                }
            }
        }
    }
}
