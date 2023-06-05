using System.Data;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Interfaces
{
    internal interface IPayments : IController<PaymentsModel>
    {
        decimal BalanceAmount(int salesId);
        DataTable FetchByCustomerID(int customerID);
        DataTable FetchbySalesId(int salesId);
        Dictionary<string, string> FetchbySalesId_Dict(int salesId);
        decimal SumTotalPaymentsPerSalesId(int salesId);
    }
}
