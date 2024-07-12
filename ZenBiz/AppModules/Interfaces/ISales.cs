using System.Data;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Interfaces
{
    internal interface ISales : IController<SalesModel>
    {
        DataTable Fetch(DateTime transactionDate);
        DataTable FetchByCustomerID(int customerID);
        Dictionary<string, string> FetchByTransactionNo(string transactionNo);
        DataTable FetchSalesDue(int monthId, int year);
        int GenerateTransactionNumber();
        int LastInsertedId();
    }
}
