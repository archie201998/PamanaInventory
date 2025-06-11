using ZenBiz.AppModules.Controllers;
using ZenBiz.AppModules.Interfaces;

namespace ZenBiz.AppModules
{
    internal class Factory
    {
        private static MySQLGenericCommands mySQLGenericCommands = new MySQLGenericCommands();


        public static IBusinessDetails BusinessDetailsController() => new BusinessDetailsController(mySQLGenericCommands);
        public static IUsers UsersController() => new UsersController(mySQLGenericCommands);
        public static IRoles RolesController() => new RolesController(mySQLGenericCommands);
        public static IStoreStockAdjustment StoreStockAdjustmentController() => new BranchStockAdjustmentController(mySQLGenericCommands);

        public static IStocks StocksController() => new StocksController(mySQLGenericCommands);
        public static IItems ItemsController() => new ItemsController(mySQLGenericCommands);
        public static IStore BranchesController() => new BranchController(mySQLGenericCommands);
        public static IStoreStocks BranchStocksController() => new BranchStocksController(mySQLGenericCommands);
        public static ICategories CategoriesController() => new CategoriesController(mySQLGenericCommands);
        public static ISupplier SuppliersController() => new SuppliersController(mySQLGenericCommands);
        public static IUnitsOfMeasurements UnitsOfMeasurementsController() => new UnitsOfMeasurementsController(mySQLGenericCommands);

        public static IPersonnel PersonnelController() => new PersonnelController(mySQLGenericCommands);
    }
}
