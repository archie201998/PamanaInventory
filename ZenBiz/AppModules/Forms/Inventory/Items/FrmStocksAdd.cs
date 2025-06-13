using System.Windows.Forms;

namespace ZenBiz.AppModules.Forms.Inventory.Items
{
    public partial class FrmStocksAdd : Form
    {
        private readonly UcStocksForm uc;
        private readonly DataGridView _dgStocks;
        public DataGridViewRow rowStoreStocks = new();

        public FrmStocksAdd(DataGridView dgStocks, bool isWarehouse)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            uc = ucStocksForm1;
            _dgStocks = dgStocks;
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
            DateTime acquiredDate = uc.dtpDateAcquired.Value;

            if (AddStock())
            {
                string branchId = uc.cmbBranch.SelectedValue.ToString();
                string branch = uc.cmbBranch.Text;
                string itemName = string.Empty;
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
                    itemName,
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
                    branchId,
                };

                _dgStocks.Rows.Add(row);
                uc.ResetForm();
            }
        }

        private void FrmStoreStocksAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
