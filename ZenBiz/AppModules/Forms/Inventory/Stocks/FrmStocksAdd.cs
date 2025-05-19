using System.Transactions;
using ZenBiz.AppModules.Forms.Inventory.Items;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Inventory.Stocks
{
    public partial class FrmStocksAdd : Form
    {
        private readonly UcStocksForm uc;
        private readonly int _itemId;
        private readonly bool _isWarehouse;

        public FrmStocksAdd(int itemId, bool isWarehouse)
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            uc = ucStocksForm1;
            uc.IsWarehouse = isWarehouse;
            _itemId = itemId;
            _isWarehouse = isWarehouse;
        }

        private void FrmStocksAdd_Load(object sender, EventArgs e)
        {
            uc.dtpExpiration.Enabled = false;
            uc.dtpStockDate.Enabled = false;
            uc.cmbSupplier.Enabled = false;
        }

        private void InsertStoreStock(int stockId, int storeId)
        {

            BranchStocksModel storeStocksModel = new()
            {
                Stock = new StocksModel() { Id = stockId },
                Store = new BranchModel() { Id = storeId }
            };

            _ = Factory.StoreStocksController().Insert(storeStocksModel);
        }

        private void InsertWarehouseStock(int stockId, int warehouseId)
        {

            WarehouseStocksModel warehouseStocksModel = new()
            {
                Stock = new StocksModel() { Id = stockId },
                Warehouse = new WarehousesModel() { Id = warehouseId }
            };

            _ = Factory.WarehouseStocksController().Insert(warehouseStocksModel);
        }

        private bool SaveData()
        {
            using TransactionScope scope = new();
            if (!uc.ValidateChildren())
            {
                Helper.MessageBoxError(uc.GetFormErrors());
                return false;
            }
            DateTime? stockDate = uc.chkStockDate.Checked ? uc.dtpStockDate.Value : null;
            DateTime? expirationDate = uc.chkExpiration.Checked ? uc.dtpExpiration.Value : null;
            DateTime? repairedDate = uc.chkRepairedDate.Checked ? uc.dtpRepairedDate.Value : null;
            DateTime? returnedDate = uc.chkReturnedDate.Checked ? uc.dtpReturnedDate.Value : null;
            int? suppliersId = uc.chkSupplier.Checked ? (int)uc.cmbSupplier.SelectedValue : null;
            string? user = uc.txtUser.Text.Trim();
            string? status = uc.cmbxStatus.Text.Trim();
            string? remarks = uc.txtRemarks.Text.Trim();

            StocksModel stocksModel = new()
            {
                Item = new ItemsModel() { Id = _itemId },
                Supplier = new SupplierModel() { Id = suppliersId },
                Quantity = uc.nudStockCount.Value,
                StockDate = stockDate,
                Expiration = expirationDate,
                RepairedDate = repairedDate,
                ReturnedDate = returnedDate,
                User = user,
                Status = status,
                Remarks = remarks
            };

            _ = Factory.StocksController().Insert(stocksModel);

            int stocksLastInsertedId = Factory.StocksController().LastInsertedId();
            int storeWarehouseId = (int)uc.cmbStoreWarehouse.SelectedValue;
            if (_isWarehouse) InsertWarehouseStock(stocksLastInsertedId, storeWarehouseId);
            else InsertStoreStock(stocksLastInsertedId, storeWarehouseId);

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
