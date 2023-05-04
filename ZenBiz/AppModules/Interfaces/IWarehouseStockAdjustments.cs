using System.Data;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Interfaces
{
    internal interface IWarehouseStockAdjustments : IController<WarehouseStockAdjustmentsModel>
    {
        DataTable Fetch(int itemId);
        DataTable Fetch(int warehouseId, DateTime dateFrom, DateTime dateTo);
        decimal SumStockAdjusted(int itemId, int storeId);
    }
}
