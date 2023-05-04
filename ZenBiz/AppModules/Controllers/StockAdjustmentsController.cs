using System.Data;
using System.Transactions;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class StockAdjustmentsController : IStockAdjustments
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblStoreStockAdjustments = "store_stock_adjustments";

        public StockAdjustmentsController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<StockAdjustmentsModel> entityList)
        {
            using var scope = new TransactionScope();
            foreach (var entity in entityList)
            {
                var parameters = new object[][]
                {
                    new object[] { "@id", DbType.Int32, entity.Id},
                };

                string query = $"DELETE FROM {tblStoreStockAdjustments} WHERE id = @id";
                _ = _dbGenericCommands.ExecuteNonQuery(query, parameters);
            }

            scope.Complete();
            scope.Dispose();
            return true;
        }

        public DataTable Fetch()
        {
            string query = $"SELECT id, quantity, reason, date_time FROM {tblStoreStockAdjustments}";
            return _dbGenericCommands.Fill(query);
        }


        public DataTable Fetch(int itemId)
        {
            var parameters = new object[][]
            {
                new object[] { "@items_id", DbType.Int32, itemId },
            };

            string query = $"SELECT id, quantity, reason, date_time FROM {tblStoreStockAdjustments} WHERE items_id = @items_id";
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

            string query = $"SELECT items_id, quantity, reason, date_time FROM {tblStoreStockAdjustments} WHERE id = @id";
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

        public bool Insert(StockAdjustmentsModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@items_id", DbType.Int32, entity.Items.Id },
                new object[] { "@quantity", DbType.Decimal, entity.Quantity },
                new object[] { "@reason", DbType.String, entity.Reason },
                new object[] { "@date_time", DbType.DateTime, entity.DateTime },
                new object[] { "@created_by", DbType.Int32, entity.Users.Id }
            };

            string query = $"INSERT INTO {tblStoreStockAdjustments} (items_id, quantity, reason, date_time, created_by) VALUES (@items_id, @quantity, @reason,  @date_time, @created_by)";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(StockAdjustmentsModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32, entity.Id },
                new object[] { "@items_id", DbType.Int32, entity.Items.Id },
                new object[] { "@quantity", DbType.Decimal, entity.Quantity },
                new object[] { "@reason", DbType.String, entity.Reason },
                new object[] { "@date_time", DbType.DateTime, entity.DateTime },
                new object[] { "@created_by", DbType.Int32, entity.Users.Id }
            };

            string query = $"UPDATE {tblStoreStockAdjustments} SET items_id = @items_id, quantity = @quantity, reason = @reason, date_time = @date_time, created_by = @created_by WHERE id = @id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }
    }
}
