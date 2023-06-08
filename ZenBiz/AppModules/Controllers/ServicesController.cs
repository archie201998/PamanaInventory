using System.Data;
using System.Transactions;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class ServicesController : IServices
    {

        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblServices = "services";

        public ServicesController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public bool IdExist(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable Fetch()
        {
            string query = $"SELECT id, name, fee  FROM {tblServices} ORDER BY name";
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

            string query = $"SELECT id, name, fee  FROM  {tblServices} WHERE id = @id";
            using (var reader = _dbGenericCommands.ExecuteReader(query, parameters))
            {
                if (reader.Rows.Count == 0) return record;
                foreach (DataColumn column in reader.Columns)
                    record.Add(column.ColumnName, reader.Rows[0][column.ColumnName].ToString());
            }

            return record;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Insert(ServicesModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@name", DbType.String, entity.Name },
                new object[] { "@fee", DbType.String, entity.Fee },
                new object[] { "@created_by", DbType.Int32, entity.Users.Id },
            };

            string query = $"INSERT INTO {tblServices} (name, fee, created_by) VALUES (@name, @fee, @created_by)";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(ServicesModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32, entity.Id},
                new object[] { "@name", DbType.String, entity.Name },
                new object[] { "@fee", DbType.Decimal, entity.Fee },
                new object[] { "@created_by", DbType.Int32, entity.Users.Id },
            };

            string query = $"UPDATE {tblServices} SET name = @name, fee = @fee WHERE id = @id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Delete(List<ServicesModel> entityList)
        {
            using var scope = new TransactionScope();
            foreach (var entity in entityList)
            {
                var parameters = new object[][]
                {
                    new object[] { "@id", DbType.Int32, entity.Id},
                };

                string query = $"DELETE FROM {tblServices} WHERE id = @id";
                _ = _dbGenericCommands.ExecuteNonQuery(query, parameters);
            }

            scope.Complete();
            scope.Dispose();
            return true;
        }
    }
}