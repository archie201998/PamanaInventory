using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Interfaces
{
    internal interface IPurchases : IController<PurchasesModel>
    {
        DataTable FetchByDatePeriod(DateTime purchasedDateFrom, DateTime purchaseDateTo);
        int LastInsertedId();
    }
}
