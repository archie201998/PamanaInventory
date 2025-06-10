using System.Data;
using System.Transactions;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class BranchController : IStore
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblStores = "branches";

        public BranchController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<BranchModel> entityList)
        {
            using var scope = new TransactionScope();
            foreach (var entity in entityList)
            {
                var parameters = new object[][]
                {
                    new object[] { "@id", DbType.Int32, entity.Id},
                };

                string query = $"DELETE FROM {tblStores} WHERE id = @id";
                _ = _dbGenericCommands.ExecuteNonQuery(query, parameters);
            }

            scope.Complete();
            scope.Dispose();
            return true;
        }

        public DataTable Fetch()
        {
            string query = $"SELECT id, name, address FROM {tblStores} ORDER BY name";
            return _dbGenericCommands.Fill(query);
        }

        public DataTable FetchBySearch(string searchText)
        {
            var parameters = new object[][]
            {
                new object[] { "@name", DbType.String, $"%{searchText}%"},
            };

            string query = $"SELECT id, name, address FROM {tblStores} WHERE name LIKE @name";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public Dictionary<string, string> FindById(int Id)
        {
            Dictionary<string, string> record = new();

            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32,  Id },
            };

            string query = $"SELECT name, address FROM {tblStores} WHERE id = @id";
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

        public bool Insert(BranchModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@name", DbType.String, entity.Name },
                new object[] { "@address", DbType.String, entity.Address },
            };

            string query = $"INSERT INTO {tblStores} (name, address) VALUES (@name, @address)";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(BranchModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32, entity.Id},
                new object[] { "@name", DbType.String, entity.Name },
                new object[] { "@address", DbType.String, entity.Address },
            };

            string query = $"UPDATE {tblStores} SET name = @name, address = @address WHERE id = @id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }
    }
}
