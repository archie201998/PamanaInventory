using System.Data;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class PurchaseItemController : IPurchaseItems
    {

        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblPurchaseItems = "purchased_items";

        public PurchaseItemController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public bool IdExist(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable Fetch()
        {
            throw new NotImplementedException();
        }

        public DataTable FetchBySearch(string searchText)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Insert(PurchaseItemsModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@purchases_id", DbType.Int32, entity.Purchases.Id },
                new object[] { "@items_id", DbType.Int32, entity.Items.Id },
                new object[] { "@amount", DbType.Decimal, entity.Amount},
                new object[] { "@quantity", DbType.Decimal, entity.Quantity },
            };

            string query = $"INSERT INTO {tblPurchaseItems} (purchases_id, items_id, amount, quantity) VALUES (@purchases_id, @items_id, @amount, @quantity)";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(PurchaseItemsModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<PurchaseItemsModel> entityList)
        {
            throw new NotImplementedException();
        }
    }
}