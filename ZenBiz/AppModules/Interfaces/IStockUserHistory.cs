using PamanaWaterInventory.AppModules.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBiz.AppModules;

namespace PamanaWaterInventory.AppModules.Interfaces
{
    internal interface IStockUserHistory : IController<StockUserHistoryModel>
    {
        DataTable GetViewRecordsByStockId(int stockId);
    }
}
