using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Interfaces
{
    internal interface IPurchasedPayments : IController<PurchasePaymentModel>
    {
        decimal TotalAmountPaidPerPurchased(int purchaseId);
    }
}
