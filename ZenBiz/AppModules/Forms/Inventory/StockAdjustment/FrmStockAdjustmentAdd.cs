using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Inventory.StockAdjustment
{
    public partial class FrmStockAdjustmentAdd : Form
    {
        private readonly UcStockAdjustments uc;
        private readonly int _itemId;
        private readonly bool _isWarehouse;

        public FrmStockAdjustmentAdd(int itemId, bool isWarehouse)
        {
            InitializeComponent();
            uc = ucStockAdjustments1;
            uc.IsWarehouse = isWarehouse;
            _itemId = itemId;
            _isWarehouse = isWarehouse;
        }

        private bool InsertStoreStockAdjustment()
        {
            BranchStockAdjustmentsModel storeStockAdjustmentsModel = new()
            {
                Stores = new BranchModel() { Id = (int)uc.cmbStoreWarehouse.SelectedValue },
                Items = new ItemsModel() { Id = _itemId },
                Quantity = uc.nudQuantity.Value,
                DateAdjusted = uc.dtpDate.Value,
                Reason = uc.txtReason.Text.Trim(),
                Users = new UsersModel() { Id = Helper.UserId }
            };

            return Factory.StoreStockAdjustmentController().Insert(storeStockAdjustmentsModel);
        }

        private bool InsertWarehouseStockAdjustment()
        {
            WarehouseStockAdjustmentsModel warehouseStockAdjustmentsModel = new()
            {
                Warehouses = new WarehousesModel() { Id = (int)uc.cmbStoreWarehouse.SelectedValue },
                Items = new ItemsModel() { Id = _itemId },
                Quantity = uc.nudQuantity.Value,
                DateAdjusted = uc.dtpDate.Value,
                Reason = uc.txtReason.Text.Trim(),
                Users = new UsersModel() { Id = Helper.UserId }
            };

            return Factory.WarehouseStockAdjustmentController().Insert(warehouseStockAdjustmentsModel);
        }

        private bool SaveData()
        {
            if (!uc.ValidateChildren())
            {
                Helper.MessageBoxError(uc.GetFormErrors());
                return false;
            }

            if (_isWarehouse) return InsertWarehouseStockAdjustment();
            else return InsertStoreStockAdjustment();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Helper.MessageBoxSuccess("Stock adjustment has been saved.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
