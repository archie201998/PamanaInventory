using System.Data;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Interfaces
{
    internal interface ISales : IController<SalesModel>
    {
        DataTable Fetch(DateTime transactionDate);
        DataTable FetchByCustomerID(int customerID);
        int GenerateTransactionNumber();
        int LastInsertedId();
    }
}
