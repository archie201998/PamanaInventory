using System.Data;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Interfaces
{
    internal interface IStoreStocks : IController<StoreStocksModel>
    {
        DataTable Fetch(int storeId, int itemId);
        DataTable Fetch(int itemId);
        DataTable Fetch(int storeId, string searchText);
        DataTable FetchItemsGroupByItem(int storesId, int categoriesId);
        DataTable FetchItemsGroupByItem(int storesId);
        DataTable FetchStocks(int storeId, int itemId);
        DataTable FetchStores(int itemId);
        Dictionary<string, string> FindByStockId(int stockId);
        decimal StocksLeft(int storeId, int itemId);
        decimal SumTotalStocks(int storeId, int itemId);
    }
}
