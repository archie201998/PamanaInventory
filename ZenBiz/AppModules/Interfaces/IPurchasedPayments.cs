using System.Data;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Interfaces
{
    internal interface IPurchasedPayments : IController<PurchasePaymentModel>
    {
        decimal BalanceAmountPerPurchased(int purchaseId);
        DataTable FetchbyPurchaseId(int purchaseId);
        decimal TotalAmountPaidPerPurchased(int purchaseId);
    }
}
