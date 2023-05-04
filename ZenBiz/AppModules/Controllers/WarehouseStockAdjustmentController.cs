using System.Data;
using System.Transactions;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class WarehouseStockAdjustmentController : IWarehouseStockAdjustments
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblWarehouseStockAdjustments = "warehouse_stock_adjustments";
        private const string viewWarehouseStockAdjustments = "view_warehouse_stock_adjustments";

        public WarehouseStockAdjustmentController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<WarehouseStockAdjustmentsModel> entityList)
        {
            using var scope = new TransactionScope();
            foreach (var entity in entityList)
            {
                var parameters = new object[][]
                {
                    new object[] { "@id", DbType.Int32, entity.Id},
                };

                string query = $"DELETE FROM {tblWarehouseStockAdjustments} WHERE id = @id";
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

        public DataTable Fetch(int warehouseId, DateTime dateFrom, DateTime dateTo)
        {
            var parameters = new object[][]
            {
                new object[] { "@warehouses_id", DbType.Int32, warehouseId },
                new object[] { "@date_from", DbType.Date, dateFrom },
                new object[] { "@date_to", DbType.Date, dateTo },
            };

            string query = $"SELECT id, items_id, sku_code, item_name, unit_name, retail_price, wholesale_price, special_price, quantity, date_adjusted, reason, created_by_user FROM {viewWarehouseStockAdjustments} WHERE warehouses_id = @warehouses_id AND date_adjusted BETWEEN @date_from AND @date_to ORDER BY date_adjusted DESC";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public DataTable Fetch(int itemId)
        {
            var parameters = new object[][]
            {
                new object[] { "@items_id", DbType.Int32, itemId },
            };

            string query = $"SELECT id, warehouses_id, warehouse_name, quantity, reason, date_adjusted FROM {viewWarehouseStockAdjustments} WHERE items_id = @items_id ORDER BY date_adjusted DESC";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public DataTable FetchBySearch(string searchText)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> FindById(int Id)
        {
            Dictionary<string, string> record = new();

            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32,  Id },
            };

            string query = $"SELECT items_id, warehouses_id, quantity, reason, date_adjusted, created_by, created_time, updated_by, updated_time, warehouse_name FROM {viewWarehouseStockAdjustments} WHERE id = @id";
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

        public bool Insert(WarehouseStockAdjustmentsModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@items_id", DbType.Int32, entity.Items.Id },
                new object[] { "@warehouses_id", DbType.Int32, entity.Warehouses.Id },
                new object[] { "@quantity", DbType.Decimal, entity.Quantity },
                new object[] { "@reason", DbType.String, entity.Reason },
                new object[] { "@date_adjusted", DbType.Date, entity.DateAdjusted },
                new object[] { "@created_by", DbType.Int32, entity.Users.Id }
            };

            string query = $"INSERT INTO {tblWarehouseStockAdjustments} (items_id, warehouses_id, quantity, reason, date_adjusted, created_by) VALUES (@items_id, @warehouses_id, @quantity, @reason,  @date_adjusted, @created_by)";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(WarehouseStockAdjustmentsModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32, entity.Id },
                new object[] { "@items_id", DbType.Int32, entity.Items.Id },
                new object[] { "@warehouses_id", DbType.Int32, entity.Warehouses.Id },
                new object[] { "@quantity", DbType.Decimal, entity.Quantity },
                new object[] { "@reason", DbType.String, entity.Reason },
                new object[] { "@date_adjusted", DbType.DateTime, entity.DateAdjusted },
                new object[] { "@updated_by", DbType.Int32, entity.Users.Id }
            };

            string query = $"UPDATE {tblWarehouseStockAdjustments} SET items_id = @items_id, warehouses_id = @warehouses_id, quantity = @quantity, reason = @reason, date_adjusted = @date_adjusted, updated_by = @updated_by WHERE id = @id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public decimal SumStockAdjusted(int warehouseId, int itemId)
        {
            var parameters = new object[][]
            {
                new object[] { "@warehouses_id", DbType.Int32, warehouseId },
                new object[] { "@items_id", DbType.Int32, itemId },
            };

            string query = $"SELECT SUM(quantity) FROM {tblWarehouseStockAdjustments} WHERE items_id = @items_id AND warehouses_id = @warehouses_id";
            string result = _dbGenericCommands.ExecuteScalar(query, parameters);
            if (string.IsNullOrWhiteSpace(result)) return 0;

            return Convert.ToDecimal(result);

        }
    }
}
