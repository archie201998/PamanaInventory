using System.Data;
using System.Transactions;
using ZenBiz.AppModules.Interfaces;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Controllers
{
    internal class PurchaseController : IPurchases
    {
        private readonly IDbGenericCommands _dbGenericCommands;
        private const string tblPurchase = "purchases";
        private const string viewPurchases = "view_purchases";

        public PurchaseController(IDbGenericCommands dbGenericCommands)
        {
            _dbGenericCommands = dbGenericCommands;
        }

        public int LastInsertedId()
        {
            string query = $"SELECT MAX(id) FROM {tblPurchase}";
            return Convert.ToInt32(_dbGenericCommands.ExecuteScalar(query));
        }

        public bool IdExist(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable Fetch()
        {
            throw new NotImplementedException();
        }
        public DataTable FetchByDatePeriod(DateTime purchasedDateFrom, DateTime purchaseDateTo)
        {
            var parameters = new object[][]
            {
                new object[] { "@purchase_date_from", DbType.Date, purchasedDateFrom },
                new object[] { "@purchase_date_to", DbType.Date, purchaseDateTo },
            };
            string query = $"SELECT id, suppliers_id, name, purchase_date FROM {viewPurchases} WHERE purchase_date BETWEEN @purchase_date_from AND @purchase_date_to ORDER BY purchase_date DESC";
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

            string query = $"SELECT id, suppliers_id, name, address, contact_info, purchase_date FROM {viewPurchases} WHERE id = @id";

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

        public bool Insert(PurchasesModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@suppliers_id", DbType.Int32, entity.Supplier.Id != 0 ? entity.Supplier.Id : DBNull.Value },
                new object[] { "@purchase_date", DbType.Date, entity.TransactionDate },
                new object[] { "@created_by", DbType.Int32, entity.Users.Id },
            };

            string query = $"INSERT INTO {tblPurchase} (suppliers_id, purchase_date, created_by) VALUES (@suppliers_id, @purchase_date, @created_by)";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Update(PurchasesModel entity)
        {
            var parameters = new object[][]
            {
                new object[] { "@id", DbType.Int32, entity.Id },
                new object[] { "@suppliers_id", DbType.Int32, entity.Supplier.Id != 0 ? entity.Supplier.Id : DBNull.Value },
                new object[] { "@purchase_date", DbType.Date, entity.TransactionDate },
                new object[] { "@updated_by", DbType.Int32, entity.Users.Id },
            };

            string query = $"UPDATE {tblPurchase} SET suppliers_id = @suppliers_id, purchase_date = @purchase_date,  updated_by = @updated_by WHERE id = @id";
            return _dbGenericCommands.ExecuteNonQuery(query, parameters);
        }

        public bool Delete(List<PurchasesModel> entityList)
        {
            using var scope = new TransactionScope();
            foreach (var entity in entityList)
            {
                var parameters = new object[][]
                {
                    new object[] { "@id", DbType.Int32, entity.Id},
                };

                string query = $"DELETE FROM {tblPurchase} WHERE id = @id";
                _ = _dbGenericCommands.ExecuteNonQuery(query, parameters);
            }

            scope.Complete();
            scope.Dispose();
            return true;
        }


    }
}
