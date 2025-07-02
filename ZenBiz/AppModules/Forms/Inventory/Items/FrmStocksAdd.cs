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
                int branchId = Convert.ToInt32(uc.cmbBranch.SelectedValue);
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
                int suppliersId = uc.cmbSupplier.SelectedValue != null ? Convert.ToInt32(uc.cmbSupplier.SelectedValue) : 0;
                string supplier = uc.cmbSupplier.Text;
                string user = uc.txtUser.Text.Trim();
                string dateRepaired = uc.dtpRepairedDate.Value.ToString("yyyy-MM-dd");
                string remarks = uc.txtRemarks.Text.Trim();

                string[] row = new string[]
                {
                    branch,
                    branchId.ToString(),
                    serialNumber,
                    model,
                    computerName,
                    ram,
                    operatingSystem,
                    sophosTamper,
                    dateAcquired,
                    user,
                    unitCost,
                    status,
                    suppliersId.ToString(),
                    supplier,
                    dateRepaired,
                    remarks,
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
