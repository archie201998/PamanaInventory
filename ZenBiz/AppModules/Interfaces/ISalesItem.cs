using System.Data;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Interfaces
{
    internal interface ISalesItem : IController<SalesItemModel>
    {
        bool DeletePerSalesId(int salesId);
        DataTable Fetch(DateTime dateFrom, DateTime dateTo);
        DataTable Fetch(DateTime dateFrom, DateTime dateTo, int storeId);
        DataTable FetchBySalesId(int salesId);
        DataTable FetchBySalesIdPerCustomer(int salesID, int customerID);
        DataTable FetchSoldItems(DateTime dateFrom, DateTime dateTo);
        DataTable FetchSoldItems(DateTime dateFrom, DateTime dateTo, int storeId);
        decimal GrossSales(int salesId);
        decimal GrossSales(DateTime dateFrom, DateTime dateTo);
        decimal GrossSalesPerCustomer(int customerId);
        decimal SumTotalStocksSold(int storeId, int itemId);
    }
}
