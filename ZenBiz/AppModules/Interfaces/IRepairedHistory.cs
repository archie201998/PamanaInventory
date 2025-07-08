using PamanaWaterInventory.AppModules.Models;
using System.Data;
using ZenBiz.AppModules;

namespace PamanaWaterInventory.AppModules.Interfaces
{
    internal interface IRepairedHistory : IController<RepairedHistoryModel>
    {
        DataTable GetViewRecordsByStockId(int stockId);
    }
}
