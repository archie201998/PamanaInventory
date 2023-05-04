using System.Data;
using System.Transactions;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class StocksController : IStocks
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblStocks = "stocks";

        public StocksController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<StocksModel> entityList)
        {
            using var scope = new TransactionScope();
            foreach (var entity in entityList)
            {
                var parameters = new object[][]
                {
                    new object[] { "@id", DbType.Int32, entity.Id},
                };

                string query = $"DELETE FROM {tblStocks} WHERE id = @id";
                _ = _dbGenericCommands.ExecuteNonQuery(query, parameters);
            }

            scope.Complete();
            scope.Dispose();
            return true;
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

        public bool IdExist(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(StocksModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@item_id", DbType.Int32, entity.Item.Id },
                new object[] { "@suppliers_id", DbType.Int32, entity.Supplier.Id },
                new object[] { "@quantity", DbType.Decimal, entity.Quantity },
                new object[] { "@stock_date", DbType.Date, entity.StockDate },
                new object[] { "@expiration", DbType.Date, entity.Expiration },
            };

            string query = $"INSERT INTO {tblStocks} (item_id, suppliers_id, quantity, stock_date, expiration) VALUES (@item_id, @suppliers_id, @quantity, @stock_date, @expiration)";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(StocksModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32, entity.Id },
                new object[] { "@item_id", DbType.Int32, entity.Item.Id },
                new object[] { "@suppliers_id", DbType.Int32, entity.Supplier.Id },
                new object[] { "@quantity", DbType.Decimal, entity.Quantity },
                new object[] { "@stock_date", DbType.Date, entity.StockDate },
                new object[] { "@expiration", DbType.Date, entity.Expiration },
            };

            string query = $"UPDATE {tblStocks} SET item_id = @item_id, suppliers_id = @suppliers_id, quantity = @quantity, stock_date = @stock_date, expiration = @expiration WHERE id = @id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public int LastInsertedId()
        {
            string query = $"SELECT MAX(id) FROM {tblStocks}";
            return Convert.ToInt32(_dbGenericCommands.ExecuteScalar(query));
        }
    }
}
