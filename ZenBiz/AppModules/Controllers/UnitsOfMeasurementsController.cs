using System.Data;
using System.Transactions;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class UnitsOfMeasurementsController : IUnitsOfMeasurements
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblUnitMeasurements = "unit_measurements";

        public UnitsOfMeasurementsController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<UnitOfMeasurementsModel> entityList)
        {
            using var scope = new TransactionScope();
            foreach (var entity in entityList)
            {
                var parameters = new object[][]
                {
                    new object[] { "@id", DbType.Int32, entity.Id},
                };

                string query = $"DELETE FROM {tblUnitMeasurements} WHERE id = @id";
                _ = _dbGenericCommands.ExecuteNonQuery(query, parameters);
            }

            scope.Complete();
            scope.Dispose();
            return true;
        }

        public DataTable Fetch()
        {
            string query = $"SELECT id, abbreviation, name FROM {tblUnitMeasurements} ORDER BY name";
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

            string query = $"SELECT abbreviation, name FROM {tblUnitMeasurements} WHERE id = @id";
            using (var reader = _dbGenericCommands.ExecuteReader(query, parameters))
            {
                if (reader.Rows.Count == 0) return record;
                record.Add("abbreviation", reader.Rows[0]["abbreviation"].ToString());
                record.Add("name", reader.Rows[0]["name"].ToString());
            }

            return record;
        }

        public bool IdExist(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(UnitOfMeasurementsModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@abbreviation", DbType.String, entity.Abbreviation },
                new object[] { "@name", DbType.String, entity.Name },
            };

            string query = $"INSERT INTO {tblUnitMeasurements} (abbreviation, name) VALUES (@abbreviation, @name)";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(UnitOfMeasurementsModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32, entity.Id },
                new object[] { "@abbreviation", DbType.String, entity.Abbreviation },
                new object[] { "@name", DbType.String, entity.Name },
            };

            string query = $"UPDATE {tblUnitMeasurements} SET abbreviation = @abbreviation, name = @name WHERE id = @id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }
    }
}
