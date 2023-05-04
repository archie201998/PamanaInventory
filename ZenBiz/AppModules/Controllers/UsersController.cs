using System.Data;
using System.Transactions;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class UsersController : IUsers
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblUsers = "users";
        private const string viewUsers = "view_users";

        public UsersController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<UsersModel> entityList)
        {
            using var scope = new TransactionScope();
            foreach (var entity in entityList)
            {
                var parameters = new object[][]
                {
                    new object[] { "@id", DbType.Int32, entity.Id},
                };

                string query = $"DELETE FROM {tblUsers} WHERE id = @id";
                _ = _dbGenericCommands.ExecuteNonQuery(query, parameters);
            }

            scope.Complete();
            scope.Dispose();
            return true;
        }

        public DataTable Fetch()
        {
            string query = $"SELECT id, roles_id, first_name, last_name, username, role_name FROM {viewUsers} WHERE role_name != 'SysAdmin'";
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

            string query = $"SELECT roles_id, role_name, first_name, last_name, username, password, role_name FROM {viewUsers} WHERE id = @id";
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

        public bool Insert(UsersModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@roles_id", DbType.Int32, entity.Roles.Id },
                new object[] { "@first_name", DbType.String, entity.FirstName },
                new object[] { "@last_name", DbType.String, entity.LastName },
                new object[] { "@username", DbType.String, entity.UserName },
                new object[] { "@password", DbType.String, entity.Password },
            };

            string query = $"INSERT INTO {tblUsers} (roles_id, first_name, last_name, username, password) VALUES (@roles_id, @first_name, @last_name, @username, SHA2(@password, 224))";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(UsersModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32, entity.Id },
                new object[] { "@roles_id", DbType.Int32, entity.Roles.Id },
                new object[] { "@first_name", DbType.String, entity.FirstName },
                new object[] { "@last_name", DbType.String, entity.LastName },
                new object[] { "@username", DbType.String, entity.UserName },
                new object[] { "@password", DbType.String, entity.Password },
            };

            string query = $"UPDATE {tblUsers} SET roles_id = @roles_id, first_name = @first_name, last_name = @last_name, username = @username, password = SHA2(@password, 224) WHERE id = @id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool UpdateWithoutPassword(UsersModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32, entity.Id },
                new object[] { "@roles_id", DbType.Int32, entity.Roles.Id },
                new object[] { "@first_name", DbType.String, entity.FirstName },
                new object[] { "@last_name", DbType.String, entity.LastName },
                new object[] { "@username", DbType.String, entity.UserName },
            };

            string query = $"UPDATE {tblUsers} SET roles_id = @roles_id, first_name = @first_name, last_name = @last_name, username = @username WHERE id = @id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool UsernameExist(string username)
        {
            var parameters = new object[][]
            {
                new object[] { "@username", DbType.String, username },
            };

            string query = $"SELECT id FROM {tblUsers} WHERE username = @username";
            string result = _dbGenericCommands.ExecuteScalar(query, parameters);
            if (string.IsNullOrWhiteSpace(result)) return false;
            return true;
        }

        public int? Authenticate(string username, string password)
        {
            var parameters = new object[][]
            {
                new object[] { "@username", DbType.String, username },
                new object[] { "@password", DbType.String, password },
            };

            string query = $"SELECT id FROM {tblUsers} WHERE username = @username AND password = SHA2(@password, 224)";
            string result = _dbGenericCommands.ExecuteScalar(query, parameters);
            if (string.IsNullOrWhiteSpace(result)) return null;
            return Convert.ToInt32(result);
        }

        public bool CheckCurrentPassword(int userId, string password)
        {
            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32, userId },
                new object[] { "@password", DbType.String, password },
            };

            string query = $"SELECT id FROM {tblUsers} WHERE id = @id AND password = SHA2(@password, 224)";
            string result = _dbGenericCommands.ExecuteScalar(query, parameters);
            if (string.IsNullOrWhiteSpace(result)) return false;
            return true;
        }

        public bool ChangePassword(int userId, string password)
        {
            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32, userId },
                new object[] { "@password", DbType.String, password },
            };

            string query = $"UPDATE {tblUsers} SET password = SHA2(@password, 224) WHERE id = @id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }
    }
}
