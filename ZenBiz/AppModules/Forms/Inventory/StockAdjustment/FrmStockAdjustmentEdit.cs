using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Inventory.StockAdjustment
{
    public partial class FrmStockAdjustmentEdit : Form
    {
        private readonly UcStockAdjustments uc;
        private readonly int _stockAdjustmentId;
        private readonly int _itemId;
        private readonly bool _isWarehouse;

        public FrmStockAdjustmentEdit(int stockAdjustmentId, int itemId, bool isWarehouse)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            uc = ucStockAdjustments1;
            uc.IsWarehouse = isWarehouse;
            _stockAdjustmentId = stockAdjustmentId;
            _itemId = itemId;
            _isWarehouse = isWarehouse;
        }

        private void LoadStoreStockAdjustment()
        {
            var dict = Factory.StoreStockAdjustmentController().FindById(_stockAdjustmentId);
            uc.cmbStoreWarehouse.SelectedValue = Convert.ToInt32(dict["stores_id"]);
            uc.nudQuantity.Value = Convert.ToDecimal(dict["quantity"]);
            uc.dtpDate.Value = Convert.ToDateTime(dict["date_adjusted"]);
            uc.txtReason.Text = dict["reason"];
        }

        private void LoadWarehouseStockAdjustment()
        {
            var dict = Factory.WarehouseStockAdjustmentController().FindById(_stockAdjustmentId);
            uc.cmbStoreWarehouse.SelectedValue = Convert.ToInt32(dict["warehouses_id"]);
            uc.nudQuantity.Value = Convert.ToDecimal(dict["quantity"]);
            uc.dtpDate.Value = Convert.ToDateTime(dict["date_adjusted"]);
            uc.txtReason.Text = dict["reason"];
        }

        private bool UpdateStoreStockAdjustment()
        {
            BranchStockAdjustmentsModel storeStockAdjustmentsModel = new()
            {
                Id = _stockAdjustmentId,
                Stores = new BranchModel() { Id = (int)uc.cmbStoreWarehouse.SelectedValue },
                Items = new ItemsModel() { Id = _itemId },
                Quantity = uc.nudQuantity.Value,
                DateAdjusted = uc.dtpDate.Value,
                Reason = uc.txtReason.Text.Trim(),
                Users = new UsersModel() { Id = Helper.UserId }
            };

            return Factory.StoreStockAdjustmentController().Update(storeStockAdjustmentsModel);
        }

        private bool UpdateWarehouseStockAdjustment()
        {
            WarehouseStockAdjustmentsModel warehouseStockAdjustmentsModel = new()
            {
                Id = _stockAdjustmentId,
                Warehouses = new WarehousesModel() { Id = (int)uc.cmbStoreWarehouse.SelectedValue },
                Items = new ItemsModel() { Id = _itemId },
                Quantity = uc.nudQuantity.Value,
                DateAdjusted = uc.dtpDate.Value,
                Reason = uc.txtReason.Text.Trim(),
                Users = new UsersModel() { Id = Helper.UserId }
            };

            return Factory.WarehouseStockAdjustmentController().Update(warehouseStockAdjustmentsModel);
        }

        private void FrmStockAdjustmentEdit_Load(object sender, EventArgs e)
        {
            if (_isWarehouse) LoadWarehouseStockAdjustment();
            else LoadStoreStockAdjustment();
        }

        private bool SaveData()
        {
            if (!uc.ValidateChildren())
            {
                Helper.MessageBoxError(uc.GetFormErrors());
                return false;
            }

            if (_isWarehouse) return UpdateWarehouseStockAdjustment();
            else return UpdateStoreStockAdjustment();
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
