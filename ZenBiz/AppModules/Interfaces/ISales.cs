using System.Data;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Interfaces
{
    internal interface ISales : IController<SalesModel>
    {
        DataTable Fetch(DateTime transactionDate);
        DataTable FetchByCustomerID(int customerID);
        DataTable FetchByTransactionNo(string transactionNo);
        int GenerateTransactionNumber();
        int LastInsertedId();
    }
}
