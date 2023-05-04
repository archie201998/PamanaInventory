using System.Data;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Interfaces
{
    internal interface IItems : IController<ItemsModel>
    {
        DataTable Fetch(int storeId);
        decimal GetPrice(int itemId, string priceType);
        public int LastInsertedId();
    }
}
