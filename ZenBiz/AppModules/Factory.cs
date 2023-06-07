using ZenBiz.AppModules.Controllers;
using ZenBiz.AppModules.Interfaces;

namespace ZenBiz.AppModules
{
    internal class Factory
    {
        private static MySQLGenericCommands mySQLGenericCommands = new MySQLGenericCommands();


        public static IBusinessDetails BusinessDetailsController() => new BusinessDetailsController(mySQLGenericCommands);
        public static IPayments PaymentsController() => new PaymentsController(mySQLGenericCommands);
        public static IPaymentTypes PaymentTypesController() => new PaymentTypesController(mySQLGenericCommands);
        public static IUsers UsersController() => new UsersController(mySQLGenericCommands);
        public static IRoles RolesController() => new RolesController(mySQLGenericCommands);
        public static ISales SalesController() => new SalesController(mySQLGenericCommands);
        public static ISalesItem SalesItemController() => new SalesItemController(mySQLGenericCommands);
        public static ICustomers CustomersController() => new CustomersController(mySQLGenericCommands);
        public static IWarehouseStockAdjustments WarehouseStockAdjustmentController() => new WarehouseStockAdjustmentController(mySQLGenericCommands);
        public static IStoreStockAdjustment StoreStockAdjustmentController() => new StoreStockAdjustmentController(mySQLGenericCommands);
        public static IStockAdjustments StockAdjustmentsController() => new StockAdjustmentsController(mySQLGenericCommands);
        public static IStocks StocksController() => new StocksController(mySQLGenericCommands);
        public static IItems ItemsController() => new ItemsController(mySQLGenericCommands);
        public static IStore StoresController() => new StoresController(mySQLGenericCommands);
        public static IStoreStocks StoreStocksController() => new StoreStocksController(mySQLGenericCommands);
        public static IWarehouses WarehousesController() => new WarehousesController(mySQLGenericCommands);
        public static IWarehouseStocks WarehouseStocksController() => new WarehouseStocksController(mySQLGenericCommands);
        public static ICategories CategoriesController() => new CategoriesController(mySQLGenericCommands);
        public static ISupplier SuppliersController() => new SuppliersController(mySQLGenericCommands);
        public static IUnitsOfMeasurements UnitsOfMeasurementsController() => new UnitsOfMeasurementsController(mySQLGenericCommands);
        public static IPurchases PurchaseController() => new PurchaseController(mySQLGenericCommands);
        public static IPurchaseItems PurchaseItemController() => new PurchaseItemController(mySQLGenericCommands);
        public static IPurchasedPayments PurchasePaymentsController() => new PurchasePaymentsController(mySQLGenericCommands);
        public static IPersonnel PersonnelController() => new PersonnelController(mySQLGenericCommands);
        public static IServices ServicesController() => new ServicesController(mySQLGenericCommands);
    }
}
