using System.Transactions;
using ZenBiz.AppModules.Inventory.Items;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Inventory.Items
{
    public partial class FrmItemsAdd : Form
    {
        private readonly UcItems uc;

        public FrmItemsAdd()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            uc = ucItems1;
        }

        private bool InsertItems()
        {
            ItemsModel itemsModel = new()
            {
                Categories = new CategoriesModel() { Id = Convert.ToInt32(uc.cmbCategory.SelectedValue) },
                UnitOfMeasurements = new UnitOfMeasurementsModel() { Id = Convert.ToInt32(uc.cmbUnit.SelectedValue) },
                Code = uc.txtCode.Text.Trim(),
                Name = uc.txtName.Text.Trim(),
                UnitCost = uc.nudUnitCost.Value,
                RetailPrice = uc.nudRetailPrice.Value,
                WholesalePrice = uc.nudWholesalePrice.Value,
                SpecialPrice = uc.nudSpecialPrice.Value,
                MinimumThresholdStocks = (float)uc.nudMinStockThreshold.Value,
                Users = new UsersModel() { Id = 1 }
            };

            return Factory.ItemsController().Insert(itemsModel);
        }

        private void InsertStoreStocks()
        {
            var stocksController = Factory.StocksController();
            var storeStocksController = Factory.StoreStocksController();
            foreach (DataGridViewRow item in uc.dgStoreStocks.Rows)
            {
                DateTime? stockDate = !string.IsNullOrWhiteSpace(item.Cells["stock_date"].Value.ToString()) ? Convert.ToDateTime(item.Cells["stock_date"].Value.ToString()) : null;
                DateTime? expirationDate = !string.IsNullOrWhiteSpace(item.Cells["expiration"].Value.ToString()) ? Convert.ToDateTime(item.Cells["expiration"].Value.ToString()) : null;

                StocksModel stocksModel = new()
                {
                    Item = new ItemsModel() { Id = Factory.ItemsController().LastInsertedId() },
                    Quantity = Convert.ToDecimal(item.Cells["stocks"].Value),
                    StockDate = stockDate,
                    Expiration = expirationDate,
                };

                stocksController.Insert(stocksModel);

                StoreStocksModel storeStocksModel = new()
                {
                    Stock = new StocksModel() { Id = stocksController.LastInsertedId() },
                    Store = new StoresModel() { Id = Convert.ToInt32(item.Cells["store_warehouse_id"].Value) }
                };

                storeStocksController.Insert(storeStocksModel);
            }
        }

        private void InsertWarehouseStocks()
        {
            var stocksController = Factory.StocksController();
            var warehouseStocksController = Factory.WarehouseStocksController();
            foreach (DataGridViewRow item in uc.dgWarehouseStocks.Rows)
            {
                DateTime? stockDate = !string.IsNullOrWhiteSpace(item.Cells["stock_date"].Value.ToString()) ? Convert.ToDateTime(item.Cells["stock_date"].Value.ToString()) : null;
                DateTime? expirationDate = !string.IsNullOrWhiteSpace(item.Cells["expiration"].Value.ToString()) ? Convert.ToDateTime(item.Cells["expiration"].Value.ToString()) : null;

                StocksModel stocksModel = new()
                {
                    Item = new ItemsModel() { Id = Factory.ItemsController().LastInsertedId() },
                    Quantity = Convert.ToDecimal(item.Cells["stocks"].Value),
                    StockDate = stockDate,
                    Expiration = expirationDate
                };

                stocksController.Insert(stocksModel);

                WarehouseStocksModel warehouseStocksModel = new()
                {
                    Stock = new StocksModel() { Id = stocksController.LastInsertedId() },
                    Warehouse = new WarehousesModel() { Id = Convert.ToInt32(item.Cells["store_warehouse_id"].Value) }
                };

                warehouseStocksController.Insert(warehouseStocksModel);
            }
        }

        private bool SaveData()
        {
            try
            {
                if (!uc.ValidateChildren())
                {
                    Helper.MessageBoxError(uc.GetFormErrors());
                    return false;
                }

                using TransactionScope scope = new();
                _ = InsertItems();
                InsertStoreStocks();
                InsertWarehouseStocks();

                scope.Complete();
                return true;
            }
            catch (Exception ex)
            {
                Helper.MessageBoxError(ex.Message);
            }

            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Helper.MessageBoxSuccess("Item has been saved.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
