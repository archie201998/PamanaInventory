using System.Data;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Interfaces
{
    internal interface IStockAdjustments : IController<StockAdjustmentsModel>
    {
        DataTable Fetch(int itemId);
    }
}
