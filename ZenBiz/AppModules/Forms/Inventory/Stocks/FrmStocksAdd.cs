using System.Transactions;
using ZenBiz.AppModules.Forms.Inventory.Items;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Inventory.Stocks
{
    public partial class FrmStocksAdd : Form
    {
        private readonly UcStocksForm uc;
        private readonly int _itemId;

        public FrmStocksAdd(int itemId)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            uc = ucStocksForm1;
            _itemId = itemId;
        }

        private void FrmStocksAdd_Load(object sender, EventArgs e)
        {

        }

        private void InsertBranchStock(int stockId, int branchId)
        {

            BranchStocksModel storeStocksModel = new()
            {
                Stock = new StocksModel() { Id = stockId },
                Branch = new BranchModel() { Id = branchId }
            };

            _ = Factory.BranchStocksController().Insert(storeStocksModel);
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
            string user = uc.txtUser.Text.Trim();
            string status = uc.cmbxStatus.Text.Trim();
            string remarks = uc.txtRemarks.Text.Trim();
            DateTime dateAcquired = uc.dtpDateAcquired.Value;
            string? dateRepaired = uc.dtpRepairedDate.Value.ToString("yyyy-MM-dd");

            StocksModel stocksModel = new()
            {
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
                User = user ?? string.Empty,
                DateRepaired = dateRepaired ?? string.Empty,
                Remarks = remarks,
            };

            _ = Factory.StocksController().Insert(stocksModel);

            int stocksLastInsertedId = Factory.StocksController().LastInsertedId();
            int branchId = (int)uc.cmbBranch.SelectedValue;
            InsertBranchStock(stocksLastInsertedId, branchId);

            scope.Complete();
            scope.Dispose();
            return true;
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
    }
}
