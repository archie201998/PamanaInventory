using System.Data;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class PurchaseItemController : IPurchaseItems
    {

        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblPurchaseItems = "purchased_items";
        private const string viewPurchaseItems = "view_purchased_items";

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
        public DataTable FetchByPurchaseId(int purchaseId)
        {
            var parameters = new object[][]
            {
                new object[] { "@purchases_id", DbType.Int32, purchaseId },
            };

            string query = $"SELECT purchased_id, items_id, name, unit_cost, unit_name, purchased_amount, purchased_quantity, (purchased_amount*purchased_quantity) AS total_purchased_amount FROM {viewPurchaseItems} WHERE purchased_id = @purchases_id";

            return _dbGenericCommands.Fill(query, parameters);
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

        public bool DeletePerPurchaseId(int purchaseId)
        {
            var parameters = new object[][]
            {
                new object[] { "@purchases_id", DbType.Int32, purchaseId },
            };

            string query = $"DELETE FROM {tblPurchaseItems} WHERE purchases_id = @purchases_id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public decimal TotalAmountPerPurchased(int purchaseId)
        {
            var parameters = new object[][]
            {
                new object[] { "@purchases_id", DbType.Int32, purchaseId },
            };
            string query = $"SELECT SUM(amount * quantity) FROM {tblPurchaseItems} WHERE purchases_id = @purchases_id GROUP BY purchases_id";
            string result = _dbGenericCommands.ExecuteScalar(query, parameters);
            if (string.IsNullOrWhiteSpace(result)) return 0;
            return Convert.ToDecimal(result);
        }
    }
}