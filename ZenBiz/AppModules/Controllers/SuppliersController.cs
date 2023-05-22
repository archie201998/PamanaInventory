using System.Data;
using System.Transactions;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class SuppliersController : ISupplier
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblSuppliers = "suppliers";

        public SuppliersController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<SupplierModel> entityList)
        {
            using TransactionScope scope = new();
            foreach (var entity in entityList)
            {
                var parameters = new object[][]
                {
                    new object[] { "@id", DbType.Int32, entity.Id},
                };

                string query = $"DELETE FROM {tblSuppliers} WHERE id = @id";
                _ = _dbGenericCommands.ExecuteNonQuery(query, parameters);
            }

            scope.Complete();
            scope.Dispose();
            return true;
        }

        public DataTable Fetch()
        {
            string query = $"SELECT id, name, address, contact_info FROM {tblSuppliers} ORDER BY name";
            return _dbGenericCommands.Fill(query);
        }

        public DataTable FetchBySearch(string searchText)
        {
            var parameters = new object[][]
            {
                new object[] { "@search_text", DbType.String,  $"%{searchText}%" },
            };

            string query = $"SELECT id, name, contact_info, address FROM {tblSuppliers} WHERE name LIKE @search_text ORDER BY name";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public Dictionary<string, string> FindById(int id)
        {
            Dictionary<string, string> record = new();

            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32, id },
            };

            string query = $"SELECT name, address, contact_info FROM {tblSuppliers} WHERE id = @id";
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

        public bool Insert(SupplierModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@name", DbType.String, entity.Name },
                new object[] { "@address", DbType.String, entity.Address },
                new object[] { "@contact_info", DbType.String, entity.ContactInfo },
            };

            string query = $"INSERT INTO {tblSuppliers} (name, address, contact_info) VALUES (@name, @address, @contact_info)";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(SupplierModel entity)
        {
            var parameters = new object[][]
            {
                new object[] {"@id", DbType.Int32, entity.Id },
                new object[] { "@name", DbType.String, entity.Name },
                new object[] { "@address", DbType.String, entity.Address },
                new object[] { "@contact_info", DbType.String, entity.ContactInfo },
            };

            string query = $"UPDATE {tblSuppliers} SET name = @name, address = @address, contact_info = @contact_info WHERE id = @id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }
    }
}
