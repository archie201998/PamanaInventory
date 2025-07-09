using System.Data;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class BranchStocksController : IStoreStocks
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string branchStocks = "branch_stocks";
        private const string viewBranchStocks = "view_branch_stocks";

        public BranchStocksController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<BranchStocksModel> entityList)
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
                new object[] { "@branches_id", DbType.Int32, storesId },
                new object[] { "@categories_id", DbType.Int32, categoriesId },
            };

            string query = $"SELECT item_id, item_name, item_code, category_name, unit_measurements_name, abbreviation FROM {viewBranchStocks} WHERE branches_id = @branches_id AND categories_id = @categories_id GROUP BY item_id";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public DataTable FetchItemsGroupByItem(int storesId)
        {
            var parameters = new object[][]
            {
                new object[] { "@branches_id", DbType.Int32, storesId },
            };

            string query = $"SELECT item_id, item_name, item_code, category_name, unit_measurements_name, abbreviation FROM {viewBranchStocks} WHERE branches_id = @branches_id GROUP BY item_id";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public DataTable Fetch(int itemId)
        {
            var parameters = new object[][]
            {
                new object[] { "@item_id", DbType.String, itemId },
            };

            string query = $"SELECT * FROM {viewBranchStocks} WHERE item_id = @item_id";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public DataTable Fetch(int branchId, int itemId)
        {
            var parameters = new object[][]               
            {
                new object[] { "@branches_id", DbType.String, branchId   },
                new object[] { "@item_id", DbType.String, itemId },
            };

            string query = $"SELECT * FROM {viewBranchStocks} WHERE branches_id = @branches_id AND item_id = @item_id";
            return _dbGenericCommands.Fill(query, parameters);              
        }

        public DataTable Fetch(int storeId, string searchText)
        {
            var parameters = new object[][]
            {
                new object[] { "@branches_id", DbType.Int32, storeId },
                new object[] { "@search_text", DbType.String, $"%{searchText}%"},
            };

            string query = $"SELECT id, item_id, item_name, SUM(quantity) AS total_quantity FROM {viewBranchStocks} WHERE branches_id = @branches_id AND item_name LIKE @search_text GROUP BY branches_id, item_id";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public DataTable FetchBranchesStocks(int itemId)
        {
            var parameters = new object[][]
            {
                new object[] { "@item_id", DbType.String, itemId },
            };

            string query = $"SELECT DISTINCT branches_id, branch_name FROM {viewBranchStocks} WHERE item_id = @item_id";
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

            string query = $"SELECT * FROM {viewBranchStocks} WHERE stocks_id = @stocks_id";
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

        public bool Insert(BranchStocksModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@stocks_id", DbType.String, entity.Stock.Id },
                new object[] { "@branches_id", DbType.String, entity.Branch.Id },
            };

            string query = $"INSERT INTO {branchStocks} (stocks_id, branches_id) VALUES (@stocks_id, @branches_id)";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(BranchStocksModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@branches_id", DbType.String, entity.Branch.Id },
                new object[] { "@stocks_id", DbType.String, entity.Stock.Id },
            };

            string query = $"UPDATE {branchStocks} SET branches_id = @branches_id WHERE stocks_id = @stocks_id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public DataTable FetchStocks(int storeId, int itemId)
        {
            var parameters = new object[][]
            {
                new object[] { "@branches_id", DbType.String, storeId },
                new object[] { "@item_id", DbType.String, itemId },
            };

            string query = $"SELECT id* FROM {viewBranchStocks} WHERE branches_id = @branches_id AND item_id = @item_id";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public decimal SumTotalStocks(int storeId, int itemId)
        {
            var parameters = new object[][]
            {
                new object[] { "@branches_id", DbType.Int32, storeId },
                new object[] { "@item_id", DbType.Int32, itemId },
            };

            string query = $"SELECT COUNT(branches_id) FROM {viewBranchStocks} WHERE branches_id = @branches_id AND item_id = @item_id";
            string result = _dbGenericCommands.ExecuteScalar(query, parameters);
            if (string.IsNullOrWhiteSpace(result)) return 0;
            return Convert.ToDecimal(result);
        }

       
    }
}
