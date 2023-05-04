using System.Data;
using System.Transactions;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class WarehousesController : IWarehouses
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblWarehouses = "warehouses";

        public WarehousesController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<WarehousesModel> entityList)
        {
            using var scope = new TransactionScope();
            foreach (var entity in entityList)
            {
                var parameters = new object[][]
                {
                    new object[] { "@id", DbType.Int32, entity.Id},
                };

                string query = $"DELETE FROM {tblWarehouses} WHERE id = @id";
                _ = _dbGenericCommands.ExecuteNonQuery(query, parameters);
            }

            scope.Complete();
            scope.Dispose();
            return true;
        }

        public DataTable Fetch()
        {
            string query = $"SELECT id, name, address FROM {tblWarehouses} ORDER BY name";
            return _dbGenericCommands.Fill(query);
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

            string query = $"SELECT name, address FROM {tblWarehouses} WHERE id = @id";
            using (var reader = _dbGenericCommands.ExecuteReader(query, parameters))
            {
                if (reader.Rows.Count == 0) return record;
                record.Add("name", reader.Rows[0]["name"].ToString());
                record.Add("address", reader.Rows[0]["address"].ToString());
            }

            return record;
        }

        public bool IdExist(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(WarehousesModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@name", DbType.String, entity.Name },
                new object[] { "@address", DbType.String, entity.Address },
            };

            string query = $"INSERT INTO {tblWarehouses} (name, address) VALUES (@name, @address)";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(WarehousesModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32, entity.Id},
                new object[] { "@name", DbType.String, entity.Name },
                new object[] { "@address", DbType.String, entity.Address },
            };

            string query = $"UPDATE {tblWarehouses} SET name = @name, address = @address WHERE id = @id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }
    }
}
