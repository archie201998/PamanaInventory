using System.Data;
using System.Transactions;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class BranchStockAdjustmentController : IStoreStockAdjustment
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string viewStoreStockAdjustments = "view_branch_stock_adjustments";

        public BranchStockAdjustmentController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<BranchStockAdjustmentsModel> entityList)
        {
            return true;
        }

        public DataTable Fetch()
        {
            throw new NotImplementedException();
        }

        public DataTable Fetch(int itemId)
        {
            var parameters = new object[][]
            {
                new object[] { "@items_id", DbType.Int32, itemId },
            };

            string query = $"SELECT id, stores_id, branch_name, quantity, reason, date_adjusted FROM {viewStoreStockAdjustments} WHERE items_id = @items_id ORDER BY date_adjusted DESC";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public DataTable Fetch(int storeId, DateTime dateFrom, DateTime dateTo)
        {
            var parameters = new object[][]
            {
                new object[] { "@stores_id", DbType.Int32, storeId },
                new object[] { "@date_from", DbType.Date, dateFrom },
                new object[] { "@date_to", DbType.Date, dateTo },
            };

            string query = $"SELECT id, items_id, sku_code, item_name, unit_name, retail_price, wholesale_price, special_price, quantity, date_adjusted, reason, created_by_user FROM {viewStoreStockAdjustments} WHERE stores_id = @stores_id AND date_adjusted BETWEEN @date_from AND @date_to ORDER BY date_adjusted DESC";
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

            string query = $"SELECT items_id, stores_id, quantity, reason, date_adjusted, created_by, created_time, updated_by, updated_time, branch_name FROM {viewStoreStockAdjustments} WHERE id = @id";
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

        public bool Insert(BranchStockAdjustmentsModel entity)
        {
            return false;
        }

        public bool Update(BranchStockAdjustmentsModel entity)
        {
            throw new NotImplementedException();
        }

        public decimal SumStockAdjusted(int storeId, int itemId)
        {
            throw new NotImplementedException();
        }
    }
}
