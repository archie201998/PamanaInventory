using System.Data;
using System.Transactions;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class ItemsController : IItems
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblItems = "items";
        private const string viewItems = "view_items";

        public ItemsController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public int Count()
        {
            string query = $"SELECT COUNT(id) FROM {tblItems}";
            string result = _dbGenericCommands.ExecuteScalar(query);
            if (string.IsNullOrWhiteSpace(result)) return 0;
            return Convert.ToInt32(result);
        }

        public bool Delete(List<ItemsModel> entityList)
        {
            using var scope = new TransactionScope();
            foreach (var entity in entityList)
            {
                var parameters = new object[][]
                {
                    new object[] { "@id", DbType.Int32, entity.Id},
                };

                string query = $"DELETE FROM {tblItems} WHERE id = @id";
                _ = _dbGenericCommands.ExecuteNonQuery(query, parameters);
            }

            scope.Complete();
            scope.Dispose();
            return true;
        }

        public DataTable Fetch()
        {
            string query = $"SELECT id, name, code, category_name, unit_name FROM {viewItems} ORDER BY name";
            return _dbGenericCommands.Fill(query);
        }

        public DataTable Fetch(int categoriesId)
        {
            var parameters = new object[][]
            {
                new object[] { "@categories_id", DbType.Int32, categoriesId },
            };

            string query = $"SELECT id, name, code, category_name, unit_name FROM {viewItems} WHERE categories_id = @categories_id ORDER BY name";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public DataTable FetchBySearch(string searchText)
        {
            var parameters = new object[][]
            {
                new object[] { "@search_text", DbType.String, $"%{searchText}%"},
            };

            string query = $"SELECT id, code, name, category_name, unit_name FROM {viewItems} WHERE name LIKE @search_text";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public Dictionary<string, string> FindById(int Id)
        {
            Dictionary<string, string> record = new();

            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32,  Id },
            };

            string query = $"SELECT categories_id, unit_measurements_id,  name, code, created_by, created_time, updated_by, updated_time, category_name, unit_abbreviation, unit_name FROM {viewItems} WHERE id = @id";
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

        public bool Insert(ItemsModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@categories_id", DbType.Int32, entity.Categories.Id},
                new object[] { "@unit_measurements_id", DbType.Int32, entity.UnitOfMeasurements.Id},
                new object[] { "@name", DbType.String, entity.Name },
                new object[] { "@created_by", DbType.Int32, entity.Users.Id},
            };

            string query = $"INSERT INTO {tblItems} (categories_id, unit_measurements_id, code, name, created_by) VALUES (@categories_id, @unit_measurements_id, @code, @name, @created_by)";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(ItemsModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32, entity.Id},
                new object[] { "@unit_measurements_id", DbType.Int32, entity.UnitOfMeasurements.Id},
                new object[] { "@name", DbType.String, entity.Name },
                new object[] { "@code", DbType.String, entity.Code },
                new object[] { "@created_by", DbType.Int32, entity.Users.Id},
            };

            string query = $"UPDATE {tblItems} SET categories_id = @categories_id, unit_measurements_id = @unit_measurements_id, name = @name, code = @code, updated_by = @updated_by WHERE id = @id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public int LastInsertedId()
        {
            string query = $"SELECT MAX(id) FROM {tblItems}";
            return Convert.ToInt32(_dbGenericCommands.ExecuteScalar(query));
        }
    }
}
