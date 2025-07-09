using System.Transactions;
using ZenBiz.AppModules.Forms.Inventory.Items;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Inventory.Stocks
{
    public partial class FrmStocksEdit : Form
    {
        private readonly UcStocksForm uc;
        private readonly int _itemId;
        private readonly int _stockId;
        private readonly bool _isWarehouse;

        public FrmStocksEdit(int itemId, int stockId, bool isWarehouse)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            uc = ucStocksForm1;
            _itemId = itemId;
            _stockId = stockId;
            _isWarehouse = isWarehouse;
        }

        private void LoadData()
        {
            Dictionary<string, string> dict;

            dict = Factory.BranchStocksController().FindByStockId(_stockId);

            if (dict.Count != 0)
            {
                uc.cmbBranch.SelectedValue = Convert.ToInt32(dict["branches_id"]);
                uc.cmbBranch.Text = dict["branch_name"].ToString();
                uc.txtSerialNumber.Text = dict["serial_number"].ToString();
                uc.txtModel.Text = dict["model"].ToString();
                uc.txtOS.Text = dict["operating_system"].ToString();
                uc.txtRAM.Text = dict["ram"].ToString();
                uc.txtComputerName.Text = dict["computer_name"].ToString();
                uc.txtSophosTamper.Text = dict["sophos_tamper"].ToString();
                uc.dtpDateAcquired.Value = DateTime.Parse(dict["date_acquired"].ToString());
                uc.nudUnitCost.Value = decimal.Parse(dict["unit_cost"].ToString());
                uc.cmbxStatus.Text = dict["status"].ToString();
                uc.cmbSupplier.SelectedValue = Convert.ToInt32(dict["suppliers_id"]);
                uc.cmbSupplier.Text = dict["status"].ToString();
                uc.txtRemarks.Text = dict["remarks"].ToString();
            }
        }

        private void FrmStocksEdit_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void UpdateStoreStock(int stockId, int storeId)
        {
            BranchStocksModel storeStocksModel = new()
            {
                Stock = new StocksModel() { Id = stockId },
                Branch = new BranchModel() { Id = storeId }
            };

            _ = Factory.BranchStocksController().Update(storeStocksModel);
        }

        private bool SaveData()
        {
            using TransactionScope scope = new();
            if (!uc.ValidateChildren())
            {
                Helper.MessageBoxError(uc.GetFormErrors());
                return false;
            }

            int suppliersId = (int)uc.cmbSupplier.SelectedValue;
            string status = uc.cmbxStatus.Text.Trim();
            string remarks = uc.txtRemarks.Text.Trim();
            DateTime dateAcquired = uc.dtpDateAcquired.Value;

            StocksModel stocksModel = new()
            {
                Id = _stockId,
                Item = new ItemsModel() { Id = _itemId },
                Supplier = new SupplierModel() { Id = suppliersId },
                SerialNumber = uc.txtSerialNumber.Text.Trim(),
                Model = uc.txtModel.Text.Trim(),
                OperatingSystem = uc.txtOS.Text.Trim(),
                RAM = uc.txtRAM.Text.Trim(),
                ComputerName = uc.txtComputerName.Text.Trim(),
                SophosTamper = uc.txtSophosTamper.Text.Trim(),
                DateAcquired = dateAcquired,
                UnitCost = uc.nudUnitCost.Value,
                Status = status,
                Remarks = remarks,
            };

            _ = Factory.StocksController().Update(stocksModel);

            int storeWarehouseId = (int)uc.cmbBranch.SelectedValue;
            UpdateStoreStock(_stockId, storeWarehouseId);

            scope.Complete();
            scope.Dispose();
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Helper.MessageBoxSuccess("Stock has been updated.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
