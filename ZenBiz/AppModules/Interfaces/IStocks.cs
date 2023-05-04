using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Interfaces
{
    internal interface IStocks : IController<StocksModel>
    {
        int LastInsertedId();
    }
}
