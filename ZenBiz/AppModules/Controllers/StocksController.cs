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
        private const string viewStocks = "view_stocks";

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
            Dictionary<string, string> record = new();

            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32,  Id },
            };

            string query = $"SELECT * FROM {viewStocks} WHERE id = @id";
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

        public bool Insert(StocksModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@item_id", DbType.Int32, entity.Item.Id },
                new object[] { "@suppliers_id", DbType.Int32, entity.Supplier.Id },
                new object[] { "@serial_number", DbType.String, entity.SerialNumber },
                new object[] { "@model", DbType.String, entity.Model },
                new object[] { "@operating_system", DbType.String, entity.OperatingSystem },
                new object[] { "@RAM", DbType.String, entity.RAM },
                new object[] { "@computer_name", DbType.String, entity.ComputerName },
                new object[] { "@sophos_tamper", DbType.String, entity.SophosTamper },
                new object[] { "@date_acquired", DbType.Date, entity.DateAcquired },
                new object[] { "@unit_cost", DbType.Decimal, entity.UnitCost },
                new object[] { "@status", DbType.String, entity.Status },
                new object[] { "@remarks", DbType.String, entity.Remarks },
                new object[] { "@created_by", DbType.Int32, 1 },
            };

            string query = $"INSERT INTO {tblStocks} (item_id, suppliers_id, serial_number, model, operating_system, RAM, computer_name, sophos_tamper, date_acquired, unit_cost, status, remarks, created_by) VALUES (@item_id, @suppliers_id, @serial_number, @model, @operating_system, @RAM, @computer_name, @sophos_tamper, @date_acquired, @unit_cost, @status, @remarks, @created_by)";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(StocksModel entity)
        {
          var parameters = new object[][]
          {
                new object[] { "@id", DbType.Int32, entity.Id},
                new object[] { "@suppliers_id", DbType.Int32, entity.Supplier.Id },
                new object[] { "@item_id", DbType.Int32, entity.Item.Id },
                new object[] { "@serial_number", DbType.String, entity.SerialNumber },
                new object[] { "@model", DbType.String, entity.Model },
                new object[] { "@operating_system", DbType.String, entity.OperatingSystem },
                new object[] { "@RAM", DbType.String, entity.RAM },
                new object[] { "@computer_name", DbType.String, entity.ComputerName },
                new object[] { "@sophos_tamper", DbType.String, entity.SophosTamper },
                new object[] { "@date_acquired", DbType.Date, entity.DateAcquired },
                new object[] { "@unit_cost", DbType.Decimal, entity.UnitCost },
                new object[] { "@status", DbType.String, entity.Status },
                new object[] { "@remarks", DbType.String, entity.Remarks },
                new object[] { "@updated_by", DbType.Int32, 1 },
          };

          string query = $"UPDATE {tblStocks} SET item_id = @item_id, suppliers_id = @suppliers_id, serial_number = @serial_number, model = @model, operating_system = @operating_system, RAM = @RAM, computer_name = @computer_name, sophos_tamper = @sophos_tamper, date_acquired = @date_acquired, unit_cost = @unit_cost, status = @status, remarks = @remarks, updated_by = @updated_by WHERE id = @id;";
          return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public int LastInsertedId()
        {
            string query = $"SELECT MAX(id) FROM {tblStocks}";
            return Convert.ToInt32(_dbGenericCommands.ExecuteScalar(query));
        }
    }
}
