using System.Data;
using System.Transactions;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class PersonnelController : IPersonnel
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblPersonnel = "personnel";

        public PersonnelController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<PersonnelModel> entityList)
        {
            using var scope = new TransactionScope();
            foreach (var entity in entityList)
            {
                var parameters = new object[][]
                {
                    new object[] { "@id", DbType.Int32, entity.Id},
                };

                string query = $"DELETE FROM {tblPersonnel} WHERE id = @id";
                _ = _dbGenericCommands.ExecuteNonQuery(query, parameters);
            }

            scope.Complete();
            scope.Dispose();
            return true;
        } 

        public DataTable Fetch()
        {
            string query = $"SELECT id, name, contact_info, address, designation FROM {tblPersonnel} ORDER BY name";
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

            string query = $"SELECT name, address, contact_info, designation FROM {tblPersonnel} WHERE id = @id";
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

        public bool Insert(PersonnelModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@name", DbType.String, entity.Name },
                new object[] { "@contact_info", DbType.String, entity.ContactInfo },
                new object[] { "@address", DbType.String, entity.Address },
                new object[] { "@designation", DbType.String, entity.Designation},
                new object[] { "@created_by", DbType.Int32, entity.Users.Id },
            };

            string query = $"INSERT INTO {tblPersonnel} (name, contact_info, address, designation, created_by) VALUES (@name, @contact_info, @address, @designation, @created_by)";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(PersonnelModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32, entity.Id },
                new object[] { "@name", DbType.String, entity.Name },
                new object[] { "@contact_info", DbType.String, entity.ContactInfo },
                new object[] { "@address", DbType.String, entity.Address },
                new object[] { "@designation", DbType.String, entity.Designation},
                new object[] { "@created_by", DbType.Int32, entity.Users.Id },
            };

            string query = $"UPDATE {tblPersonnel} SET name = @name, contact_info = @contact_info, address = @address, designation = @designation WHERE id = @id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }
    }
}