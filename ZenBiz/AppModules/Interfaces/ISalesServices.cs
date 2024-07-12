using System.Data;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Interfaces
{
    internal interface ISalesServices : IController<SalesServicesModel>
    {
        bool DeletePerSalesId(int salesId);
        DataTable FetchBetweenDates(DateTime dateFrom, DateTime dateTo);
        DataTable FetchBetweenDatesAndStore(DateTime dateFrom, DateTime dateTo, int storeId);
        DataTable FetchBySalesId(int salesId);
        decimal GrossSales(int salesId);
    }
}
