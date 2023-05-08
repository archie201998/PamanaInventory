using System.Data;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class StoreStocksController : IStoreStocks
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblStoreStocks = "store_stocks";
        private const string viewStoreStocks = "view_store_stocks";

        public StoreStocksController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<StoreStocksModel> entityList)
        {
            throw new NotImplementedException();
        }

        public DataTable Fetch()
        {
            throw new NotImplementedException();
        }

        public DataTable FetchItemsGroupByItem(int storesId, int categoriesId)
        {
            var parameters = new object[][]
            {
                new object[] { "@stores_id", DbType.Int32, storesId },
                new object[] { "@categories_id", DbType.Int32, categoriesId },
            };

            string query = $"SELECT item_id, sku_code, item_name, category_name, unit_name, unit_cost, retail_price, wholesale_price, special_price, min_threshold_stock FROM {viewStoreStocks} WHERE stores_id = @stores_id AND categories_id = @categories_id GROUP BY item_id";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public DataTable FetchItemsGroupByItem(int storesId)
        {
            var parameters = new object[][]
            {
                new object[] { "@stores_id", DbType.Int32, storesId },
            };

            string query = $"SELECT item_id, sku_code, item_name, category_name, unit_name, unit_cost, retail_price, wholesale_price, special_price, min_threshold_stock FROM {viewStoreStocks} WHERE stores_id = @stores_id GROUP BY item_id";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public DataTable Fetch(int itemId)
        {
            var parameters = new object[][]
            {
                new object[] { "@item_id", DbType.String, itemId },
            };

            string query = $"SELECT id, stocks_id, store_name, quantity, stock_date, expiration, suppliers_name FROM {viewStoreStocks} WHERE item_id = @item_id";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public DataTable Fetch(int storeId, int itemId)
        {
            var parameters = new object[][]
            {
                new object[] { "@stores_id", DbType.String, storeId },
                new object[] { "@item_id", DbType.String, itemId },
            };

            string query = $"SELECT id, stocks_id, store_name, quantity, stock_date, expiration, suppliers_name FROM {viewStoreStocks} WHERE stores_id = @stores_id AND item_id = @item_id";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public DataTable Fetch(int storeId, string searchText)
        {
            var parameters = new object[][]
            {
                new object[] { "@stores_id", DbType.Int32, storeId },
                new object[] { "@search_text", DbType.String, $"%{searchText}%"},
            };

            string query = $"SELECT id, item_id, sku_code, item_name, retail_price, wholesale_price, special_price, SUM(quantity) AS total_quantity FROM {viewStoreStocks} WHERE stores_id = @stores_id AND item_name LIKE @search_text GROUP BY stores_id, item_id";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public DataTable FetchBySearch(string searchText)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> FindByStockId(int stockId)
        {
            Dictionary<string, string> record = new();

            var parameters = new object[][]
            {
                new object[] { "@stocks_id", DbType.Int32, stockId },
            };

            string query = $"SELECT stores_id, suppliers_id, store_name, store_address, item_id, quantity, stock_date, expiration, suppliers_name FROM {viewStoreStocks} WHERE stocks_id = @stocks_id";
            using (var reader = _dbGenericCommands.ExecuteReader(query, parameters))
            {
                if (reader.Rows.Count == 0) return record;
                foreach (DataColumn column in reader.Columns)
                    record.Add(column.ColumnName, reader.Rows[0][column.ColumnName].ToString());
            }

            return record;
        }

        public bool IdExist(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(StoreStocksModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@stores_id", DbType.String, entity.Store.Id },
                new object[] { "@stocks_id", DbType.String, entity.Stock.Id },
            };

            string query = $"INSERT INTO {tblStoreStocks} (stocks_id, stores_id) VALUES (@stocks_id, @stores_id)";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(StoreStocksModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@stores_id", DbType.String, entity.Store.Id },
                new object[] { "@stocks_id", DbType.String, entity.Stock.Id },
            };

            string query = $"UPDATE {tblStoreStocks} SET stores_id = @stores_id WHERE stocks_id = @stocks_id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public DataTable FetchStocks(int storeId, int itemId)
        {
            var parameters = new object[][]
            {
                new object[] { "@stores_id", DbType.String, storeId },
                new object[] { "@item_id", DbType.String, itemId },
            };

            string query = $"SELECT id, stocks_id, store_name, store_address, quantity, stock_date, expiration FROM {viewStoreStocks} WHERE stores_id = @stores_id AND item_id = @item_id";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public decimal SumTotalStocks(int storeId, int itemId)
        {
            var parameters = new object[][]
            {
                new object[] { "@stores_id", DbType.Int32, storeId },
                new object[] { "@item_id", DbType.Int32, itemId },
            };

            string query = $"SELECT SUM(quantity) FROM {viewStoreStocks} WHERE stores_id = @stores_id AND item_id = @item_id";
            string result = _dbGenericCommands.ExecuteScalar(query, parameters);
            if (string.IsNullOrWhiteSpace(result)) return 0;
            return Convert.ToDecimal(result);
        }

        public decimal StocksLeft(int storeId, int itemId)
        {
            decimal totalStocks = SumTotalStocks(storeId, itemId);
            decimal totalStocksAdjusted = Factory.StoreStockAdjustmentController().SumStockAdjusted(storeId, itemId);
            decimal totalStockSold = Factory.SalesItemController().SumTotalStocksSold(storeId, itemId);
            return totalStocks + totalStocksAdjusted - totalStockSold;
        }
    }
}
