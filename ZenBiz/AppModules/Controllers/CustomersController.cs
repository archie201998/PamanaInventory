using System.Data;
using System.Transactions;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class CustomersController : ICustomers
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblCustomers = "customers";

        public CustomersController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public int Count()
        {
            string query = $"SELECT COUNT(id) FROM {tblCustomers}";
            string result = _dbGenericCommands.ExecuteScalar(query);
            if (string.IsNullOrWhiteSpace(result)) return 0;
            return Convert.ToInt32(result);
        }

        public bool Delete(List<CustomersModel> entityList)
        {
            using var scope = new TransactionScope();
            foreach (var entity in entityList)
            {
                var parameters = new object[][]
                {
                    new object[] { "@id", DbType.Int32, entity.Id},
                };

                string query = $"DELETE FROM {tblCustomers} WHERE id = @id";
                _ = _dbGenericCommands.ExecuteNonQuery(query, parameters);
            }

            scope.Complete();
            scope.Dispose();
            return true;
        }

        public DataTable Fetch()
        {
            string query = $"SELECT id, name, contact_info, address FROM {tblCustomers} ORDER BY name";
            return _dbGenericCommands.Fill(query);
        }

        public DataTable FetchBySearch(string searchText)
        {
            var parameters = new object[][]
            {
                new object[] { "@search_text", DbType.String,  $"%{searchText}%" },
            };

            string query = $"SELECT id, name, contact_info, address FROM {tblCustomers} WHERE name LIKE @search_text ORDER BY name";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public Dictionary<string, string> FindById(int Id)
        {
            Dictionary<string, string> record = new();

            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32,  Id },
            };

            string query = $"SELECT name, address, contact_info FROM {tblCustomers} WHERE id = @id";
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

        public bool Insert(CustomersModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@name", DbType.String, entity.Name },
                new object[] { "@contact_info", DbType.String, entity.ContactInfo },
                new object[] { "@address", DbType.String, entity.Address },
                new object[] { "@created_by", DbType.Int32, entity.Users.Id },
            };

            string query = $"INSERT INTO {tblCustomers} (name, contact_info, address, created_by) VALUES (@name, @contact_info, @address, @created_by)";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(CustomersModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32, entity.Id},
                new object[] { "@name", DbType.String, entity.Name },
                new object[] { "@contact_info", DbType.String, entity.ContactInfo },
                new object[] { "@address", DbType.String, entity.Address },
            };

            string query = $"UPDATE {tblCustomers} SET name = @name, contact_info = @contact_info, address = @address WHERE id = @id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }
    }
}
