using System.Data;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Interfaces
{
    internal interface IStoreStocks : IController<BranchStocksModel>
    {
        DataTable Fetch(int storeId, int itemId);
        DataTable Fetch(int itemId);
        DataTable Fetch(int storeId, string searchText);
        DataTable FetchItemsGroupByItem(int storesId, int categoriesId);
        DataTable FetchItemsGroupByItem(int storesId);
        DataTable FetchStocks(int storeId, int itemId);
        DataTable FetchBranches(int itemId);
        Dictionary<string, string> FindByStockId(int stockId);
    }
}
