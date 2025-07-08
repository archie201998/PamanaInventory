using PamanaWaterInventory.AppModules.Interfaces;
using PamanaWaterInventory.AppModules.Models;
using System.Data;
using ZenBiz.AppModules;

namespace PamanaWaterInventory.AppModules.Controllers
{
    internal class RepairedHistoryController : IRepairedHistory
    {

        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblRepairedHistory = "stock_repair_history";
        private const string viewRepairedHistory = "view_stock_repair_history";

        public RepairedHistoryController(MySQLGenericCommands mySQLGenericCommands)
        {
            _dbGenericCommands = mySQLGenericCommands;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<RepairedHistoryModel> entityList)
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

            string query = $"SELECT * FROM {tblRepairedHistory} WHERE stocks_id = @stocks_id";
            using (var reader = _dbGenericCommands.ExecuteReader(query, parameters))
            {
                if (reader.Rows.Count == 0) return record;
                foreach (DataColumn column in reader.Columns)
                    record.Add(column.ColumnName, reader.Rows[0][column.ColumnName].ToString());
            }

            return record;
        }

        public DataTable GetViewRecordsByStockId(int stockId)
        {
            var parameters = new object[][]
            {
                new object[] { "@stocks_id", DbType.Int32, stockId },
            };

            string query = $"SELECT * FROM {tblRepairedHistory} WHERE stocks_id = @stocks_id ORDER BY repair_date DESC";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public bool IdExist(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(RepairedHistoryModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@reported_by", DbType.String, entity.ReportedBy },
                new object[] { "@issue_description", DbType.String, entity.IssueDescription },
                new object[] { "@repair_action", DbType.String, entity.RepairedAction },
                new object[] { "@repair_date", DbType.DateTime2, entity.RepairedDate.ToString("yyyy-MM-dd HH:mm:ss") },
                new object[] { "@repaired_by", DbType.String, entity.RepairedBy },
                new object[] { "@cost", DbType.Decimal, entity.RepairedCost },
                new object[] { "@other_details", DbType.String, entity.OtherDetails },
                new object[] { "@stocks_id", DbType.String, entity.StockID },
            };

            string query = $"INSERT INTO {tblRepairedHistory} (reported_by, issue_description, repair_action, repair_date, repaired_by, cost, other_details, stocks_id) VALUES (@reported_by, @issue_description, @repair_action, @repair_date, @repaired_by, @cost, @other_details, @stocks_id)";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(RepairedHistoryModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@reported_by", DbType.String, entity.ReportedBy },
                new object[] { "@issue_description", DbType.String, entity.IssueDescription },
                new object[] { "@repair_action", DbType.String, entity.RepairedAction },
                new object[] { "@repair_date", DbType.DateTime2, entity.RepairedDate.ToString("yyyy-MM-dd HH:mm:ss") },
                new object[] { "@repaired_by", DbType.String, entity.RepairedBy },
                new object[] { "@cost", DbType.Decimal, entity.RepairedCost },
                new object[] { "@other_details", DbType.String, entity.OtherDetails },
                new object[] { "@stocks_id", DbType.String, entity.StockID },
            };

            string query = $"UPDATE {tblRepairedHistory} SET reported_by=@reported_by, issue_description=@issue_description, repair_action=@repair_action, repair_date=@repair_date, repaired_by=@repaired_by, cost=@cost, other_details=@other_details WHERE stocks_id=@stocks_id AND id = @id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }
    }
}