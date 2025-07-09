using PamanaWaterInventory.AppModules.Interfaces;
using PamanaWaterInventory.AppModules.Models;
using System.CodeDom;
using System.Data;
using ZenBiz.AppModules;

namespace PamanaWaterInventory.AppModules.Controllers
{
    internal class StockUserHistoryController : IStockUserHistory
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblStocksUserHistory = "stock_user_history";
        private const string viewStocks = "view_stock_user_history";

        public StockUserHistoryController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<StockUserHistoryModel> entityList)
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
            Dictionary<string, string> record = new();

            var parameters = new object[][]
            {
                new object[] { "@stocks_id", DbType.Int32,  Id },
            };

            string query = $"SELECT * FROM {tblStocksUserHistory} WHERE stocks_id = @stocks_id";
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

        public bool Insert(StockUserHistoryModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@user", DbType.String, entity.User },
                new object[] { "@assigned_date", DbType.String, entity.AssignedDate.ToString("yyyy-MM-dd HH:mm:ss") },
                new object[] { "@unassigned_date", DbType.String, entity.ReturnedDate.ToString("yyyy-MM-dd HH:mm:ss") },
                new object[] { "@branches_id", DbType.Int32, entity.BranchID },
                new object[] { "@stocks_id", DbType.Int32, entity.StockID },
                new object[] { "@is_current_user", DbType.Int32, entity.IsCurrentUser },
            };

            string query = $"INSERT INTO {tblStocksUserHistory} (user, assigned_date, unassigned_date, branches_id, stocks_id, is_current_user) VALUES (@user, @assigned_date, @unassigned_date, @branches_id, @stocks_id, @is_current_user)";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(StockUserHistoryModel entity)
        {
            throw new NotImplementedException();
        }

        public DataTable GetViewRecordsByStockId(int stockId)
        {
            var parameters = new object[][]
            {
                new object[] { "@stocks_id", DbType.Int32, stockId },
            };

            string query = $"SELECT * FROM {tblStocksUserHistory} WHERE stocks_id = @stocks_id ";
            return _dbGenericCommands.Fill(query, parameters);
        }
    }
}