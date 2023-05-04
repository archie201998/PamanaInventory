using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace ZenBiz.AppModules
{
    internal class MySQLGenericCommands : IDbGenericCommands
    {
        private readonly string connectionString;

        public MySQLGenericCommands()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ZenBizInstance"].ConnectionString;
        }

        private void AddDbParameter(MySqlCommand command, object[] param)
        {
            DbParameter dbParameter = command.CreateParameter();
            dbParameter.ParameterName = param[0].ToString();
            dbParameter.DbType = (DbType)param[1];
            dbParameter.Value = param[2];
            command.Parameters.Add(dbParameter);
        }

        public DataTable Fill(string query)
        {
            DataTable dataTable = new();
            using (var connection = new MySqlConnection(connectionString))
            {
                var adapter = new MySqlDataAdapter();
                adapter.SelectCommand = new MySqlCommand(query, connection);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public DataTable Fill(string query, params object[][] parameters)
        {
            DataTable dataTable = new();
            using (var connection = new MySqlConnection(connectionString))
            {
                var adapter = new MySqlDataAdapter();
                using (adapter.SelectCommand = new MySqlCommand(query, connection))
                {
                    foreach (var param in parameters)
                        AddDbParameter(adapter.SelectCommand, param);

                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        public bool ExecuteNonQuery(string query, params object[][] parameters)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    foreach (var param in parameters)
                        AddDbParameter(command, param);

                    connection.Open();
                    if (command.ExecuteNonQuery() > 0)
                        return true;

                    return false;
                }
            }
        }

        public DataTable ExecuteReader(string query, object[][] parameters)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    foreach (var param in parameters)
                        AddDbParameter(command, param);

                    connection.Open();
                    var reader = command.ExecuteReader();
                    var dataTable = new DataTable();
                    dataTable.Load(reader);

                    return dataTable;
                }
            }
        }

        public string ExecuteScalar(string query, params object[][] parameters)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    foreach (var param in parameters)
                        AddDbParameter(command, param);

                    connection.Open();
                    if (command.ExecuteScalar() != null)
                        return command.ExecuteScalar().ToString();

                    return string.Empty;
                }
            }
        }

        public string ExecuteScalar(string query)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    if (command.ExecuteScalar() != null)
                        return command.ExecuteScalar().ToString();

                    return string.Empty;
                }
            }
        }
    }
}
