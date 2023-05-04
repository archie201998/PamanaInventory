using System.Data;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Interfaces
{
    internal interface IWarehouseStocks : IController<WarehouseStocksModel>
    {
        DataTable Fetch(int warehouseId, int itemId);
        DataTable Fetch(int itemId);
        Dictionary<string, string> FindByStockId(int stockId);
        decimal SumTotalStocks(int warehouseId, int itemId);
    }
}
