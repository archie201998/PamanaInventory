using System.Data;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Interfaces
{
    internal interface IItems : IController<ItemsModel>
    {
        DataTable Fetch(int storeId);

        public int LastInsertedId();
        DataTable SearchItemByCode(string itemCode);
    }
}
