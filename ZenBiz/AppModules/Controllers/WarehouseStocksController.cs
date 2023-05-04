using System.Data;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class WarehouseStocksController : IWarehouseStocks
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblWarehouseStocks = "warehouse_stocks";
        private const string viewWarehouseStocks = "view_warehouse_stocks";

        public WarehouseStocksController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<WarehouseStocksModel> entityList)
        {
            throw new NotImplementedException();
        }

        public DataTable Fetch()
        {
            throw new NotImplementedException();
        }

        public DataTable Fetch(int warehouseId, int itemId)
        {
            var parameters = new object[][]
            {
                new object[] { "@warehouses_id", DbType.String, warehouseId },
                new object[] { "@item_id", DbType.String, itemId },
            };

            string query = $"SELECT id, stocks_id, warehouse_name, quantity, stock_date, expiration, suppliers_name FROM {viewWarehouseStocks} WHERE warehouses_id = @warehouses_id AND item_id = @item_id";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public DataTable Fetch(int itemId)
        {
            var parameters = new object[][]
            {
                new object[] { "@item_id", DbType.String, itemId },
            };

            string query = $"SELECT id, stocks_id, warehouse_name, quantity, stock_date, expiration, suppliers_name FROM {viewWarehouseStocks} WHERE item_id = @item_id";
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

            string query = $"SELECT warehouses_id, suppliers_id, warehouse_name, warehouse_address, item_id, quantity, stock_date, expiration, suppliers_name FROM {viewWarehouseStocks} WHERE stocks_id = @stocks_id";
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

        public bool Insert(WarehouseStocksModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@stocks_id", DbType.Int32, entity.Stock.Id },
                new object[] { "@warehouses_id", DbType.Int32, entity.Warehouse.Id },
            };

            string query = $"INSERT INTO {tblWarehouseStocks} (stocks_id, warehouses_id) VALUES (@stocks_id, @warehouses_id)";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(WarehouseStocksModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@stocks_id", DbType.Int32, entity.Stock.Id },
                new object[] { "@warehouses_id", DbType.Int32, entity.Warehouse.Id },
            };

            string query = $"UPDATE {tblWarehouseStocks} SET warehouses_id = @warehouses_id WHERE stocks_id = @stocks_id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public decimal SumTotalStocks(int warehouseId, int itemId)
        {
            var parameters = new object[][]
            {
                new object[] { "@warehouses_id", DbType.String, warehouseId },
                new object[] { "@item_id", DbType.String, itemId },
            };

            string query = $"SELECT SUM(quantity) FROM {viewWarehouseStocks} WHERE warehouses_id = @warehouses_id AND item_id = @item_id";
            string result = _dbGenericCommands.ExecuteScalar(query, parameters);
            if (string.IsNullOrWhiteSpace(result)) return 0;
            return Convert.ToDecimal(result);
        }
    }
}
