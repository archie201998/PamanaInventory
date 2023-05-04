using System.Data;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Interfaces
{
    internal interface IStoreStockAdjustment : IController<StoreStockAdjustmentsModel>
    {
        DataTable Fetch(int itemId);
        DataTable Fetch(int storeId, DateTime dateFrom, DateTime dateTo);
        decimal SumStockAdjusted(int itemId, int storeId);
    }
}
