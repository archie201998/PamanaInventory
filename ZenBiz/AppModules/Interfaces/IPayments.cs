using System.Data;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Interfaces
{
    internal interface IPayments : IController<PaymentsModel>
    {
        decimal BalanceAmount(int salesId);
        DataTable FetchbySalesId(int salesId);
        decimal SumTotalPaymentsPerSalesId(int salesId);
    }
}
