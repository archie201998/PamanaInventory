using System.Data;
using System.Transactions;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class SalesController : ISales
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblSales = "sales";
        private const string viewSales = "view_sales";

        public SalesController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<SalesModel> entityList)
        {
            using var scope = new TransactionScope();
            foreach (var entity in entityList)
            {
                var parameters = new object[][]
                {
                    new object[] { "@id", DbType.Int32, entity.Id},
                };

                string query = $"DELETE FROM {tblSales} WHERE id = @id";
                _ = _dbGenericCommands.ExecuteNonQuery(query, parameters);
            }

            scope.Complete();
            scope.Dispose();
            return true;
        }

        public DataTable Fetch()
        {
            string query = $"SELECT id, customers_id, trans_no, trans_date, trans_due_date, customer_name FROM {viewSales} ORDER BY trans_date DESC";
            return _dbGenericCommands.Fill(query);
        }

        public DataTable Fetch(DateTime transactionDate)
        {
            var parameters = new object[][]
            {
                new object[] { "@trans_date", DbType.Date, transactionDate },
            };
            string query = $"SELECT id, customers_id, trans_no, trans_date, trans_due_date, customer_name FROM {viewSales} WHERE trans_date = @trans_date ORDER BY trans_date DESC";
            return _dbGenericCommands.Fill(query, parameters);
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

            string query = $"SELECT customers_id, trans_no, trans_date, created_by, created_time, updated_by, updated_time, customer_name, customer_contact_info, customer_address FROM {viewSales} WHERE id = @id";
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

        public bool Insert(SalesModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@customers_id", DbType.Int32, entity.Customers.Id != 0 ? entity.Customers.Id : DBNull.Value },
                new object[] { "@trans_no", DbType.String, entity.TransactioNo },
                new object[] { "@trans_date", DbType.Date, entity.TransactionDate },
                new object[] { "@trans_due_date", DbType.Date, entity.TransactionDueDate },
                new object[] { "@created_by", DbType.Int32, entity.Users.Id },
            };

            string query = $"INSERT INTO {tblSales} (customers_id, trans_no, trans_date, trans_due_date, created_by) VALUES (@customers_id, @trans_no, @trans_date, @trans_due_date, @created_by)";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(SalesModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32, entity.Id },
                new object[] { "@customers_id", DbType.Int32, entity.Customers.Id != 0 ? entity.Customers.Id : DBNull.Value },
                new object[] { "@trans_no", DbType.String, entity.TransactioNo },
                new object[] { "@trans_date", DbType.Date, entity.TransactionDate },
                new object[] { "@updated_by", DbType.Int32, entity.Users.Id },
            };

            string query = $"UPDATE {tblSales} SET customers_id = @customers_id, trans_no = @trans_no, trans_date = @trans_date, updated_by = @updated_by WHERE id = @id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public int LastInsertedId()
        {
            string query = $"SELECT MAX(id) FROM {tblSales}";
            return Convert.ToInt32(_dbGenericCommands.ExecuteScalar(query));
        }

        public int GenerateTransactionNumber()
        {
            string query = $"SELECT coalesce(MAX(id), 0) + 1 FROM {tblSales}";
            return Convert.ToInt32(_dbGenericCommands.ExecuteScalar(query));
        }

        public DataTable FetchByCustomerID(int customerID)
        {
            var parameters = new object[][]
            {
                new object[] { "@customers_id", DbType.Int32, customerID },
            };
            string query = $"SELECT id, trans_no, trans_date, trans_due_date FROM {viewSales} WHERE customers_id = @customers_id ORDER BY trans_date DESC";
            return _dbGenericCommands.Fill(query, parameters);
        }

        public Dictionary<string, string> FetchByTransactionNo(string transactionNo)
        {
            Dictionary<string, string> record = new();

            var parameters = new object[][]
            {
                new object[] { "@trans_no", DbType.String,  transactionNo },
            };

            string query = $"SELECT id, customers_id, trans_no, trans_date, created_by, created_time, updated_by, updated_time, customer_name, customer_contact_info, customer_address FROM {viewSales} WHERE trans_no = @trans_no";
            using (var reader = _dbGenericCommands.ExecuteReader(query, parameters))
            {
                if (reader.Rows.Count == 0) return record;
                foreach (DataColumn column in reader.Columns)
                    record.Add(column.ColumnName, reader.Rows[0][column.ColumnName].ToString());
            }

            return record;
        }

        public DataTable FetchSalesDue(int monthId)
        {
            var parameters = new object[][]
            {
                new object[] { "@month", DbType.Int32, monthId },
            };
            string query = $"SELECT id, customer_name, trans_no, trans_date, trans_due_date FROM {viewSales} WHERE MONTH(trans_due_date) = @month";
            return _dbGenericCommands.Fill(query, parameters);
        }
    }
}
